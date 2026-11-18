package ProcessingUnit.ProcessingUnitServer;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpServer;
import no.inductive.progsbase.supportlibs.ArrayConversions;

import java.io.*;
import java.net.InetSocketAddress;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Semaphore;

import static java.lang.Math.max;

public class ProcessingUnitServer {
    public static boolean ServerCheck(ProcessingUnitServerStructure pu) {
        return pu.receiveReady.availablePermits() == 1;
    }

    public static void ServerSend(ProcessingUnitServerStructure pu, ByteArray data) {
        pu.output = ArrayConversions.DoubleArrayToByteArray(data.bytes);

        pu.sendReady.release();
    }

    public static void ServerReceive(ProcessingUnitServerStructure pu, ByteArrayReference data) {

        try {
            pu.receiveReady.acquire();

            data.bytes = new ByteArray();
            data.bytes.bytes = ArrayConversions.ByteArrayToDoubleArray(pu.input);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public static void delete(Object object) {
        // Java has garbage collection.
    }

    public static void CloseHTTPServer(ProcessingUnitServerStructure pu) {
        try {
            pu.processing.acquire();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        pu.server.stop(0);
    }

    public static ProcessingUnitServerStructure CreateHTTPServer(String ip, int port) {
        ProcessingUnitServerStructure pu = new ProcessingUnitServerStructure();

        try {
            pu.receiveReady = new Semaphore(0);
            pu.sendReady = new Semaphore(0);
            pu.processing = new Semaphore(1);

            pu.server = HttpServer.create(new InetSocketAddress(ip, port), 0);
            pu.server.createContext("/", new MyHandler(pu));
            pu.server.setExecutor(null); // creates a default executor
            pu.server.start();
        } catch (Exception | Error e) {
            e.printStackTrace();
        }

        return pu;
    }

    static class MyHandler implements HttpHandler {
        private final ProcessingUnitServerStructure pu;

        public MyHandler(ProcessingUnitServerStructure pu) {
            this.pu = pu;
        }

        @Override
        public void handle(HttpExchange t) {
            try {
                pu.processing.acquire();

                String method = t.getRequestMethod();

                if(method.equals("POST") || method.equals("GET")) {
                    // Server Receive
                    StringBuilder sb = new StringBuilder();
                    sb.append(method + " " + t.getRequestURI() + " HTTP/1.1\r\n");
                    for(Map.Entry<String, List<String>> h : t.getRequestHeaders().entrySet()){
                        sb.append(h.getKey() + ": " + h.getValue().get(0) + "\r\n");
                    }
                    sb.append("\r\n");
                    byte [] a = sb.toString().getBytes(StandardCharsets.ISO_8859_1);
                    byte [] b = InputSteamToByteArray(t.getRequestBody());

                    pu.input = b;

                    pu.receiveReady.release();

                    pu.sendReady.acquire();

                    // Server Send
                    int code = 200;

                    t.sendResponseHeaders(code, pu.output.length);
                    OutputStream os = t.getResponseBody();
                    os.write(pu.output);
                    os.close();
                }else{
                    t.sendResponseHeaders(405, 0);
                }
            } catch (Exception | Error e) {
                e.printStackTrace();
            }finally {
                pu.processing.release();
            }
        }
    }

    public static byte[] InputSteamToByteArray(InputStream is) {
        ByteArrayOutputStream buffer = new ByteArrayOutputStream();

        try {
            int nRead;
            byte[] data = new byte[16384];

            while ((nRead = is.read(data, 0, data.length)) != -1) {
                buffer.write(data, 0, nRead);
            }

        } catch (IOException e) {
            e.printStackTrace();
        }

        return buffer.toByteArray();
    }
}

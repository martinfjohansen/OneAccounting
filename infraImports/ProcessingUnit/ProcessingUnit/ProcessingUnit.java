package ProcessingUnit.ProcessingUnit;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import ProcessingUnit.ProcessingUnitServer.ProcessingUnitServer;
import no.inductive.progsbase.supportlibs.ArrayConversions;

import java.io.DataOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.concurrent.Semaphore;

public class ProcessingUnit {
    public static ProcessingUnitStructure CreateHttpClient(String ip, int port) {
        ProcessingUnitStructure pu;

        pu = new ProcessingUnitStructure();

        pu.ip = ip;
        pu.port = port;
        pu.processing = new Semaphore(1);
        pu.sendReady = new Semaphore(0);
        pu.receiveReady = new Semaphore(0);

        pu.myHandler = new MyHandler(pu);
        pu.myHandler.start();

        return pu;
    }

    public static void CloseHTTPClient(ProcessingUnitStructure pu) {
        pu.myHandler.stop();
    }

    public static boolean Check(ProcessingUnitStructure pu) {
        boolean available;

        available = pu.receiveReady.availablePermits() == 1;

        return available;
    }

    public static void Send(ProcessingUnitStructure pu, ByteArray data) {
        pu.output = ArrayConversions.DoubleArrayToByteArray(data.bytes);
        pu.sendReady.release();
    }

    public static void Receive(ProcessingUnitStructure pu, ByteArrayReference data) {
        try {
            pu.receiveReady.acquire();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        data.bytes = new ByteArray();
        data.bytes.bytes = ArrayConversions.ByteArrayToDoubleArray(pu.input);
    }

    public static void Call(ProcessingUnitStructure pu, ByteArray request, ByteArrayReference response) {
        Send(pu, request);
        Receive(pu, response);
    }

    public static void delete(Object object) {
        // Java has garbage collection.
    }

    static class MyHandler extends Thread {
        private final ProcessingUnitStructure pu;

        public MyHandler(ProcessingUnitStructure pu) {
            this.pu = pu;
        }

        @Override
        public void run() {
            boolean success;

            for (; ; ) {
                try {
                    pu.processing.acquire();

                    pu.sendReady.acquire();

                    // Server Receive
                    HttpURLConnection connection = null;

                    try {
                        byte[] output = pu.output;

                        // Create connection
                        URL url = new URL("http://" + pu.ip + ":" + pu.port);
                        connection = (HttpURLConnection) url.openConnection();
                        connection.setRequestMethod("POST");
                        connection.setRequestProperty("Content-Type", "application/octet-stream");
                        connection.setRequestProperty("Content-Length", Integer.toString(output.length));

                        connection.setUseCaches(false);
                        connection.setDoOutput(true);
                        connection.setConnectTimeout(10 * 60 * 1000);
                        connection.setReadTimeout(10 * 60 * 1000);

                        // Send request
                        DataOutputStream wr = new DataOutputStream(connection.getOutputStream());
                        wr.write(output);
                        wr.close();

                        // Get Response
                        int statusCode = connection.getResponseCode();

                        InputStream is = null;
                        if (statusCode / 100 == 2) {
                            is = connection.getInputStream();
                        } else if (statusCode / 100 == 5 || statusCode / 100 == 4) {
                            is = connection.getErrorStream();
                        } else {
                            is = connection.getInputStream();
                        }

                        pu.input = ProcessingUnitServer.InputSteamToByteArray(is);

                        pu.receiveReady.release();
                    } catch (Exception | Error e) {
                        e.printStackTrace();
                    } finally {
                        if (connection != null) {
                            connection.disconnect();
                        }
                    }

                    pu.processing.release();

                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
            }
        }
    }

}


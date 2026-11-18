package ProcessingUnit.ProcessingUnitServer;

import ProcessingUnitController.ProcessingUnitController.ProcessingUnitControllerStructure;
import com.sun.net.httpserver.HttpServer;

import java.util.concurrent.Semaphore;

public class ProcessingUnitServerStructure{
	public Semaphore receiveReady;
	public Semaphore sendReady;
	public HttpServer server;
	public byte[] input;
	public byte[] output;
	public Semaphore processing;
	public ProcessingUnitControllerStructure puc;
}

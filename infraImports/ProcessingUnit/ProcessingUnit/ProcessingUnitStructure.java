package ProcessingUnit.ProcessingUnit;

import java.util.concurrent.Semaphore;

public class ProcessingUnitStructure{
    public String ip;
    public int port;
    public Semaphore processing;
    public Semaphore sendReady;
    public Semaphore receiveReady;
    public byte[] output;
    public byte[] input;
    public ProcessingUnit.MyHandler myHandler;
}

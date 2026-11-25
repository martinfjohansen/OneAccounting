package ProcessingUnitController.ProcessingUnitController;

import java.util.concurrent.Semaphore;
import java.util.concurrent.TimeUnit;

public class ProcessingUnitController {


    public static ProcessingUnitControllerStructure CreateJavaPUC() {
        ProcessingUnitControllerStructure puc = new ProcessingUnitControllerStructure();

        puc.puMessageReady = new Semaphore(0);
        puc.wasException = false;

        return puc;
    }

    public static void WaitInterrupt(ProcessingUnitControllerStructure puc, double timeout) {
        if(timeout > 0d){
            try {
                puc.puMessageReady.tryAcquire(Math.round(timeout * 1000), TimeUnit.MILLISECONDS);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    public static boolean WasException(ProcessingUnitControllerStructure puc){
        return puc.wasException;
    }
}

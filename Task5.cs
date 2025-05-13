sealed class PrinterSpooler {

    private static PrinterSpooler _instance;

    private PrinterSpooler() {}

    public static PrinterSpooler GetInstance() {
        
        if (_instance == null) {
            _instance = new PrinterSpooler();
        }

        return _instance;
    }
    
}
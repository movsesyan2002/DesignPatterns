class Program {
    public static void Main(String[] args) {
        ConfigurationManager configurationManager = ConfigurationManager.Instance;
        ConfigurationManager configurationManager1= ConfigurationManager.Instance;

        configurationManager.Language = "English";
        configurationManager.Version = "1.0.0.1";

        Console.WriteLine(configurationManager1.Language);
    }
}
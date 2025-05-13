sealed class ConfigurationManager {
    public string Language { get; set; }
    public string Version { get; set; }

    private ConfigurationManager() {
    }

    private static ConfigurationManager? _configurationmanager;

    public static ConfigurationManager Instance {
        
        get {

            if (_configurationmanager == null) {

                _configurationmanager = new ConfigurationManager();

            }

            return _configurationmanager;

        }

    }


}



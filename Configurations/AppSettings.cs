namespace Configurations
{

    public class ConfigObject
    {
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        //public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
    }

    public class ConnectionStrings
    {
        public string ConnString1 { get; set; }
    }
}

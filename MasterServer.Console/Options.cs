﻿using CommandLine;

namespace MasterServer.Console
{
    public class Options
    {
        [Option("port", Required = false, DefaultValue = Settings.Port, HelpText = "Usage --port 28002")]
        public int Port { get; set; }
        [Option("ip", Required = false, DefaultValue = Settings.IPAddress, HelpText = "Usage --ip 127.0.0.1")]
        public string IPAddress { get; set; }
    }
}

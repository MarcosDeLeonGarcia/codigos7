using System;
using log4net;

[assembly: log4net.Config.BasicConfigurator(Watch = true)]
class Program {
    static readonly ILog log = LogManager.GetLogger(typeof(Program));
    static void Main() {
        Console.WriteLine("✅ .NET 8 en Codex funcionando");
        log.Info("Log4NET funcionando en Codex");
    }
}

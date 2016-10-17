using Serilog;

namespace TDD
{
    public static class LogBootstrapper
    {
        public static void Bootstrap()
        {
            var loggerConfig = new LoggerConfiguration()
                .WriteTo.ColoredConsole();
            Log.Logger = loggerConfig.CreateLogger();
        }
    }
}
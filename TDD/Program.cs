using System;
using Autofac;
using Serilog;

namespace TDD
{
    class Program
    {
        public static IContainer Container;
        private static ILogger _logger;

        static void Main(string[] args)
        {
            LogBootstrapper.Bootstrap();
            Container = IoC.LetThereBeIoC();

            _logger = Container.Resolve<ILogger>();
            _logger.Information("Application is Starting");

            Console.ReadLine();
        }
    }
}

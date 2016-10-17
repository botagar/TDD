using Autofac;

namespace TDD
{
    class Program
    {
        public static IContainer Container;

        static void Main(string[] args)
        {
            //TODO: Bootstrap Logger Here
            Container = IoC.LetThereBeIoC();
        }
    }
}

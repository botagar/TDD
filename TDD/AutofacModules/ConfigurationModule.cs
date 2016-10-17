using System.Reflection;
using Autofac;
using ConfigInjector.Configuration;
using Module = Autofac.Module;

namespace TDD.AutofacModules
{
    internal class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            ConfigurationConfigurator.RegisterConfigurationSettings()
                .FromAssemblies(Assembly.GetExecutingAssembly())
                .RegisterWithContainer(configSetting => builder.RegisterInstance(configSetting)
                    .AsSelf()
                    .SingleInstance())
                .DoYourThing();
        }
    }
}
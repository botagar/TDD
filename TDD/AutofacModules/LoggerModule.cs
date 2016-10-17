using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutofacSerilogIntegration;
using Serilog;

namespace TDD.AutofacModules
{
    class LoggerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterLogger();
        }
    }
}

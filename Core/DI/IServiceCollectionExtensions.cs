using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using Core.General;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DI
{
    public static class IServiceCollectionExtensions
    {
        public static IConfiguration Configuration { get; set; }

        public static AppSettings AddServiceCore(this IServiceCollection services, IConfiguration configuration)
        {
            // App configuration service
            var configApp = configuration.Get<AppSettings>();            // Load Config
            services.AddSingleton<AppSettings>(cfg => configApp); // Register Config Singleton
            return configApp;
        }

        public static IServiceCollection AutoDIRegisterService(this IServiceCollection services, Action<object> options = null)
        {
            var register = new AutoDIRegisterService(services);
            register.RegisterAssemblies();
            return services;
        }
    }
}

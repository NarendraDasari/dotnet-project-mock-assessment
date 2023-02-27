using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Porjects.MockAssessment
{
    public class AppSettingsBuilder
    {
        private readonly string _pathToSettingsFile;

        private readonly IServiceCollection _serviceCollection;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyPath">Path of your current executing assesmbly that your appSettings.json file is placed.</param>
        public AppSettingsBuilder(string assemblyPath)
        {
            this._pathToSettingsFile = assemblyPath;

            _serviceCollection = new ServiceCollection();


            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(assemblyPath)
                .AddJsonFile("appSettings.json", false)
                .Build();

            _serviceCollection.AddSingleton<IConfiguration>(configuration);

        }


        /// <summary>
        /// Gets the settings value by the key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValueBykey(string key)
        {
            string value = getValue(key);
            return value;

        }

        private string getValue(string key)
        {
            var serviceProvider = _serviceCollection.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();
            var value = configuration?.GetSection(key).Value;
            return value?? "";

        }


    }
}

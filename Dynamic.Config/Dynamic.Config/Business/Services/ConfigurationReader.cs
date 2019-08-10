using Dynamic.Config.Business.IServices;
using Dynamic.Config.Data.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dynamic.Config.Business.Services
{
    public class ConfigurationReader : IConfigurationReader
    {
        private string _applicationName;
        private string _connectionString;
        private long _refreshTimerIntervalInMs;

        public ConfigurationReader(string applicationName,long refreshTimerIntervalInMs)
        {
            if (string.IsNullOrEmpty(applicationName))
                throw new ArgumentNullException("applicationName cannot be null");

            _applicationName = applicationName;
            _refreshTimerIntervalInMs = refreshTimerIntervalInMs;
        }

        public  List<Configuration> Getall()
        {
            var b = new ConfigurationDataService();
          var a =  b.GetAllForServiceType(_applicationName);
            return a;
        }
    }
}
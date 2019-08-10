using Dynamic.Config.Business.IServices;
using Dynamic.Config.Common.Constants;
using Dynamic.Config.Data;
using Dynamic.Config.Data.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Config.Business.Services
{
    public class ConfigurationDataService : BaseService, IConfigurationDataService
    {
        public List<Configuration> GetAllForServiceType(string applicationName)
        {
            List<Configuration> result = null;

            try
            {
                var collection = MongoDbContext.GetCollection<Configuration>(ConfigurationConstant.MongoDBCollectionName);
                if (collection != null)
                {
                    var filter = Builders<Configuration>.Filter.Eq(a => a.IsActive, true);
                    filter = filter & Builders<Configuration>.Filter.Eq(a => a.ApplicationName, applicationName);
                    result = collection.FindSync(filter).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}

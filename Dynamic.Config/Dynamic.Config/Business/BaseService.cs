using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic.Config.Business
{
    public class BaseService
    {
        protected IMongoDatabase MongoDbContext { get; set; }
        //protected ICacheManager CacheManager { get; set; }

        public BaseService()
        {
                
        }
    }
}

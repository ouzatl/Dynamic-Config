using Dynamic.Config.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Config.Business.IServices
{
    public interface IConfigurationReader
    {
        List<Configuration> Getall();
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD.COMMON
{
    public class AppSettings
    {
        public static void Init(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("ConnectionString");
        }

        public static string ConnectionString = string.Empty;
    }
}

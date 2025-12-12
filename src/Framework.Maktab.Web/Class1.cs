using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Framework.Maktab.Web
{
    public class Class1
    {
        public Class1(ILogger logger)
        {
            logger.LogInformation("Class1 created");    
        }
    }
}

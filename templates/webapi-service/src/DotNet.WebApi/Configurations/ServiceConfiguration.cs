using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.WebApi.Configurations
{
    public class ServiceConfiguration
    {
#if(useSwagger)
        /// <summary>
        /// Service name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Service version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Service description
        /// </summary>
        public string Description { get; set; }
#endif
    }
}
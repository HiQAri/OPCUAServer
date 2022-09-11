using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OPCUAServer
{
    [DataContract(Namespace = Namespaces.OPCUAServer)]
    public class MySiteServerConfiguration
    {
        public MySiteServerConfiguration()
        {
            Initialize();
        }
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
        private void Initialize()
        {
        }
    }
}

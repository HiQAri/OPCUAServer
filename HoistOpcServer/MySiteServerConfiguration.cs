using System.Runtime.Serialization;

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

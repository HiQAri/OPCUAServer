using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OPCUAServer
{
    class MySiteNodeManager : CustomNodeManager2
    {
        private MySiteServerConfiguration mysite_configuration;
        private static OPCUAServerState mysite_OPCUAServer1;
        private System.Threading.Timer simulationTimer;

        public MySiteNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
        base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = OPCUAServer.Namespaces.OPCUAServer;
            namespaceUrls[1] = OPCUAServer.Namespaces.OPCUAServer + "/Instance";
            SetNamespaces(namespaceUrls);
            mysite_configuration = configuration.ParseExtension<MySiteServerConfiguration>();
            if (mysite_configuration == null)
            {
                mysite_configuration = new MySiteServerConfiguration();
            }
        }
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "OPCUAServer.PredefinedNodes.uanodes",
                typeof(MySiteNodeManager).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1, NamespaceIndexes[0]), typeof(BaseObjectState));
                mysite_OPCUAServer1 = new OPCUAServerState(null);
                mysite_OPCUAServer1.Create(SystemContext, passiveNode);
                AddPredefinedNode(SystemContext, mysite_OPCUAServer1);
                //For simulation only
                simulationTimer = new System.Threading.Timer(DoSimulationWork, null, 100, 100);
            }
        }
        public void DoSimulationWork(object state)
        {
            mysite_OPCUAServer1.InputNode.DateTime.Value = "2022-09-12 13:12:10";
        }
    }
}

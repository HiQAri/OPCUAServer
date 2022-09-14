using Opc.Ua;
using Opc.Ua.Server;
using OPCUAServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoistOpcServer
{
    public class AllSignals
    {
        InputState inputNode;

        public AllSignals(StandardServer server)
        {
            FindNodes(server);
        }

        private void FindNodes(StandardServer server)
        {
            MySiteNodeManager manager = server.CurrentInstance.NodeManager.NodeManagers
                .Where(m => m is MySiteNodeManager)
                .FirstOrDefault() as MySiteNodeManager;

            inputNode = (BaseObjectState)manager
                .FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1_InputNode, manager.NamespaceIndexes[0]), typeof(BaseObjectState))
                as InputState;

            //foreach (var m in server.CurrentInstance.NodeManager.NodeManagers)
            //{
            //    if (m is MySiteNodeManager ms)
            //    {
            //        manager = ms;
            //        break;
            //    }
            //}

            //var input = (BaseObjectState)manager.FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1_InputNode, manager.NamespaceIndexes[0]), typeof(BaseObjectState));
            //if (input is InputState s)
            //{
            //    inputNode = s;
            //}
        }

        public double DropB()
        {
            inputNode.MeasuredDropB.Value = new Random().NextDouble() * 100;


            return 0;
        }

    }
}

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

            inputNode.SerialNrIn.Value = "HiQst";
            inputNode.Drop.Value = 25.125;
            inputNode.Width.Value = 42.125;
            inputNode.MeasuredDropA.Value = 0;

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

        #region Input to Hoist

        public string SerialNumber { get => inputNode.SerialNrIn.Value; private set => inputNode.SerialNrIn.Value = value; }

        public double Drop { get => inputNode.Drop.Value ; private set => inputNode.Drop.Value = value; }

        public double Width { get => inputNode.Width.Value; private set => inputNode.Width.Value = value; }

        public double MountOffSetVert { get; private set; }

        public double OffsetLaserOnProd { get; private set; }

        public double ToleranceWidthPlus { get; private set; }

        public double ToleranceDropPlus { get; private set; }

        public double ToleranceWidthMinus { get; private set; }

        public double ToleranceDropMinus { get; private set; }

        public double ToleranceDropDiff { get; private set; }

        public double BottomBarRadius { get; private set; }

        public double PrefMeasDist { get; private set; }

        public double Endcapcompensation { get; private set; }

        public double MeasureDrop { get; private set; }

        public double MeasureWidth { get; private set; }

        public double MeasureSquareness { get; private set; }

        public double HasCords { get; private set; }

        public double MeasureMethod { get; private set; }

        public int StartMeasure { get; set; }

        #endregion

        #region Output from Hoist

        public string DateTime { get => inputNode.DateTime.Value; set => inputNode.DateTime.Value = value; }
        public string SerialNumberOut { get => inputNode.SerialNrOut.Value; set => inputNode.SerialNrOut.Value = value; }

        public double MeasuredDropA { get => inputNode.MeasuredDropA.Value; set => inputNode.MeasuredDropA.Value = value; }
        public double MeasuredDropB { get => inputNode.MeasuredDropB.Value; set => inputNode.MeasuredDropB.Value = value; }
        public double MeasuredDropC { get => inputNode.MeasuredDropC.Value; set => inputNode.MeasuredDropC.Value = value; }

        public double DeltaDrop { get => inputNode.DeltaDrop.Value; set => inputNode.DeltaDrop.Value = value; }
        public double MeasuredWidth { get => inputNode.MeasuredWidth.Value; set => inputNode.MeasuredWidth.Value = value; }

        #endregion

        // IN OR OUT?
        public bool Approved { get => inputNode.Approved.Value; set => inputNode.Approved.Value = value; }
    }
}

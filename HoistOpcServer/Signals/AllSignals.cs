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
            SetInputDefaults();
            SetOutputDefaults();
        }


        private void FindNodes(StandardServer server)
        {
            MySiteNodeManager manager = server.CurrentInstance.NodeManager.NodeManagers
                .Where(m => m is MySiteNodeManager)
                .FirstOrDefault() as MySiteNodeManager;

            inputNode = (BaseObjectState)manager
                .FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1_InputNode, manager.NamespaceIndexes[0]), typeof(BaseObjectState))
                as InputState;
        }

        public void SetInputDefaults()
        {
            SerialNumber = string.Empty;
            Drop = 0;
            Width = 0;
            MountOffSetVert = 0;
            OffsetLaserOnProd = 0;
            ToleranceWidthPlus = 0;
            ToleranceDropPlus = 0;
            ToleranceWidthMinus = 0;
            ToleranceDropMinus = 0;
            ToleranceDropDiff = 0;
            BottomBarRadius = 0;
            PrefMeasDist = 0;
            Endcapcompensation = 0;
            MeasureDrop = 0;
            MeasureWidth = 0;
            MeasureSquareness = 0;
            HasCords = 0;
            MeasureMethod = 0;
            StartMeasure = 0;
            Approved = false;
            Retry = false;
            Reject = false;

#if DEBUG
            SerialNumber = "HiQst";
            Drop = 25.125;
            Width = 42.125;
            MountOffSetVert = 7.533;
            OffsetLaserOnProd = 6.89;
            ToleranceWidthPlus = 0.039;
            ToleranceDropPlus = 0.039;
            ToleranceWidthMinus = 0.394;
            ToleranceDropMinus = 0.118;
            ToleranceDropDiff = 0.079;
            BottomBarRadius = 0.472;
            PrefMeasDist = -0.511811;
            Endcapcompensation = -0.217;
            MeasureDrop = 1;
            MeasureWidth = 1;
            MeasureSquareness = 1;
            HasCords = 1;
            MeasureMethod = 2;
#endif
        }

        public void SetOutputDefaults()
        {
            Date = string.Empty;
            Time = string.Empty;
            SerialNumberOut = string.Empty;
            MeasuredDropA = 0;
            MeasuredDropB = 0;
            MeasuredDropC = 0;
            DeltaDrop = 0;
            MeasuredWidth = 0;
            HoistState = "Idle";
            HoistError = 0;
        }

        #region Input to Hoist

        public string SerialNumber { get => inputNode.SerialNrIn.Value; set => inputNode.SerialNrIn.Value = value; } 

        public double Drop { get => inputNode.Drop.Value ; set => inputNode.Drop.Value = value; }

        public double Width { get => inputNode.Width.Value; set => inputNode.Width.Value = value; }

        public double MountOffSetVert { get => inputNode.MountOffSetVert.Value; set => inputNode.MountOffSetVert.Value = value; }

        public double OffsetLaserOnProd { get => inputNode.OffsetLaserOnProd.Value; set => inputNode.OffsetLaserOnProd.Value = value; }

        public double ToleranceWidthPlus { get => inputNode.ToleranceWidthPlus.Value; set => inputNode.ToleranceWidthPlus.Value = value; }

        public double ToleranceDropPlus { get => inputNode.ToleranceDropPlus.Value; set => inputNode.ToleranceDropPlus.Value = value; }

        public double ToleranceWidthMinus { get => inputNode.ToleranceWidthMinus.Value; set => inputNode.ToleranceWidthMinus.Value = value; }

        public double ToleranceDropMinus { get => inputNode.ToleranceDropMinus.Value; set => inputNode.ToleranceDropMinus.Value = value; }

        public double ToleranceDropDiff { get => inputNode.ToleranceDropDiff.Value; set => inputNode.ToleranceDropDiff.Value = value; }

        public double BottomBarRadius { get => inputNode.BottomBarRadius.Value; set => inputNode.BottomBarRadius.Value = value; }

        public double PrefMeasDist { get => inputNode.PrefMeasDist.Value; set => inputNode.PrefMeasDist.Value = value; }

        public double Endcapcompensation { get => inputNode.Endcapcompensation.Value; set => inputNode.Endcapcompensation.Value = value; }

        public int MeasureDrop { get => inputNode.MeasureDrop.Value; set => inputNode.MeasureDrop.Value = value; }

        public int MeasureWidth { get => inputNode.MeasureWidth.Value; set => inputNode.MeasureWidth.Value = value; }

        public int MeasureSquareness { get => inputNode.MeasureSquareness.Value; set => inputNode.MeasureSquareness.Value = value; }

        public int HasCords { get => inputNode.HasCords.Value; set => inputNode.HasCords.Value = value; }

        public int MeasureMethod { get => inputNode.MeasureMethod.Value; set => inputNode.MeasureMethod.Value = value; }

        public int StartMeasure { get => inputNode.StartMeasure.Value; set => inputNode.StartMeasure.Value = value; }

        public bool Approved { get => inputNode.Approved.Value; set => inputNode.Approved.Value = value; }

        public bool Retry { get => inputNode.Retry.Value; set => inputNode.Retry.Value = value; }

        public bool Reject { get => inputNode.Rejected.Value; set => inputNode.Rejected.Value = value; }

        #endregion

        #region Output from Hoist

        public string Date { get => inputNode.Date.Value; set => inputNode.Date.Value = value; }

        public string Time { get => inputNode.Time.Value; set => inputNode.Time.Value = value; }

        public string SerialNumberOut { get => inputNode.SerialNrOut.Value; set => inputNode.SerialNrOut.Value = value; }

        public double MeasuredDropA { get => inputNode.MeasuredDropA.Value; set => inputNode.MeasuredDropA.Value = value; }

        public double MeasuredDropB { get => inputNode.MeasuredDropB.Value; set => inputNode.MeasuredDropB.Value = value; }

        public double MeasuredDropC { get => inputNode.MeasuredDropC.Value; set => inputNode.MeasuredDropC.Value = value; }

        public double DeltaDrop { get => inputNode.DeltaDrop.Value; set => inputNode.DeltaDrop.Value = value; }

        public double MeasuredWidth { get => inputNode.MeasuredWidth.Value; set => inputNode.MeasuredWidth.Value = value; }

        public string HoistState { get => inputNode.HoistState.Value; set => inputNode.HoistState.Value = value; }

        public int HoistError { get => inputNode.HoistError.Value; set => inputNode.HoistError.Value = value; }


        #endregion

    }
}

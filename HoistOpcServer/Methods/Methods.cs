using Opc.Ua;
using Opc.Ua.Server;
using OPCUAServer;
using System.Collections.Generic;
using System.Linq;

namespace HoistOpcServer
{
    public class Methods
    {
        public event OpcEventHandler HomingRequest;

        private const uint HOMINGREQUEST = 1;

        private object m_processLock = new object();
        private object Lock = new object();
        private MethodState method;
        PropertyState<uint> stateNode;
        ISystemContext context;

        public Methods(StandardServer server)
        {
            FindMethod(server);
        }

        private void FindMethod(StandardServer server)
        {
            MySiteNodeManager manager = server.CurrentInstance.NodeManager.NodeManagers
                .Where(m => m is MySiteNodeManager)
                .FirstOrDefault() as MySiteNodeManager;

            InputState inputNode = (BaseObjectState)manager
                .FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1_InputNode, manager.NamespaceIndexes[0]), typeof(BaseObjectState))
                as InputState;

            context = manager.SystemContext;
            stateNode = inputNode.FindChild(context, new QualifiedName("State", 2)) as PropertyState<uint>;
            method = inputNode.FindMethod(context, new NodeId(3, 2));
            method.OnCallMethod = new GenericMethodCalledEventHandler(OnStart);
        }


        private ServiceResult OnStart(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            // all arguments must be provided.
            if (inputArguments.Count < 2)
            {
                return StatusCodes.BadArgumentsMissing;
            }

            // check the data type of the input arguments.
            uint? methodSelection = inputArguments[0] as uint?;
            uint? methodArgument = inputArguments[1] as uint?;

            if (methodSelection == null)
            {
                return StatusCodes.BadTypeMismatch;
            }

            lock (m_processLock)
            {
                switch (methodSelection)
                {
                    case HOMINGREQUEST:
                        HomingRequest?.Invoke(this, new OpcEventArgs(methodArgument));
                        break;
                    default:
                        break;
                }
            }

            // signal update to state node.
            lock (Lock)
            {
                stateNode.Value = 0;
                stateNode.ClearChangeMasks(context, true);
            }

            return ServiceResult.Good;
        }
    }
}

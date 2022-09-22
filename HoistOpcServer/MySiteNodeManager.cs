using Opc.Ua;
using Opc.Ua.Server;
using System.Collections.Generic;
using System.Reflection;

namespace OPCUAServer
{
    /// <summary> NodeManager to handle the different nodes in the server </summary>
    class MySiteNodeManager : CustomNodeManager2
    {
        private MySiteServerConfiguration mysite_configuration;
        private static OPCUAServerState mysite_OPCUAServer1;
        private PropertyState<uint> m_stateNode;

        public MySiteNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            : base(server, configuration)
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

                BaseObjectState stationNode = (BaseObjectState)FindPredefinedNode(new NodeId(Objects.OPCUAServer1_InputNode, NamespaceIndexes[0]), typeof(BaseObjectState));

                // a property to report the process state.
                PropertyState<uint> state = m_stateNode = new PropertyState<uint>(null);
                state.Create(
                    SystemContext,
                    new NodeId(2, NamespaceIndex), // TODO:: Need to lookup an id that is free
                    new QualifiedName("State", NamespaceIndex),
                    null,
                    true);
                state.TypeDefinitionId = VariableTypeIds.PropertyType;
                state.ReferenceTypeId = ReferenceTypeIds.HasProperty;
                state.DataType = DataTypeIds.UInt32;
                state.ValueRank = ValueRanks.Scalar;

                AddPredefinedNode(SystemContext, state);
                stationNode.AddChild(state);

                // a method to start the process.
                MethodState start = new MethodState(stationNode);

                start.NodeId = new NodeId(3, NamespaceIndex);
                start.BrowseName = new QualifiedName("Start", NamespaceIndex);
                start.DisplayName = start.BrowseName.Name;
                start.ReferenceTypeId = ReferenceTypeIds.HasComponent;
                start.UserExecutable = true;
                start.Executable = true;


                // add input arguments.
                start.InputArguments = new PropertyState<Argument[]>(start);
                start.InputArguments.NodeId = new NodeId(4, NamespaceIndex);
                start.InputArguments.BrowseName = "InputArguments"; 
                start.InputArguments.DisplayName = start.InputArguments.BrowseName.Name;
                start.InputArguments.TypeDefinitionId = VariableTypeIds.PropertyType;
                start.InputArguments.ReferenceTypeId = ReferenceTypeIds.HasProperty;
                start.InputArguments.DataType = DataTypeIds.Argument;
                start.InputArguments.ValueRank = ValueRanks.OneDimension;

                Argument[] args = new Argument[2];
                args[0] = new Argument();
                args[0].Name = "Method Selection";
                args[0].Description = "Index of the method that should be called";
                args[0].DataType = DataTypeIds.UInt32;
                args[0].ValueRank = ValueRanks.Scalar;

                args[1] = new Argument();
                args[1].Name = "Method argument";
                args[1].Description = "Incoming argument for the method";
                args[1].DataType = DataTypeIds.UInt32;
                args[1].ValueRank = ValueRanks.Scalar;

                start.InputArguments.Value = args;

                // add output arguments.
                //start.OutputArguments = new PropertyState<Argument[]>(start);
                //start.OutputArguments.NodeId = new NodeId(5, NamespaceIndex);
                //start.OutputArguments.BrowseName = "OutputArguments"; 
                //start.OutputArguments.DisplayName = start.OutputArguments.BrowseName.Name;
                //start.OutputArguments.TypeDefinitionId = VariableTypeIds.PropertyType;
                //start.OutputArguments.ReferenceTypeId = ReferenceTypeIds.HasProperty;
                //start.OutputArguments.DataType = DataTypeIds.Argument;
                //start.OutputArguments.ValueRank = ValueRanks.OneDimension;

                //args = new Argument[2];
                //args[0] = new Argument();
                //args[0].Name = "Revised Initial State";
                //args[0].Description = "The revised initialize state for the process.";
                //args[0].DataType = DataTypeIds.UInt32;
                //args[0].ValueRank = ValueRanks.Scalar;

                //args[1] = new Argument();
                //args[1].Name = "Revised Final State";
                //args[1].Description = "The revised final state for the process.";
                //args[1].DataType = DataTypeIds.UInt32;
                //args[1].ValueRank = ValueRanks.Scalar;

                //start.OutputArguments.Value = args;

                stationNode.AddChild(start);
                AddPredefinedNode(SystemContext, start);
            }
        }
    }
}

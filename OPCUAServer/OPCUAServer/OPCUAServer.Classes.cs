/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OPCUAServer
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode Object.
        /// </summary>
        public const uint OPCUAServerType_InputNode = 15070;

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public const uint OPCUAServer1 = 15089;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode Object.
        /// </summary>
        public const uint OPCUAServer1_InputNode = 15090;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the Input ObjectType.
        /// </summary>
        public const uint Input = 15001;

        /// <summary>
        /// The identifier for the Output ObjectType.
        /// </summary>
        public const uint Output = 15020;

        /// <summary>
        /// The identifier for the OPCUAServerType ObjectType.
        /// </summary>
        public const uint OPCUAServerType = 15069;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the Input_SerialNrIn Variable.
        /// </summary>
        public const uint Input_SerialNrIn = 15002;

        /// <summary>
        /// The identifier for the Input_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint Input_SerialNrIn_EURange = 15006;

        /// <summary>
        /// The identifier for the Input_Drop Variable.
        /// </summary>
        public const uint Input_Drop = 15008;

        /// <summary>
        /// The identifier for the Input_Drop_EURange Variable.
        /// </summary>
        public const uint Input_Drop_EURange = 15012;

        /// <summary>
        /// The identifier for the Input_Width Variable.
        /// </summary>
        public const uint Input_Width = 15014;

        /// <summary>
        /// The identifier for the Input_Width_EURange Variable.
        /// </summary>
        public const uint Input_Width_EURange = 15018;

        /// <summary>
        /// The identifier for the Output_DateTime Variable.
        /// </summary>
        public const uint Output_DateTime = 15021;

        /// <summary>
        /// The identifier for the Output_DateTime_EURange Variable.
        /// </summary>
        public const uint Output_DateTime_EURange = 15025;

        /// <summary>
        /// The identifier for the Output_SerialNrOut Variable.
        /// </summary>
        public const uint Output_SerialNrOut = 15027;

        /// <summary>
        /// The identifier for the Output_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint Output_SerialNrOut_EURange = 15031;

        /// <summary>
        /// The identifier for the Output_MeasuredDropA Variable.
        /// </summary>
        public const uint Output_MeasuredDropA = 15033;

        /// <summary>
        /// The identifier for the Output_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint Output_MeasuredDropA_EURange = 15037;

        /// <summary>
        /// The identifier for the Output_MeasuredDropB Variable.
        /// </summary>
        public const uint Output_MeasuredDropB = 15039;

        /// <summary>
        /// The identifier for the Output_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint Output_MeasuredDropB_EURange = 15043;

        /// <summary>
        /// The identifier for the Output_MeasuredDropC Variable.
        /// </summary>
        public const uint Output_MeasuredDropC = 15045;

        /// <summary>
        /// The identifier for the Output_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint Output_MeasuredDropC_EURange = 15049;

        /// <summary>
        /// The identifier for the Output_DeltaDrop Variable.
        /// </summary>
        public const uint Output_DeltaDrop = 15051;

        /// <summary>
        /// The identifier for the Output_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint Output_DeltaDrop_EURange = 15055;

        /// <summary>
        /// The identifier for the Output_MeasuredWidth Variable.
        /// </summary>
        public const uint Output_MeasuredWidth = 15057;

        /// <summary>
        /// The identifier for the Output_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint Output_MeasuredWidth_EURange = 15061;

        /// <summary>
        /// The identifier for the Output_Approved Variable.
        /// </summary>
        public const uint Output_Approved = 15063;

        /// <summary>
        /// The identifier for the Output_Approved_EURange Variable.
        /// </summary>
        public const uint Output_Approved_EURange = 15067;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn = 15071;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn_EURange = 15075;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop = 15077;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop_EURange = 15081;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width = 15083;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width_EURange = 15087;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn = 15091;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn_EURange = 15095;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop = 15097;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop_EURange = 15101;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width = 15103;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width_EURange = 15107;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_InputNode, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_InputNode, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the Input ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Input = new ExpandedNodeId(OPCUAServer.ObjectTypes.Input, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Output = new ExpandedNodeId(OPCUAServer.ObjectTypes.Output, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType = new ExpandedNodeId(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the Input_SerialNrIn Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_SerialNrIn = new ExpandedNodeId(OPCUAServer.Variables.Input_SerialNrIn, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_SerialNrIn_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_SerialNrIn_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_SerialNrIn_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Drop Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Drop = new ExpandedNodeId(OPCUAServer.Variables.Input_Drop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Drop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Drop_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_Drop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Width Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Width = new ExpandedNodeId(OPCUAServer.Variables.Input_Width, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Width_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Width_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_Width_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_DateTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_DateTime = new ExpandedNodeId(OPCUAServer.Variables.Output_DateTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_DateTime_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_DateTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_DateTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_SerialNrOut Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_SerialNrOut = new ExpandedNodeId(OPCUAServer.Variables.Output_SerialNrOut, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_SerialNrOut_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_SerialNrOut_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_SerialNrOut_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropA Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropA = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropA, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropA_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropA_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropA_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropB Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropB = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropB, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropB_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropB_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropB_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropC Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropC = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropC, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredDropC_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredDropC_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredDropC_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_DeltaDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_DeltaDrop = new ExpandedNodeId(OPCUAServer.Variables.Output_DeltaDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_DeltaDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_DeltaDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_DeltaDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredWidth = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_MeasuredWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_MeasuredWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_MeasuredWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_Approved Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_Approved = new ExpandedNodeId(OPCUAServer.Variables.Output_Approved, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Output_Approved_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Output_Approved_EURange = new ExpandedNodeId(OPCUAServer.Variables.Output_Approved_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_SerialNrIn = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_SerialNrIn, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_SerialNrIn_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_SerialNrIn_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Drop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Drop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Drop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Drop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Width = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Width, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Width_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Width_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_SerialNrIn = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_SerialNrIn, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_SerialNrIn_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_SerialNrIn_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Drop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Drop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Drop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Drop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Width = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Width, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Width_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Width_EURange, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Approved component.
        /// </summary>
        public const string Approved = "Approved";

        /// <summary>
        /// The BrowseName for the DateTime component.
        /// </summary>
        public const string DateTime = "DateTime";

        /// <summary>
        /// The BrowseName for the DeltaDrop component.
        /// </summary>
        public const string DeltaDrop = "DeltaDrop";

        /// <summary>
        /// The BrowseName for the Drop component.
        /// </summary>
        public const string Drop = "Drop";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the InputNode component.
        /// </summary>
        public const string InputNode = "InputInfo";

        /// <summary>
        /// The BrowseName for the MeasuredDropA component.
        /// </summary>
        public const string MeasuredDropA = "MeasuredDropA";

        /// <summary>
        /// The BrowseName for the MeasuredDropB component.
        /// </summary>
        public const string MeasuredDropB = "MeasuredDropB";

        /// <summary>
        /// The BrowseName for the MeasuredDropC component.
        /// </summary>
        public const string MeasuredDropC = "MeasuredDropC";

        /// <summary>
        /// The BrowseName for the MeasuredWidth component.
        /// </summary>
        public const string MeasuredWidth = "MeasuredWidth";

        /// <summary>
        /// The BrowseName for the OPCUAServer1 component.
        /// </summary>
        public const string OPCUAServer1 = "Line";

        /// <summary>
        /// The BrowseName for the OPCUAServerType component.
        /// </summary>
        public const string OPCUAServerType = "OPCUAServerType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the SerialNrIn component.
        /// </summary>
        public const string SerialNrIn = "SerialNrIn";

        /// <summary>
        /// The BrowseName for the SerialNrOut component.
        /// </summary>
        public const string SerialNrOut = "SerialNrOut";

        /// <summary>
        /// The BrowseName for the Width component.
        /// </summary>
        public const string Width = "Width";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OPCUAServer namespace (.NET code namespace is 'OPCUAServer').
        /// </summary>
        public const string OPCUAServer = "http://opcfoundation.org/OPCUAServer";
    }
    #endregion

    #region InputState Class
    #if (!OPCUA_EXCLUDE_InputState)
    /// <summary>
    /// Stores an instance of the Input ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.Input, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAAEAAAABAA0A" +
           "AABJbnB1dEluc3RhbmNlAQGZOgEBmTr/////AwAAABVgiQoCAAAAAQAKAAAAU2VyaWFsTnJJbgEBmjoA" +
           "LwEAQAmaOgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBnjoALgBEnjoAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEBoDoALwEAQAmgOgAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpDoALgBEpDoAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAFAAAAV2lkdGgBAaY6AC8BAEAJpjoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAao6AC4ARKo6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SerialNrIn Variable.
        /// </summary>
        public AnalogItemState<string> SerialNrIn
        {
            get
            {
                return m_serialNrIn;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNrIn, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNrIn = value;
            }
        }

        /// <summary>
        /// A description for the Drop Variable.
        /// </summary>
        public AnalogItemState<double> Drop
        {
            get
            {
                return m_drop;
            }

            set
            {
                if (!Object.ReferenceEquals(m_drop, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_drop = value;
            }
        }

        /// <summary>
        /// A description for the Width Variable.
        /// </summary>
        public AnalogItemState<double> Width
        {
            get
            {
                return m_width;
            }

            set
            {
                if (!Object.ReferenceEquals(m_width, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_width = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_serialNrIn != null)
            {
                children.Add(m_serialNrIn);
            }

            if (m_drop != null)
            {
                children.Add(m_drop);
            }

            if (m_width != null)
            {
                children.Add(m_width);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.SerialNrIn:
                {
                    if (createOrReplace)
                    {
                        if (SerialNrIn == null)
                        {
                            if (replacement == null)
                            {
                                SerialNrIn = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                SerialNrIn = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNrIn;
                    break;
                }

                case OPCUAServer.BrowseNames.Drop:
                {
                    if (createOrReplace)
                    {
                        if (Drop == null)
                        {
                            if (replacement == null)
                            {
                                Drop = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Drop = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Drop;
                    break;
                }

                case OPCUAServer.BrowseNames.Width:
                {
                    if (createOrReplace)
                    {
                        if (Width == null)
                        {
                            if (replacement == null)
                            {
                                Width = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Width = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Width;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<string> m_serialNrIn;
        private AnalogItemState<double> m_drop;
        private AnalogItemState<double> m_width;
        #endregion
    }
    #endif
    #endregion

    #region OutputState Class
    #if (!OPCUA_EXCLUDE_OutputState)
    /// <summary>
    /// Stores an instance of the Output ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OutputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OutputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.Output, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAAEAAAABAA4A" +
           "AABPdXRwdXRJbnN0YW5jZQEBrDoBAaw6/////wgAAAAVYIkKAgAAAAEACAAAAERhdGVUaW1lAQGtOgAv" +
           "AQBACa06AAAADP////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGxOgAuAESxOgAAAQB0" +
           "A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABTZXJpYWxOck91dAEBszoALwEAQAmzOgAAAAz/////" +
           "AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtzoALgBEtzoAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQQEBuToALwEAQAm5OgAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBvToALgBEvToAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAN" +
           "AAAATWVhc3VyZWREcm9wQgEBvzoALwEAQAm/OgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBwzoALgBEwzoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZWRE" +
           "cm9wQwEBxToALwEAQAnFOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEByToA" +
           "LgBEyToAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAJAAAARGVsdGFEcm9wAQHLOgAvAQBACcs6" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHPOgAuAETPOgAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZFdpZHRoAQHROgAvAQBACdE6AAAAC/////8DA///" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHVOgAuAETVOgAAAQB0A/////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAgAAABBcHByb3ZlZAEB1zoALwEAQAnXOgAAAAH/////AwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEB2zoALgBE2zoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the DateTime Variable.
        /// </summary>
        public AnalogItemState<string> DateTime
        {
            get
            {
                return m_dateTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dateTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dateTime = value;
            }
        }

        /// <summary>
        /// A description for the SerialNrOut Variable.
        /// </summary>
        public AnalogItemState<string> SerialNrOut
        {
            get
            {
                return m_serialNrOut;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNrOut, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNrOut = value;
            }
        }

        /// <summary>
        /// A description for the MeasuredDropA Variable.
        /// </summary>
        public AnalogItemState<double> MeasuredDropA
        {
            get
            {
                return m_measuredDropA;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measuredDropA, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measuredDropA = value;
            }
        }

        /// <summary>
        /// A description for the MeasuredDropB Variable.
        /// </summary>
        public AnalogItemState<double> MeasuredDropB
        {
            get
            {
                return m_measuredDropB;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measuredDropB, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measuredDropB = value;
            }
        }

        /// <summary>
        /// A description for the MeasuredDropC Variable.
        /// </summary>
        public AnalogItemState<double> MeasuredDropC
        {
            get
            {
                return m_measuredDropC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measuredDropC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measuredDropC = value;
            }
        }

        /// <summary>
        /// A description for the DeltaDrop Variable.
        /// </summary>
        public AnalogItemState<double> DeltaDrop
        {
            get
            {
                return m_deltaDrop;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deltaDrop, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deltaDrop = value;
            }
        }

        /// <summary>
        /// A description for the MeasuredWidth Variable.
        /// </summary>
        public AnalogItemState<double> MeasuredWidth
        {
            get
            {
                return m_measuredWidth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measuredWidth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measuredWidth = value;
            }
        }

        /// <summary>
        /// A description for the Approved Variable.
        /// </summary>
        public AnalogItemState<bool> Approved
        {
            get
            {
                return m_approved;
            }

            set
            {
                if (!Object.ReferenceEquals(m_approved, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_approved = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_dateTime != null)
            {
                children.Add(m_dateTime);
            }

            if (m_serialNrOut != null)
            {
                children.Add(m_serialNrOut);
            }

            if (m_measuredDropA != null)
            {
                children.Add(m_measuredDropA);
            }

            if (m_measuredDropB != null)
            {
                children.Add(m_measuredDropB);
            }

            if (m_measuredDropC != null)
            {
                children.Add(m_measuredDropC);
            }

            if (m_deltaDrop != null)
            {
                children.Add(m_deltaDrop);
            }

            if (m_measuredWidth != null)
            {
                children.Add(m_measuredWidth);
            }

            if (m_approved != null)
            {
                children.Add(m_approved);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.DateTime:
                {
                    if (createOrReplace)
                    {
                        if (DateTime == null)
                        {
                            if (replacement == null)
                            {
                                DateTime = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                DateTime = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = DateTime;
                    break;
                }

                case OPCUAServer.BrowseNames.SerialNrOut:
                {
                    if (createOrReplace)
                    {
                        if (SerialNrOut == null)
                        {
                            if (replacement == null)
                            {
                                SerialNrOut = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                SerialNrOut = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNrOut;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasuredDropA:
                {
                    if (createOrReplace)
                    {
                        if (MeasuredDropA == null)
                        {
                            if (replacement == null)
                            {
                                MeasuredDropA = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasuredDropA = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasuredDropA;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasuredDropB:
                {
                    if (createOrReplace)
                    {
                        if (MeasuredDropB == null)
                        {
                            if (replacement == null)
                            {
                                MeasuredDropB = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasuredDropB = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasuredDropB;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasuredDropC:
                {
                    if (createOrReplace)
                    {
                        if (MeasuredDropC == null)
                        {
                            if (replacement == null)
                            {
                                MeasuredDropC = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasuredDropC = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasuredDropC;
                    break;
                }

                case OPCUAServer.BrowseNames.DeltaDrop:
                {
                    if (createOrReplace)
                    {
                        if (DeltaDrop == null)
                        {
                            if (replacement == null)
                            {
                                DeltaDrop = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                DeltaDrop = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = DeltaDrop;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasuredWidth:
                {
                    if (createOrReplace)
                    {
                        if (MeasuredWidth == null)
                        {
                            if (replacement == null)
                            {
                                MeasuredWidth = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasuredWidth = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasuredWidth;
                    break;
                }

                case OPCUAServer.BrowseNames.Approved:
                {
                    if (createOrReplace)
                    {
                        if (Approved == null)
                        {
                            if (replacement == null)
                            {
                                Approved = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Approved = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Approved;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<string> m_dateTime;
        private AnalogItemState<string> m_serialNrOut;
        private AnalogItemState<double> m_measuredDropA;
        private AnalogItemState<double> m_measuredDropB;
        private AnalogItemState<double> m_measuredDropC;
        private AnalogItemState<double> m_deltaDrop;
        private AnalogItemState<double> m_measuredWidth;
        private AnalogItemState<bool> m_approved;
        #endregion
    }
    #endif
    #endregion

    #region OPCUAServerState Class
    #if (!OPCUA_EXCLUDE_OPCUAServerState)
    /// <summary>
    /// Stores an instance of the OPCUAServerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPCUAServerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPCUAServerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////hGCAAAEAAAABABcA" +
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEB3ToBAd06Af////8BAAAAhGDACgEAAAAJAAAASW5wdXRO" +
           "b2RlAQAJAAAASW5wdXRJbmZvAQHeOgAvAQGZOt46AAAB/////wMAAAAVYIkKAgAAAAEACgAAAFNlcmlh" +
           "bE5ySW4BAd86AC8BAEAJ3zoAAAAM/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeM6" +
           "AC4AROM6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAERyb3ABAeU6AC8BAEAJ5ToAAAAL" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAek6AC4AROk6AAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEABQAAAFdpZHRoAQHrOgAvAQBACes6AAAAC/////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQHvOgAuAETvOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the InputInfo Object.
        /// </summary>
        public InputState InputNode
        {
            get
            {
                return m_inputNode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inputNode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inputNode = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_inputNode != null)
            {
                children.Add(m_inputNode);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.InputNode:
                {
                    if (createOrReplace)
                    {
                        if (InputNode == null)
                        {
                            if (replacement == null)
                            {
                                InputNode = new InputState(this);
                            }
                            else
                            {
                                InputNode = (InputState)replacement;
                            }
                        }
                    }

                    instance = InputNode;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private InputState m_inputNode;
        #endregion
    }
    #endif
    #endregion
}
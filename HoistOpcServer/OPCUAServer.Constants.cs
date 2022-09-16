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
using System.Reflection;
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
        public const uint OPCUAServerType_InputNode = 15069;

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public const uint OPCUAServer1 = 15136;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode Object.
        /// </summary>
        public const uint OPCUAServer1_InputNode = 15137;
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
        /// The identifier for the OPCUAServerType ObjectType.
        /// </summary>
        public const uint OPCUAServerType = 15068;
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
        /// The identifier for the Input_DateTime Variable.
        /// </summary>
        public const uint Input_DateTime = 15020;

        /// <summary>
        /// The identifier for the Input_DateTime_EURange Variable.
        /// </summary>
        public const uint Input_DateTime_EURange = 15024;

        /// <summary>
        /// The identifier for the Input_SerialNrOut Variable.
        /// </summary>
        public const uint Input_SerialNrOut = 15026;

        /// <summary>
        /// The identifier for the Input_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint Input_SerialNrOut_EURange = 15030;

        /// <summary>
        /// The identifier for the Input_MeasuredDropA Variable.
        /// </summary>
        public const uint Input_MeasuredDropA = 15032;

        /// <summary>
        /// The identifier for the Input_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint Input_MeasuredDropA_EURange = 15036;

        /// <summary>
        /// The identifier for the Input_MeasuredDropB Variable.
        /// </summary>
        public const uint Input_MeasuredDropB = 15038;

        /// <summary>
        /// The identifier for the Input_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint Input_MeasuredDropB_EURange = 15042;

        /// <summary>
        /// The identifier for the Input_MeasuredDropC Variable.
        /// </summary>
        public const uint Input_MeasuredDropC = 15044;

        /// <summary>
        /// The identifier for the Input_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint Input_MeasuredDropC_EURange = 15048;

        /// <summary>
        /// The identifier for the Input_DeltaDrop Variable.
        /// </summary>
        public const uint Input_DeltaDrop = 15050;

        /// <summary>
        /// The identifier for the Input_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint Input_DeltaDrop_EURange = 15054;

        /// <summary>
        /// The identifier for the Input_MeasuredWidth Variable.
        /// </summary>
        public const uint Input_MeasuredWidth = 15056;

        /// <summary>
        /// The identifier for the Input_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint Input_MeasuredWidth_EURange = 15060;

        /// <summary>
        /// The identifier for the Input_Approved Variable.
        /// </summary>
        public const uint Input_Approved = 15062;

        /// <summary>
        /// The identifier for the Input_Approved_EURange Variable.
        /// </summary>
        public const uint Input_Approved_EURange = 15066;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn = 15070;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn_EURange = 15074;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop = 15076;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop_EURange = 15080;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width = 15082;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width_EURange = 15086;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DateTime = 15088;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DateTime_EURange = 15092;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrOut = 15094;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrOut_EURange = 15098;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropA = 15100;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropA_EURange = 15104;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropB = 15106;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropB_EURange = 15110;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropC = 15112;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropC_EURange = 15116;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DeltaDrop = 15118;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DeltaDrop_EURange = 15122;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredWidth = 15124;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredWidth_EURange = 15128;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Approved = 15130;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Approved_EURange = 15134;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn = 15138;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn_EURange = 15142;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop = 15144;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop_EURange = 15148;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width = 15150;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width_EURange = 15154;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DateTime = 15156;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DateTime_EURange = 15160;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrOut = 15162;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrOut_EURange = 15166;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropA = 15168;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropA_EURange = 15172;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropB = 15174;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropB_EURange = 15178;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropC = 15180;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropC_EURange = 15184;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DeltaDrop = 15186;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DeltaDrop_EURange = 15190;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredWidth = 15192;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredWidth_EURange = 15196;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Approved = 15198;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Approved_EURange = 15202;
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
        /// The identifier for the Input_DateTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_DateTime = new ExpandedNodeId(OPCUAServer.Variables.Input_DateTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_DateTime_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_DateTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_DateTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_SerialNrOut Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_SerialNrOut = new ExpandedNodeId(OPCUAServer.Variables.Input_SerialNrOut, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_SerialNrOut_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_SerialNrOut_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_SerialNrOut_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropA Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropA = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropA, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropA_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropA_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropA_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropB Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropB = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropB, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropB_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropB_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropB_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropC Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropC = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropC, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredDropC_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredDropC_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredDropC_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_DeltaDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_DeltaDrop = new ExpandedNodeId(OPCUAServer.Variables.Input_DeltaDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_DeltaDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_DeltaDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_DeltaDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredWidth = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasuredWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasuredWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasuredWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Approved Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Approved = new ExpandedNodeId(OPCUAServer.Variables.Input_Approved, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Approved_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Approved_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_Approved_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the OPCUAServerType_InputNode_DateTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_DateTime = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_DateTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_DateTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_DateTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_SerialNrOut = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_SerialNrOut, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_SerialNrOut_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_SerialNrOut_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropA = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropA, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropA_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropA_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropB = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropB, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropB_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropB_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropC = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropC, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredDropC_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredDropC_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_DeltaDrop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_DeltaDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_DeltaDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_DeltaDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredWidth = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasuredWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasuredWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Approved = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Approved, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Approved_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Approved_EURange, OPCUAServer.Namespaces.OPCUAServer);

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

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_DateTime = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_DateTime, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_DateTime_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_DateTime_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_SerialNrOut = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_SerialNrOut, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_SerialNrOut_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_SerialNrOut_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropA = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropA, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropA_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropA_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropB = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropB, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropB_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropB_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropC = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropC, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredDropC_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredDropC_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_DeltaDrop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_DeltaDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_DeltaDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_DeltaDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredWidth = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasuredWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasuredWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Approved = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Approved, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Approved_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Approved_EURange, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
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
        public const string InputNode = "My tags.";

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
        public const string OPCUAServer1 = "MySite";

        /// <summary>
        /// The BrowseName for the OPCUAServerType component.
        /// </summary>
        public const string OPCUAServerType = "OPCUAServerType";

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
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
}
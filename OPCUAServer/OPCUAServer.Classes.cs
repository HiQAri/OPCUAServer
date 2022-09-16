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
        public const uint OPCUAServerType_InputNode = 15165;

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public const uint OPCUAServer1 = 15328;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode Object.
        /// </summary>
        public const uint OPCUAServer1_InputNode = 15329;
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
        public const uint OPCUAServerType = 15164;
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
        /// The identifier for the Input_MountOffSetVert Variable.
        /// </summary>
        public const uint Input_MountOffSetVert = 15068;

        /// <summary>
        /// The identifier for the Input_MountOffSetVert_EURange Variable.
        /// </summary>
        public const uint Input_MountOffSetVert_EURange = 15072;

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd Variable.
        /// </summary>
        public const uint Input_OffsetLaserOnProd = 15074;

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public const uint Input_OffsetLaserOnProd_EURange = 15078;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus Variable.
        /// </summary>
        public const uint Input_ToleranceWidthPlus = 15080;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceWidthPlus_EURange = 15084;

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus Variable.
        /// </summary>
        public const uint Input_ToleranceDropPlus = 15086;

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropPlus_EURange = 15090;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus Variable.
        /// </summary>
        public const uint Input_ToleranceWidthMinus = 15092;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceWidthMinus_EURange = 15096;

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus Variable.
        /// </summary>
        public const uint Input_ToleranceDropMinus = 15098;

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropMinus_EURange = 15102;

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff Variable.
        /// </summary>
        public const uint Input_ToleranceDropDiff = 15104;

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropDiff_EURange = 15108;

        /// <summary>
        /// The identifier for the Input_BottomBarRadius Variable.
        /// </summary>
        public const uint Input_BottomBarRadius = 15110;

        /// <summary>
        /// The identifier for the Input_BottomBarRadius_EURange Variable.
        /// </summary>
        public const uint Input_BottomBarRadius_EURange = 15114;

        /// <summary>
        /// The identifier for the Input_PrefMeasDist Variable.
        /// </summary>
        public const uint Input_PrefMeasDist = 15116;

        /// <summary>
        /// The identifier for the Input_PrefMeasDist_EURange Variable.
        /// </summary>
        public const uint Input_PrefMeasDist_EURange = 15120;

        /// <summary>
        /// The identifier for the Input_Endcapcompensation Variable.
        /// </summary>
        public const uint Input_Endcapcompensation = 15122;

        /// <summary>
        /// The identifier for the Input_Endcapcompensation_EURange Variable.
        /// </summary>
        public const uint Input_Endcapcompensation_EURange = 15126;

        /// <summary>
        /// The identifier for the Input_MeasureDrop Variable.
        /// </summary>
        public const uint Input_MeasureDrop = 15128;

        /// <summary>
        /// The identifier for the Input_MeasureDrop_EURange Variable.
        /// </summary>
        public const uint Input_MeasureDrop_EURange = 15132;

        /// <summary>
        /// The identifier for the Input_MeasureWidth Variable.
        /// </summary>
        public const uint Input_MeasureWidth = 15134;

        /// <summary>
        /// The identifier for the Input_MeasureWidth_EURange Variable.
        /// </summary>
        public const uint Input_MeasureWidth_EURange = 15138;

        /// <summary>
        /// The identifier for the Input_MeasureSquareness Variable.
        /// </summary>
        public const uint Input_MeasureSquareness = 15140;

        /// <summary>
        /// The identifier for the Input_MeasureSquareness_EURange Variable.
        /// </summary>
        public const uint Input_MeasureSquareness_EURange = 15144;

        /// <summary>
        /// The identifier for the Input_HasCords Variable.
        /// </summary>
        public const uint Input_HasCords = 15146;

        /// <summary>
        /// The identifier for the Input_HasCords_EURange Variable.
        /// </summary>
        public const uint Input_HasCords_EURange = 15150;

        /// <summary>
        /// The identifier for the Input_MeasureMethod Variable.
        /// </summary>
        public const uint Input_MeasureMethod = 15152;

        /// <summary>
        /// The identifier for the Input_MeasureMethod_EURange Variable.
        /// </summary>
        public const uint Input_MeasureMethod_EURange = 15156;

        /// <summary>
        /// The identifier for the Input_StartMeasure Variable.
        /// </summary>
        public const uint Input_StartMeasure = 15158;

        /// <summary>
        /// The identifier for the Input_StartMeasure_EURange Variable.
        /// </summary>
        public const uint Input_StartMeasure_EURange = 15162;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn = 15166;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrIn_EURange = 15170;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop = 15172;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Drop_EURange = 15176;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width = 15178;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Width_EURange = 15182;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DateTime = 15184;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DateTime_EURange = 15188;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrOut = 15190;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_SerialNrOut_EURange = 15194;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropA = 15196;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropA_EURange = 15200;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropB = 15202;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropB_EURange = 15206;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropC = 15208;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredDropC_EURange = 15212;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DeltaDrop = 15214;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DeltaDrop_EURange = 15218;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredWidth = 15220;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasuredWidth_EURange = 15224;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Approved = 15226;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Approved_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Approved_EURange = 15230;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MountOffSetVert = 15232;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MountOffSetVert_EURange = 15236;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_OffsetLaserOnProd = 15238;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_OffsetLaserOnProd_EURange = 15242;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthPlus = 15244;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthPlus_EURange = 15248;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropPlus = 15250;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropPlus_EURange = 15254;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthMinus = 15256;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthMinus_EURange = 15260;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropMinus = 15262;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropMinus_EURange = 15266;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropDiff = 15268;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropDiff_EURange = 15272;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_BottomBarRadius = 15274;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_BottomBarRadius_EURange = 15278;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_PrefMeasDist = 15280;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_PrefMeasDist_EURange = 15284;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Endcapcompensation = 15286;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Endcapcompensation_EURange = 15290;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureDrop = 15292;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureDrop_EURange = 15296;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureWidth = 15298;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureWidth_EURange = 15302;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureSquareness = 15304;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureSquareness_EURange = 15308;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HasCords = 15310;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HasCords_EURange = 15314;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureMethod = 15316;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureMethod_EURange = 15320;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_StartMeasure = 15322;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_StartMeasure_EURange = 15326;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn = 15330;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrIn_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrIn_EURange = 15334;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop = 15336;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Drop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Drop_EURange = 15340;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width = 15342;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Width_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Width_EURange = 15346;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DateTime = 15348;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DateTime_EURange = 15352;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrOut = 15354;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_SerialNrOut_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_SerialNrOut_EURange = 15358;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropA = 15360;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropA_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropA_EURange = 15364;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropB = 15366;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropB_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropB_EURange = 15370;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropC = 15372;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredDropC_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredDropC_EURange = 15376;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DeltaDrop = 15378;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DeltaDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DeltaDrop_EURange = 15382;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredWidth = 15384;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasuredWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasuredWidth_EURange = 15388;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Approved = 15390;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Approved_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Approved_EURange = 15394;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MountOffSetVert Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MountOffSetVert = 15396;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MountOffSetVert_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MountOffSetVert_EURange = 15400;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_OffsetLaserOnProd Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_OffsetLaserOnProd = 15402;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_OffsetLaserOnProd_EURange = 15406;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthPlus Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceWidthPlus = 15408;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceWidthPlus_EURange = 15412;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropPlus Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropPlus = 15414;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropPlus_EURange = 15418;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthMinus Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceWidthMinus = 15420;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceWidthMinus_EURange = 15424;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropMinus Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropMinus = 15426;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropMinus_EURange = 15430;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropDiff Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropDiff = 15432;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ToleranceDropDiff_EURange = 15436;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_BottomBarRadius Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_BottomBarRadius = 15438;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_BottomBarRadius_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_BottomBarRadius_EURange = 15442;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_PrefMeasDist Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_PrefMeasDist = 15444;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_PrefMeasDist_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_PrefMeasDist_EURange = 15448;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Endcapcompensation Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Endcapcompensation = 15450;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Endcapcompensation_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_Endcapcompensation_EURange = 15454;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureDrop Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureDrop = 15456;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureDrop_EURange = 15460;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureWidth Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureWidth = 15462;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureWidth_EURange = 15466;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureSquareness Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureSquareness = 15468;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureSquareness_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureSquareness_EURange = 15472;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HasCords Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HasCords = 15474;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HasCords_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HasCords_EURange = 15478;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureMethod Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureMethod = 15480;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureMethod_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_MeasureMethod_EURange = 15484;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_StartMeasure Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_StartMeasure = 15486;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_StartMeasure_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_StartMeasure_EURange = 15490;
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
        /// The identifier for the Input_MountOffSetVert Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MountOffSetVert = new ExpandedNodeId(OPCUAServer.Variables.Input_MountOffSetVert, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MountOffSetVert_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MountOffSetVert_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MountOffSetVert_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_OffsetLaserOnProd = new ExpandedNodeId(OPCUAServer.Variables.Input_OffsetLaserOnProd, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_OffsetLaserOnProd_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_OffsetLaserOnProd_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceWidthPlus = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceWidthPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceWidthPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceWidthPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropPlus = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceWidthMinus = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceWidthMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceWidthMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceWidthMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropMinus = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropDiff = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropDiff, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ToleranceDropDiff_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ToleranceDropDiff_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_BottomBarRadius Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_BottomBarRadius = new ExpandedNodeId(OPCUAServer.Variables.Input_BottomBarRadius, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_BottomBarRadius_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_BottomBarRadius_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_BottomBarRadius_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_PrefMeasDist Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_PrefMeasDist = new ExpandedNodeId(OPCUAServer.Variables.Input_PrefMeasDist, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_PrefMeasDist_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_PrefMeasDist_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_PrefMeasDist_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Endcapcompensation Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Endcapcompensation = new ExpandedNodeId(OPCUAServer.Variables.Input_Endcapcompensation, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_Endcapcompensation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_Endcapcompensation_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_Endcapcompensation_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureDrop = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureWidth = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureSquareness Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureSquareness = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureSquareness, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureSquareness_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureSquareness_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureSquareness_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_HasCords Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HasCords = new ExpandedNodeId(OPCUAServer.Variables.Input_HasCords, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_HasCords_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HasCords_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_HasCords_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureMethod Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureMethod = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureMethod, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_MeasureMethod_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_MeasureMethod_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_MeasureMethod_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_StartMeasure Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_StartMeasure = new ExpandedNodeId(OPCUAServer.Variables.Input_StartMeasure, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_StartMeasure_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_StartMeasure_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_StartMeasure_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MountOffSetVert = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MountOffSetVert, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MountOffSetVert_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MountOffSetVert_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_OffsetLaserOnProd = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_OffsetLaserOnProd, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_OffsetLaserOnProd_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_OffsetLaserOnProd_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceWidthPlus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceWidthPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceWidthPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceWidthPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropPlus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceWidthMinus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceWidthMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceWidthMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceWidthMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropMinus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropDiff = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropDiff, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ToleranceDropDiff_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ToleranceDropDiff_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_BottomBarRadius = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_BottomBarRadius, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_BottomBarRadius_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_BottomBarRadius_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_PrefMeasDist = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_PrefMeasDist, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_PrefMeasDist_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_PrefMeasDist_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Endcapcompensation = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Endcapcompensation, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_Endcapcompensation_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_Endcapcompensation_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureDrop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureWidth = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureSquareness = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureSquareness, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureSquareness_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureSquareness_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HasCords = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HasCords, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HasCords_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HasCords_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureMethod = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureMethod, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_MeasureMethod_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_MeasureMethod_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_StartMeasure = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_StartMeasure, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_StartMeasure_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_StartMeasure_EURange, OPCUAServer.Namespaces.OPCUAServer);

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

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MountOffSetVert Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MountOffSetVert = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MountOffSetVert, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MountOffSetVert_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MountOffSetVert_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MountOffSetVert_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_OffsetLaserOnProd Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_OffsetLaserOnProd = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_OffsetLaserOnProd, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_OffsetLaserOnProd_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_OffsetLaserOnProd_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceWidthPlus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceWidthPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceWidthPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceWidthPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropPlus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropPlus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropPlus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropPlus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropPlus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceWidthMinus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceWidthMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceWidthMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceWidthMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropMinus Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropMinus = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropMinus, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropMinus_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropMinus_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropDiff Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropDiff = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropDiff, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ToleranceDropDiff_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ToleranceDropDiff_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_BottomBarRadius Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_BottomBarRadius = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_BottomBarRadius, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_BottomBarRadius_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_BottomBarRadius_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_BottomBarRadius_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_PrefMeasDist Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_PrefMeasDist = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_PrefMeasDist, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_PrefMeasDist_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_PrefMeasDist_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_PrefMeasDist_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Endcapcompensation Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Endcapcompensation = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Endcapcompensation, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_Endcapcompensation_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_Endcapcompensation_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_Endcapcompensation_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureDrop Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureDrop = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureDrop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureDrop_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureDrop_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureDrop_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureWidth Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureWidth = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureWidth, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureWidth_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureWidth_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureWidth_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureSquareness Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureSquareness = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureSquareness, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureSquareness_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureSquareness_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureSquareness_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HasCords Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HasCords = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HasCords, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HasCords_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HasCords_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HasCords_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureMethod Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureMethod = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureMethod, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_MeasureMethod_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_MeasureMethod_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_MeasureMethod_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_StartMeasure Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_StartMeasure = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_StartMeasure, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_StartMeasure_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_StartMeasure_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_StartMeasure_EURange, OPCUAServer.Namespaces.OPCUAServer);
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
        /// The BrowseName for the BottomBarRadius component.
        /// </summary>
        public const string BottomBarRadius = "BottomBarRadius";

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
        /// The BrowseName for the Endcapcompensation component.
        /// </summary>
        public const string Endcapcompensation = "Endcapcompensation";

        /// <summary>
        /// The BrowseName for the HasCords component.
        /// </summary>
        public const string HasCords = "HasCords";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the InputNode component.
        /// </summary>
        public const string InputNode = "Station1";

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
        /// The BrowseName for the MeasureDrop component.
        /// </summary>
        public const string MeasureDrop = "MeasureDrop";

        /// <summary>
        /// The BrowseName for the MeasuredWidth component.
        /// </summary>
        public const string MeasuredWidth = "MeasuredWidth";

        /// <summary>
        /// The BrowseName for the MeasureMethod component.
        /// </summary>
        public const string MeasureMethod = "MeasureMethod";

        /// <summary>
        /// The BrowseName for the MeasureSquareness component.
        /// </summary>
        public const string MeasureSquareness = "MeasureSquareness";

        /// <summary>
        /// The BrowseName for the MeasureWidth component.
        /// </summary>
        public const string MeasureWidth = "MeasureWidth";

        /// <summary>
        /// The BrowseName for the MountOffSetVert component.
        /// </summary>
        public const string MountOffSetVert = "MountOffSetVert";

        /// <summary>
        /// The BrowseName for the OffsetLaserOnProd component.
        /// </summary>
        public const string OffsetLaserOnProd = "OffsetLaserOnProd";

        /// <summary>
        /// The BrowseName for the OPCUAServer1 component.
        /// </summary>
        public const string OPCUAServer1 = "Hoist";

        /// <summary>
        /// The BrowseName for the OPCUAServerType component.
        /// </summary>
        public const string OPCUAServerType = "OPCUAServerType";

        /// <summary>
        /// The BrowseName for the PrefMeasDist component.
        /// </summary>
        public const string PrefMeasDist = "PrefMeasDist";

        /// <summary>
        /// The BrowseName for the SerialNrIn component.
        /// </summary>
        public const string SerialNrIn = "SerialNrIn";

        /// <summary>
        /// The BrowseName for the SerialNrOut component.
        /// </summary>
        public const string SerialNrOut = "SerialNrOut";

        /// <summary>
        /// The BrowseName for the StartMeasure component.
        /// </summary>
        public const string StartMeasure = "StartMeasure";

        /// <summary>
        /// The BrowseName for the ToleranceDropDiff component.
        /// </summary>
        public const string ToleranceDropDiff = "ToleranceDropDiff";

        /// <summary>
        /// The BrowseName for the ToleranceDropMinus component.
        /// </summary>
        public const string ToleranceDropMinus = "ToleranceDropMinus";

        /// <summary>
        /// The BrowseName for the ToleranceDropPlus component.
        /// </summary>
        public const string ToleranceDropPlus = "ToleranceDropPlus";

        /// <summary>
        /// The BrowseName for the ToleranceWidthMinus component.
        /// </summary>
        public const string ToleranceWidthMinus = "ToleranceWidthMinus";

        /// <summary>
        /// The BrowseName for the ToleranceWidthPlus component.
        /// </summary>
        public const string ToleranceWidthPlus = "ToleranceWidthPlus";

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
           "AABJbnB1dEluc3RhbmNlAQGZOgEBmTr/////GwAAABVgiQoCAAAAAQAKAAAAU2VyaWFsTnJJbgEBmjoA" +
           "LwEAQAmaOgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBnjoALgBEnjoAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEBoDoALwEAQAmgOgAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpDoALgBEpDoAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAFAAAAV2lkdGgBAaY6AC8BAEAJpjoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAao6AC4ARKo6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAERhdGVUaW1lAQGs" +
           "OgAvAQBACaw6AAAADP////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGwOgAuAESwOgAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABTZXJpYWxOck91dAEBsjoALwEAQAmyOgAAAAz/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtjoALgBEtjoAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQQEBuDoALwEAQAm4OgAAAAv/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBvDoALgBEvDoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQANAAAATWVhc3VyZWREcm9wQgEBvjoALwEAQAm+OgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBwjoALgBEwjoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3Vy" +
           "ZWREcm9wQwEBxDoALwEAQAnEOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "yDoALgBEyDoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAJAAAARGVsdGFEcm9wAQHKOgAvAQBA" +
           "Cco6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHOOgAuAETOOgAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZFdpZHRoAQHQOgAvAQBACdA6AAAAC/////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHUOgAuAETUOgAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAgAAABBcHByb3ZlZAEB1joALwEAQAnWOgAAAAH/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB2joALgBE2joAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATW91" +
           "bnRPZmZTZXRWZXJ0AQHcOgAvAQBACdw6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQHgOgAuAETgOgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABPZmZzZXRMYXNlck9u" +
           "UHJvZAEB4joALwEAQAniOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB5joA" +
           "LgBE5joAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQASAAAAVG9sZXJhbmNlV2lkdGhQbHVzAQHo" +
           "OgAvAQBACeg6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHsOgAuAETsOgAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABUb2xlcmFuY2VEcm9wUGx1cwEB7joALwEAQAnu" +
           "OgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB8joALgBE8joAAAEAdAP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQATAAAAVG9sZXJhbmNlV2lkdGhNaW51cwEB9DoALwEAQAn0OgAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB+DoALgBE+DoAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQASAAAAVG9sZXJhbmNlRHJvcE1pbnVzAQH6OgAvAQBACfo6AAAAC/////8DA///" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH+OgAuAET+OgAAAQB0A/////8BAf////8AAAAAFWCJ" +
           "CgIAAAABABEAAABUb2xlcmFuY2VEcm9wRGlmZgEBADsALwEAQAkAOwAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBBDsALgBEBDsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAP" +
           "AAAAQm90dG9tQmFyUmFkaXVzAQEGOwAvAQBACQY7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQEKOwAuAEQKOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAwAAABQcmVmTWVh" +
           "c0Rpc3QBAQw7AC8BAEAJDDsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARA7" +
           "AC4ARBA7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAEVuZGNhcGNvbXBlbnNhdGlvbgEB" +
           "EjsALwEAQAkSOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBFjsALgBEFjsA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQALAAAATWVhc3VyZURyb3ABARg7AC8BAEAJGDsAAAAL" +
           "/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARw7AC4ARBw7AAABAHQD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEADAAAAE1lYXN1cmVXaWR0aAEBHjsALwEAQAkeOwAAAAv/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBIjsALgBEIjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQARAAAATWVhc3VyZVNxdWFyZW5lc3MBASQ7AC8BAEAJJDsAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBASg7AC4ARCg7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEhh" +
           "c0NvcmRzAQEqOwAvAQBACSo7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEu" +
           "OwAuAEQuOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlTWV0aG9kAQEwOwAv" +
           "AQBACTA7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE0OwAuAEQ0OwAAAQB0" +
           "A/////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTdGFydE1lYXN1cmUBATY7AC8BAEAJNjsAAAAI////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATo7AC4ARDo7AAABAHQD/////wEB/////wAA" +
           "AAA=";
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

        /// <summary>
        /// A description for the MountOffSetVert Variable.
        /// </summary>
        public AnalogItemState<double> MountOffSetVert
        {
            get
            {
                return m_mountOffSetVert;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mountOffSetVert, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mountOffSetVert = value;
            }
        }

        /// <summary>
        /// A description for the OffsetLaserOnProd Variable.
        /// </summary>
        public AnalogItemState<double> OffsetLaserOnProd
        {
            get
            {
                return m_offsetLaserOnProd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_offsetLaserOnProd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_offsetLaserOnProd = value;
            }
        }

        /// <summary>
        /// A description for the ToleranceWidthPlus Variable.
        /// </summary>
        public AnalogItemState<double> ToleranceWidthPlus
        {
            get
            {
                return m_toleranceWidthPlus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toleranceWidthPlus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toleranceWidthPlus = value;
            }
        }

        /// <summary>
        /// A description for the ToleranceDropPlus Variable.
        /// </summary>
        public AnalogItemState<double> ToleranceDropPlus
        {
            get
            {
                return m_toleranceDropPlus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toleranceDropPlus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toleranceDropPlus = value;
            }
        }

        /// <summary>
        /// A description for the ToleranceWidthMinus Variable.
        /// </summary>
        public AnalogItemState<double> ToleranceWidthMinus
        {
            get
            {
                return m_toleranceWidthMinus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toleranceWidthMinus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toleranceWidthMinus = value;
            }
        }

        /// <summary>
        /// A description for the ToleranceDropMinus Variable.
        /// </summary>
        public AnalogItemState<double> ToleranceDropMinus
        {
            get
            {
                return m_toleranceDropMinus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toleranceDropMinus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toleranceDropMinus = value;
            }
        }

        /// <summary>
        /// A description for the ToleranceDropDiff Variable.
        /// </summary>
        public AnalogItemState<double> ToleranceDropDiff
        {
            get
            {
                return m_toleranceDropDiff;
            }

            set
            {
                if (!Object.ReferenceEquals(m_toleranceDropDiff, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_toleranceDropDiff = value;
            }
        }

        /// <summary>
        /// A description for the BottomBarRadius Variable.
        /// </summary>
        public AnalogItemState<double> BottomBarRadius
        {
            get
            {
                return m_bottomBarRadius;
            }

            set
            {
                if (!Object.ReferenceEquals(m_bottomBarRadius, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_bottomBarRadius = value;
            }
        }

        /// <summary>
        /// A description for the PrefMeasDist Variable.
        /// </summary>
        public AnalogItemState<double> PrefMeasDist
        {
            get
            {
                return m_prefMeasDist;
            }

            set
            {
                if (!Object.ReferenceEquals(m_prefMeasDist, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_prefMeasDist = value;
            }
        }

        /// <summary>
        /// A description for the Endcapcompensation Variable.
        /// </summary>
        public AnalogItemState<double> Endcapcompensation
        {
            get
            {
                return m_endcapcompensation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_endcapcompensation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_endcapcompensation = value;
            }
        }

        /// <summary>
        /// A description for the MeasureDrop Variable.
        /// </summary>
        public AnalogItemState<double> MeasureDrop
        {
            get
            {
                return m_measureDrop;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measureDrop, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measureDrop = value;
            }
        }

        /// <summary>
        /// A description for the MeasureWidth Variable.
        /// </summary>
        public AnalogItemState<double> MeasureWidth
        {
            get
            {
                return m_measureWidth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measureWidth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measureWidth = value;
            }
        }

        /// <summary>
        /// A description for the MeasureSquareness Variable.
        /// </summary>
        public AnalogItemState<double> MeasureSquareness
        {
            get
            {
                return m_measureSquareness;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measureSquareness, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measureSquareness = value;
            }
        }

        /// <summary>
        /// A description for the HasCords Variable.
        /// </summary>
        public AnalogItemState<double> HasCords
        {
            get
            {
                return m_hasCords;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hasCords, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hasCords = value;
            }
        }

        /// <summary>
        /// A description for the MeasureMethod Variable.
        /// </summary>
        public AnalogItemState<double> MeasureMethod
        {
            get
            {
                return m_measureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measureMethod = value;
            }
        }

        /// <summary>
        /// A description for the StartMeasure Variable.
        /// </summary>
        public AnalogItemState<long> StartMeasure
        {
            get
            {
                return m_startMeasure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMeasure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMeasure = value;
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

            if (m_mountOffSetVert != null)
            {
                children.Add(m_mountOffSetVert);
            }

            if (m_offsetLaserOnProd != null)
            {
                children.Add(m_offsetLaserOnProd);
            }

            if (m_toleranceWidthPlus != null)
            {
                children.Add(m_toleranceWidthPlus);
            }

            if (m_toleranceDropPlus != null)
            {
                children.Add(m_toleranceDropPlus);
            }

            if (m_toleranceWidthMinus != null)
            {
                children.Add(m_toleranceWidthMinus);
            }

            if (m_toleranceDropMinus != null)
            {
                children.Add(m_toleranceDropMinus);
            }

            if (m_toleranceDropDiff != null)
            {
                children.Add(m_toleranceDropDiff);
            }

            if (m_bottomBarRadius != null)
            {
                children.Add(m_bottomBarRadius);
            }

            if (m_prefMeasDist != null)
            {
                children.Add(m_prefMeasDist);
            }

            if (m_endcapcompensation != null)
            {
                children.Add(m_endcapcompensation);
            }

            if (m_measureDrop != null)
            {
                children.Add(m_measureDrop);
            }

            if (m_measureWidth != null)
            {
                children.Add(m_measureWidth);
            }

            if (m_measureSquareness != null)
            {
                children.Add(m_measureSquareness);
            }

            if (m_hasCords != null)
            {
                children.Add(m_hasCords);
            }

            if (m_measureMethod != null)
            {
                children.Add(m_measureMethod);
            }

            if (m_startMeasure != null)
            {
                children.Add(m_startMeasure);
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

                case OPCUAServer.BrowseNames.MountOffSetVert:
                {
                    if (createOrReplace)
                    {
                        if (MountOffSetVert == null)
                        {
                            if (replacement == null)
                            {
                                MountOffSetVert = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MountOffSetVert = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MountOffSetVert;
                    break;
                }

                case OPCUAServer.BrowseNames.OffsetLaserOnProd:
                {
                    if (createOrReplace)
                    {
                        if (OffsetLaserOnProd == null)
                        {
                            if (replacement == null)
                            {
                                OffsetLaserOnProd = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                OffsetLaserOnProd = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = OffsetLaserOnProd;
                    break;
                }

                case OPCUAServer.BrowseNames.ToleranceWidthPlus:
                {
                    if (createOrReplace)
                    {
                        if (ToleranceWidthPlus == null)
                        {
                            if (replacement == null)
                            {
                                ToleranceWidthPlus = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ToleranceWidthPlus = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ToleranceWidthPlus;
                    break;
                }

                case OPCUAServer.BrowseNames.ToleranceDropPlus:
                {
                    if (createOrReplace)
                    {
                        if (ToleranceDropPlus == null)
                        {
                            if (replacement == null)
                            {
                                ToleranceDropPlus = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ToleranceDropPlus = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ToleranceDropPlus;
                    break;
                }

                case OPCUAServer.BrowseNames.ToleranceWidthMinus:
                {
                    if (createOrReplace)
                    {
                        if (ToleranceWidthMinus == null)
                        {
                            if (replacement == null)
                            {
                                ToleranceWidthMinus = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ToleranceWidthMinus = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ToleranceWidthMinus;
                    break;
                }

                case OPCUAServer.BrowseNames.ToleranceDropMinus:
                {
                    if (createOrReplace)
                    {
                        if (ToleranceDropMinus == null)
                        {
                            if (replacement == null)
                            {
                                ToleranceDropMinus = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ToleranceDropMinus = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ToleranceDropMinus;
                    break;
                }

                case OPCUAServer.BrowseNames.ToleranceDropDiff:
                {
                    if (createOrReplace)
                    {
                        if (ToleranceDropDiff == null)
                        {
                            if (replacement == null)
                            {
                                ToleranceDropDiff = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ToleranceDropDiff = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ToleranceDropDiff;
                    break;
                }

                case OPCUAServer.BrowseNames.BottomBarRadius:
                {
                    if (createOrReplace)
                    {
                        if (BottomBarRadius == null)
                        {
                            if (replacement == null)
                            {
                                BottomBarRadius = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                BottomBarRadius = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = BottomBarRadius;
                    break;
                }

                case OPCUAServer.BrowseNames.PrefMeasDist:
                {
                    if (createOrReplace)
                    {
                        if (PrefMeasDist == null)
                        {
                            if (replacement == null)
                            {
                                PrefMeasDist = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                PrefMeasDist = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = PrefMeasDist;
                    break;
                }

                case OPCUAServer.BrowseNames.Endcapcompensation:
                {
                    if (createOrReplace)
                    {
                        if (Endcapcompensation == null)
                        {
                            if (replacement == null)
                            {
                                Endcapcompensation = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Endcapcompensation = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Endcapcompensation;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasureDrop:
                {
                    if (createOrReplace)
                    {
                        if (MeasureDrop == null)
                        {
                            if (replacement == null)
                            {
                                MeasureDrop = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasureDrop = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasureDrop;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasureWidth:
                {
                    if (createOrReplace)
                    {
                        if (MeasureWidth == null)
                        {
                            if (replacement == null)
                            {
                                MeasureWidth = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasureWidth = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasureWidth;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasureSquareness:
                {
                    if (createOrReplace)
                    {
                        if (MeasureSquareness == null)
                        {
                            if (replacement == null)
                            {
                                MeasureSquareness = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasureSquareness = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasureSquareness;
                    break;
                }

                case OPCUAServer.BrowseNames.HasCords:
                {
                    if (createOrReplace)
                    {
                        if (HasCords == null)
                        {
                            if (replacement == null)
                            {
                                HasCords = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                HasCords = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = HasCords;
                    break;
                }

                case OPCUAServer.BrowseNames.MeasureMethod:
                {
                    if (createOrReplace)
                    {
                        if (MeasureMethod == null)
                        {
                            if (replacement == null)
                            {
                                MeasureMethod = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                MeasureMethod = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = MeasureMethod;
                    break;
                }

                case OPCUAServer.BrowseNames.StartMeasure:
                {
                    if (createOrReplace)
                    {
                        if (StartMeasure == null)
                        {
                            if (replacement == null)
                            {
                                StartMeasure = new AnalogItemState<long>(this);
                            }
                            else
                            {
                                StartMeasure = (AnalogItemState<long>)replacement;
                            }
                        }
                    }

                    instance = StartMeasure;
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
        private AnalogItemState<string> m_dateTime;
        private AnalogItemState<string> m_serialNrOut;
        private AnalogItemState<double> m_measuredDropA;
        private AnalogItemState<double> m_measuredDropB;
        private AnalogItemState<double> m_measuredDropC;
        private AnalogItemState<double> m_deltaDrop;
        private AnalogItemState<double> m_measuredWidth;
        private AnalogItemState<bool> m_approved;
        private AnalogItemState<double> m_mountOffSetVert;
        private AnalogItemState<double> m_offsetLaserOnProd;
        private AnalogItemState<double> m_toleranceWidthPlus;
        private AnalogItemState<double> m_toleranceDropPlus;
        private AnalogItemState<double> m_toleranceWidthMinus;
        private AnalogItemState<double> m_toleranceDropMinus;
        private AnalogItemState<double> m_toleranceDropDiff;
        private AnalogItemState<double> m_bottomBarRadius;
        private AnalogItemState<double> m_prefMeasDist;
        private AnalogItemState<double> m_endcapcompensation;
        private AnalogItemState<double> m_measureDrop;
        private AnalogItemState<double> m_measureWidth;
        private AnalogItemState<double> m_measureSquareness;
        private AnalogItemState<double> m_hasCords;
        private AnalogItemState<double> m_measureMethod;
        private AnalogItemState<long> m_startMeasure;
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
    public partial class OPCUAServerState : FolderState
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
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEBPDsBATw7Af////8BAAAAhGDACgEAAAAJAAAASW5wdXRO" +
           "b2RlAQAIAAAAU3RhdGlvbjEBAT07AC8BAZk6PTsAAAH/////GwAAABVgiQoCAAAAAQAKAAAAU2VyaWFs" +
           "TnJJbgEBPjsALwEAQAk+OwAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBQjsA" +
           "LgBEQjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEBRDsALwEAQAlEOwAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBSDsALgBESDsAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAV2lkdGgBAUo7AC8BAEAJSjsAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAU47AC4ARE47AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAERh" +
           "dGVUaW1lAQFQOwAvAQBACVA7AAAADP////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFU" +
           "OwAuAERUOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABTZXJpYWxOck91dAEBVjsALwEA" +
           "QAlWOwAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBWjsALgBEWjsAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQQEBXDsALwEAQAlcOwAAAAv/////" +
           "AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBYDsALgBEYDsAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQgEBYjsALwEAQAliOwAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBZjsALgBEZjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAN" +
           "AAAATWVhc3VyZWREcm9wQwEBaDsALwEAQAloOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBbDsALgBEbDsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAJAAAARGVsdGFEcm9w" +
           "AQFuOwAvAQBACW47AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFyOwAuAERy" +
           "OwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZFdpZHRoAQF0OwAvAQBACXQ7" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQF4OwAuAER4OwAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAgAAABBcHByb3ZlZAEBejsALwEAQAl6OwAAAAH/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBfjsALgBEfjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAPAAAATW91bnRPZmZTZXRWZXJ0AQGAOwAvAQBACYA7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGEOwAuAESEOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABPZmZz" +
           "ZXRMYXNlck9uUHJvZAEBhjsALwEAQAmGOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBijsALgBEijsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQASAAAAVG9sZXJhbmNlV2lk" +
           "dGhQbHVzAQGMOwAvAQBACYw7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGQ" +
           "OwAuAESQOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABUb2xlcmFuY2VEcm9wUGx1cwEB" +
           "kjsALwEAQAmSOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBljsALgBEljsA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQATAAAAVG9sZXJhbmNlV2lkdGhNaW51cwEBmDsALwEA" +
           "QAmYOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBnDsALgBEnDsAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQASAAAAVG9sZXJhbmNlRHJvcE1pbnVzAQGeOwAvAQBACZ47AAAA" +
           "C/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGiOwAuAESiOwAAAQB0A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABEAAABUb2xlcmFuY2VEcm9wRGlmZgEBpDsALwEAQAmkOwAAAAv/////AwP/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBqDsALgBEqDsAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAPAAAAQm90dG9tQmFyUmFkaXVzAQGqOwAvAQBACao7AAAAC/////8DA/////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQGuOwAuAESuOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAwA" +
           "AABQcmVmTWVhc0Rpc3QBAbA7AC8BAEAJsDsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAbQ7AC4ARLQ7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAEVuZGNhcGNvbXBl" +
           "bnNhdGlvbgEBtjsALwEAQAm2OwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "ujsALgBEujsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQALAAAATWVhc3VyZURyb3ABAbw7AC8B" +
           "AEAJvDsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcA7AC4ARMA7AAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAE1lYXN1cmVXaWR0aAEBwjsALwEAQAnCOwAAAAv/////" +
           "AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBxjsALgBExjsAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQARAAAATWVhc3VyZVNxdWFyZW5lc3MBAcg7AC8BAEAJyDsAAAAL/////wMD/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAcw7AC4ARMw7AAABAHQD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACAAAAEhhc0NvcmRzAQHOOwAvAQBACc47AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHSOwAuAETSOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlTWV0" +
           "aG9kAQHUOwAvAQBACdQ7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHYOwAu" +
           "AETYOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTdGFydE1lYXN1cmUBAdo7AC8BAEAJ" +
           "2jsAAAAI/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAd47AC4ARN47AAABAHQD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Station1 Object.
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
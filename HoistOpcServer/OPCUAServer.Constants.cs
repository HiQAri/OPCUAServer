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
        public const uint Input_DateTime = 15062;

        /// <summary>
        /// The identifier for the Input_DateTime_EURange Variable.
        /// </summary>
        public const uint Input_DateTime_EURange = 15066;

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
        /// The identifier for the Input_ResultFeedback Variable.
        /// </summary>
        public const uint Input_ResultFeedback = 15020;

        /// <summary>
        /// The identifier for the Input_ResultFeedback_EURange Variable.
        /// </summary>
        public const uint Input_ResultFeedback_EURange = 15024;

        /// <summary>
        /// The identifier for the Input_MountOffSetVert Variable.
        /// </summary>
        public const uint Input_MountOffSetVert = 15204;

        /// <summary>
        /// The identifier for the Input_MountOffSetVert_EURange Variable.
        /// </summary>
        public const uint Input_MountOffSetVert_EURange = 15208;

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd Variable.
        /// </summary>
        public const uint Input_OffsetLaserOnProd = 15210;

        /// <summary>
        /// The identifier for the Input_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public const uint Input_OffsetLaserOnProd_EURange = 15214;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus Variable.
        /// </summary>
        public const uint Input_ToleranceWidthPlus = 15216;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceWidthPlus_EURange = 15220;

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus Variable.
        /// </summary>
        public const uint Input_ToleranceDropPlus = 15222;

        /// <summary>
        /// The identifier for the Input_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropPlus_EURange = 15226;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus Variable.
        /// </summary>
        public const uint Input_ToleranceWidthMinus = 15228;

        /// <summary>
        /// The identifier for the Input_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceWidthMinus_EURange = 15232;

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus Variable.
        /// </summary>
        public const uint Input_ToleranceDropMinus = 15234;

        /// <summary>
        /// The identifier for the Input_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropMinus_EURange = 15238;

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff Variable.
        /// </summary>
        public const uint Input_ToleranceDropDiff = 15240;

        /// <summary>
        /// The identifier for the Input_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public const uint Input_ToleranceDropDiff_EURange = 15244;

        /// <summary>
        /// The identifier for the Input_BottomBarRadius Variable.
        /// </summary>
        public const uint Input_BottomBarRadius = 15246;

        /// <summary>
        /// The identifier for the Input_BottomBarRadius_EURange Variable.
        /// </summary>
        public const uint Input_BottomBarRadius_EURange = 15250;

        /// <summary>
        /// The identifier for the Input_PrefMeasDist Variable.
        /// </summary>
        public const uint Input_PrefMeasDist = 15252;

        /// <summary>
        /// The identifier for the Input_PrefMeasDist_EURange Variable.
        /// </summary>
        public const uint Input_PrefMeasDist_EURange = 15256;

        /// <summary>
        /// The identifier for the Input_Endcapcompensation Variable.
        /// </summary>
        public const uint Input_Endcapcompensation = 15258;

        /// <summary>
        /// The identifier for the Input_Endcapcompensation_EURange Variable.
        /// </summary>
        public const uint Input_Endcapcompensation_EURange = 15262;

        /// <summary>
        /// The identifier for the Input_MeasureDrop Variable.
        /// </summary>
        public const uint Input_MeasureDrop = 15264;

        /// <summary>
        /// The identifier for the Input_MeasureDrop_EURange Variable.
        /// </summary>
        public const uint Input_MeasureDrop_EURange = 15268;

        /// <summary>
        /// The identifier for the Input_MeasureWidth Variable.
        /// </summary>
        public const uint Input_MeasureWidth = 15270;

        /// <summary>
        /// The identifier for the Input_MeasureWidth_EURange Variable.
        /// </summary>
        public const uint Input_MeasureWidth_EURange = 15274;

        /// <summary>
        /// The identifier for the Input_MeasureSquareness Variable.
        /// </summary>
        public const uint Input_MeasureSquareness = 15276;

        /// <summary>
        /// The identifier for the Input_MeasureSquareness_EURange Variable.
        /// </summary>
        public const uint Input_MeasureSquareness_EURange = 15280;

        /// <summary>
        /// The identifier for the Input_HasCords Variable.
        /// </summary>
        public const uint Input_HasCords = 15282;

        /// <summary>
        /// The identifier for the Input_HasCords_EURange Variable.
        /// </summary>
        public const uint Input_HasCords_EURange = 15286;

        /// <summary>
        /// The identifier for the Input_MeasureMethod Variable.
        /// </summary>
        public const uint Input_MeasureMethod = 15288;

        /// <summary>
        /// The identifier for the Input_MeasureMethod_EURange Variable.
        /// </summary>
        public const uint Input_MeasureMethod_EURange = 15292;

        /// <summary>
        /// The identifier for the Input_StartMeasure Variable.
        /// </summary>
        public const uint Input_StartMeasure = 15294;

        /// <summary>
        /// The identifier for the Input_StartMeasure_EURange Variable.
        /// </summary>
        public const uint Input_StartMeasure_EURange = 15298;

        /// <summary>
        /// The identifier for the Input_HoistState Variable.
        /// </summary>
        public const uint Input_HoistState = 15528;

        /// <summary>
        /// The identifier for the Input_HoistState_EURange Variable.
        /// </summary>
        public const uint Input_HoistState_EURange = 15532;

        /// <summary>
        /// The identifier for the Input_HoistError Variable.
        /// </summary>
        public const uint Input_HoistError = 15534;

        /// <summary>
        /// The identifier for the Input_HoistError_EURange Variable.
        /// </summary>
        public const uint Input_HoistError_EURange = 15538;

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
        public const uint OPCUAServerType_InputNode_DateTime = 15130;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_DateTime_EURange = 15134;

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
        /// The identifier for the OPCUAServerType_InputNode_ResultFeedback Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ResultFeedback = 15088;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ResultFeedback_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ResultFeedback_EURange = 15092;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MountOffSetVert = 15300;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MountOffSetVert_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MountOffSetVert_EURange = 15304;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_OffsetLaserOnProd = 15306;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_OffsetLaserOnProd_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_OffsetLaserOnProd_EURange = 15310;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthPlus = 15312;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthPlus_EURange = 15316;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropPlus = 15318;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropPlus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropPlus_EURange = 15322;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthMinus = 15324;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceWidthMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceWidthMinus_EURange = 15328;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropMinus = 15330;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropMinus_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropMinus_EURange = 15334;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropDiff = 15336;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ToleranceDropDiff_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_ToleranceDropDiff_EURange = 15340;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_BottomBarRadius = 15342;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_BottomBarRadius_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_BottomBarRadius_EURange = 15346;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_PrefMeasDist = 15348;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_PrefMeasDist_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_PrefMeasDist_EURange = 15352;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Endcapcompensation = 15354;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_Endcapcompensation_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_Endcapcompensation_EURange = 15358;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureDrop = 15360;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureDrop_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureDrop_EURange = 15364;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureWidth = 15366;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureWidth_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureWidth_EURange = 15370;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureSquareness = 15372;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureSquareness_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureSquareness_EURange = 15376;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HasCords = 15378;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HasCords_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HasCords_EURange = 15382;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureMethod = 15384;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_MeasureMethod_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_MeasureMethod_EURange = 15388;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_StartMeasure = 15390;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_StartMeasure_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_StartMeasure_EURange = 15394;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistState Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HoistState = 15540;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistState_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HoistState_EURange = 15544;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistError Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HoistError = 15546;

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistError_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_InputNode_HoistError_EURange = 15550;

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
        public const uint OPCUAServer1_InputNode_DateTime = 15198;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_DateTime_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_DateTime_EURange = 15202;

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
        /// The identifier for the OPCUAServer1_InputNode_ResultFeedback Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ResultFeedback = 15156;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ResultFeedback_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_ResultFeedback_EURange = 15160;

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

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistState Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HoistState = 15552;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistState_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HoistState_EURange = 15556;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistError Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HoistError = 15558;

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistError_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_InputNode_HoistError_EURange = 15562;
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
        /// The identifier for the Input_ResultFeedback Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ResultFeedback = new ExpandedNodeId(OPCUAServer.Variables.Input_ResultFeedback, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_ResultFeedback_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_ResultFeedback_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_ResultFeedback_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the Input_HoistState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HoistState = new ExpandedNodeId(OPCUAServer.Variables.Input_HoistState, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_HoistState_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HoistState_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_HoistState_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_HoistError Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HoistError = new ExpandedNodeId(OPCUAServer.Variables.Input_HoistError, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the Input_HoistError_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Input_HoistError_EURange = new ExpandedNodeId(OPCUAServer.Variables.Input_HoistError_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the OPCUAServerType_InputNode_ResultFeedback Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ResultFeedback = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ResultFeedback, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_ResultFeedback_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_ResultFeedback_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_ResultFeedback_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the OPCUAServerType_InputNode_HoistState Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HoistState = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HoistState, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistState_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HoistState_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HoistState_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistError Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HoistError = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HoistError, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_InputNode_HoistError_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_InputNode_HoistError_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_InputNode_HoistError_EURange, OPCUAServer.Namespaces.OPCUAServer);

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
        /// The identifier for the OPCUAServer1_InputNode_ResultFeedback Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ResultFeedback = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ResultFeedback, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_ResultFeedback_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_ResultFeedback_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_ResultFeedback_EURange, OPCUAServer.Namespaces.OPCUAServer);

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

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistState Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HoistState = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HoistState, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistState_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HoistState_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HoistState_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistError Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HoistError = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HoistError, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_InputNode_HoistError_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_InputNode_HoistError_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_InputNode_HoistError_EURange, OPCUAServer.Namespaces.OPCUAServer);
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
        /// The BrowseName for the HoistError component.
        /// </summary>
        public const string HoistError = "HoistError";

        /// <summary>
        /// The BrowseName for the HoistState component.
        /// </summary>
        public const string HoistState = "HoistState";

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
        /// The BrowseName for the ResultFeedback component.
        /// </summary>
        public const string ResultFeedback = "ResultFeedback";

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
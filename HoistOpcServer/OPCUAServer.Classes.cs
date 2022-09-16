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
           "AABJbnB1dEluc3RhbmNlAQGZOgEBmTr/////IAAAABVgiQoCAAAAAQAKAAAAU2VyaWFsTnJJbgEBmjoA" +
           "LwEAQAmaOgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBnjoALgBEnjoAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEBoDoALwEAQAmgOgAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpDoALgBEpDoAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAFAAAAV2lkdGgBAaY6AC8BAEAJpjoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAao6AC4ARKo6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAERhdGUBAcw8AC8B" +
           "AEAJzDwAAAAM/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdA8AC4ARNA8AAABAHQD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAFRpbWUBAdI8AC8BAEAJ0jwAAAAM/////wMD/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdY8AC4ARNY8AAABAHQD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAFNlcmlhbE5yT3V0AQGyOgAvAQBACbI6AAAADP////8DA/////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQG2OgAuAES2OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJl" +
           "ZERyb3BBAQG4OgAvAQBACbg6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQG8" +
           "OgAuAES8OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZERyb3BCAQG+OgAv" +
           "AQBACb46AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHCOgAuAETCOgAAAQB0" +
           "A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZERyb3BDAQHEOgAvAQBACcQ6AAAAC///" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHIOgAuAETIOgAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAkAAABEZWx0YURyb3ABAco6AC8BAEAJyjoAAAAL/////wMD/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAc46AC4ARM46AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADQAA" +
           "AE1lYXN1cmVkV2lkdGgBAdA6AC8BAEAJ0DoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAdQ6AC4ARNQ6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEFwcHJvdmVkAQHW" +
           "OgAvAQBACdY6AAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHaOgAuAETaOgAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABSZXRyeQEBhDwALwEAQAmEPAAAAAH/////AwP/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiDwALgBEiDwAAAEAdAP/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAIAAAAUmVqZWN0ZWQBAYo8AC8BAEAJijwAAAAB/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAY48AC4ARI48AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1vdW50" +
           "T2ZmU2V0VmVydAEBZDsALwEAQAlkOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBaDsALgBEaDsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAAT2Zmc2V0TGFzZXJPblBy" +
           "b2QBAWo7AC8BAEAJajsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAW47AC4A" +
           "RG47AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFRvbGVyYW5jZVdpZHRoUGx1cwEBcDsA" +
           "LwEAQAlwOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBdDsALgBEdDsAAAEA" +
           "dAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAAVG9sZXJhbmNlRHJvcFBsdXMBAXY7AC8BAEAJdjsA" +
           "AAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXo7AC4ARHo7AAABAHQD/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEAEwAAAFRvbGVyYW5jZVdpZHRoTWludXMBAXw7AC8BAEAJfDsAAAAL////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAYA7AC4ARIA7AAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEAEgAAAFRvbGVyYW5jZURyb3BNaW51cwEBgjsALwEAQAmCOwAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBhjsALgBEhjsAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQARAAAAVG9sZXJhbmNlRHJvcERpZmYBAYg7AC8BAEAJiDsAAAAL/////wMD/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBAYw7AC4ARIw7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADwAA" +
           "AEJvdHRvbUJhclJhZGl1cwEBjjsALwEAQAmOOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBkjsALgBEkjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAUHJlZk1lYXNE" +
           "aXN0AQGUOwAvAQBACZQ7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGYOwAu" +
           "AESYOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABIAAABFbmRjYXBjb21wZW5zYXRpb24BAZo7" +
           "AC8BAEAJmjsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ47AC4ARJ47AAAB" +
           "AHQD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVEcm9wAQGgOwAvAQBACaA7AAAABv//" +
           "//8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGkOwAuAESkOwAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAwAAABNZWFzdXJlV2lkdGgBAaY7AC8BAEAJpjsAAAAG/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAao7AC4ARKo7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "EQAAAE1lYXN1cmVTcXVhcmVuZXNzAQGsOwAvAQBACaw7AAAABv////8DA/////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGwOwAuAESwOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAgAAABIYXND" +
           "b3JkcwEBsjsALwEAQAmyOwAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtjsA" +
           "LgBEtjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZU1ldGhvZAEBuDsALwEA" +
           "QAm4OwAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBvDsALgBEvDsAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU3RhcnRNZWFzdXJlAQG+OwAvAQBACb47AAAABv////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHCOwAuAETCOwAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAoAAABIb2lzdFN0YXRlAQGoPAAvAQBACag8AAAADP////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQGsPAAuAESsPAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAoAAABI" +
           "b2lzdEVycm9yAQGuPAAvAQBACa48AAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdl" +
           "AQGyPAAuAESyPAAAAQB0A/////8BAf////8AAAAA";
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
        /// A description for the Date Variable.
        /// </summary>
        public AnalogItemState<string> Date
        {
            get
            {
                return m_date;
            }

            set
            {
                if (!Object.ReferenceEquals(m_date, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_date = value;
            }
        }

        /// <summary>
        /// A description for the Time Variable.
        /// </summary>
        public AnalogItemState<string> Time
        {
            get
            {
                return m_time;
            }

            set
            {
                if (!Object.ReferenceEquals(m_time, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_time = value;
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
        /// A description for the Retry Variable.
        /// </summary>
        public AnalogItemState<bool> Retry
        {
            get
            {
                return m_retry;
            }

            set
            {
                if (!Object.ReferenceEquals(m_retry, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_retry = value;
            }
        }

        /// <summary>
        /// A description for the Rejected Variable.
        /// </summary>
        public AnalogItemState<bool> Rejected
        {
            get
            {
                return m_rejected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rejected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rejected = value;
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
        public AnalogItemState<int> MeasureDrop
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
        public AnalogItemState<int> MeasureWidth
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
        public AnalogItemState<int> MeasureSquareness
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
        public AnalogItemState<int> HasCords
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
        public AnalogItemState<int> MeasureMethod
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
        public AnalogItemState<int> StartMeasure
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

        /// <summary>
        /// A description for the HoistState Variable.
        /// </summary>
        public AnalogItemState<string> HoistState
        {
            get
            {
                return m_hoistState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hoistState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hoistState = value;
            }
        }

        /// <summary>
        /// A description for the HoistError Variable.
        /// </summary>
        public AnalogItemState<int> HoistError
        {
            get
            {
                return m_hoistError;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hoistError, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hoistError = value;
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

            if (m_date != null)
            {
                children.Add(m_date);
            }

            if (m_time != null)
            {
                children.Add(m_time);
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

            if (m_retry != null)
            {
                children.Add(m_retry);
            }

            if (m_rejected != null)
            {
                children.Add(m_rejected);
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

            if (m_hoistState != null)
            {
                children.Add(m_hoistState);
            }

            if (m_hoistError != null)
            {
                children.Add(m_hoistError);
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

                case OPCUAServer.BrowseNames.Date:
                {
                    if (createOrReplace)
                    {
                        if (Date == null)
                        {
                            if (replacement == null)
                            {
                                Date = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                Date = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = Date;
                    break;
                }

                case OPCUAServer.BrowseNames.Time:
                {
                    if (createOrReplace)
                    {
                        if (Time == null)
                        {
                            if (replacement == null)
                            {
                                Time = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                Time = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = Time;
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

                case OPCUAServer.BrowseNames.Retry:
                {
                    if (createOrReplace)
                    {
                        if (Retry == null)
                        {
                            if (replacement == null)
                            {
                                Retry = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Retry = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Retry;
                    break;
                }

                case OPCUAServer.BrowseNames.Rejected:
                {
                    if (createOrReplace)
                    {
                        if (Rejected == null)
                        {
                            if (replacement == null)
                            {
                                Rejected = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Rejected = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Rejected;
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
                                MeasureDrop = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                MeasureDrop = (AnalogItemState<int>)replacement;
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
                                MeasureWidth = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                MeasureWidth = (AnalogItemState<int>)replacement;
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
                                MeasureSquareness = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                MeasureSquareness = (AnalogItemState<int>)replacement;
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
                                HasCords = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                HasCords = (AnalogItemState<int>)replacement;
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
                                MeasureMethod = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                MeasureMethod = (AnalogItemState<int>)replacement;
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
                                StartMeasure = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                StartMeasure = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = StartMeasure;
                    break;
                }

                case OPCUAServer.BrowseNames.HoistState:
                {
                    if (createOrReplace)
                    {
                        if (HoistState == null)
                        {
                            if (replacement == null)
                            {
                                HoistState = new AnalogItemState<string>(this);
                            }
                            else
                            {
                                HoistState = (AnalogItemState<string>)replacement;
                            }
                        }
                    }

                    instance = HoistState;
                    break;
                }

                case OPCUAServer.BrowseNames.HoistError:
                {
                    if (createOrReplace)
                    {
                        if (HoistError == null)
                        {
                            if (replacement == null)
                            {
                                HoistError = new AnalogItemState<int>(this);
                            }
                            else
                            {
                                HoistError = (AnalogItemState<int>)replacement;
                            }
                        }
                    }

                    instance = HoistError;
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
        private AnalogItemState<string> m_date;
        private AnalogItemState<string> m_time;
        private AnalogItemState<string> m_serialNrOut;
        private AnalogItemState<double> m_measuredDropA;
        private AnalogItemState<double> m_measuredDropB;
        private AnalogItemState<double> m_measuredDropC;
        private AnalogItemState<double> m_deltaDrop;
        private AnalogItemState<double> m_measuredWidth;
        private AnalogItemState<bool> m_approved;
        private AnalogItemState<bool> m_retry;
        private AnalogItemState<bool> m_rejected;
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
        private AnalogItemState<int> m_measureDrop;
        private AnalogItemState<int> m_measureWidth;
        private AnalogItemState<int> m_measureSquareness;
        private AnalogItemState<int> m_hasCords;
        private AnalogItemState<int> m_measureMethod;
        private AnalogItemState<int> m_startMeasure;
        private AnalogItemState<string> m_hoistState;
        private AnalogItemState<int> m_hoistError;
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
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEB3DoBAdw6Af////8BAAAAhGDACgEAAAAJAAAASW5wdXRO" +
           "b2RlAQAIAAAAU3RhdGlvbjEBAd06AC8BAZk63ToAAAH/////IAAAABVgiQoCAAAAAQAKAAAAU2VyaWFs" +
           "TnJJbgEB3joALwEAQAneOgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4joA" +
           "LgBE4joAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEB5DoALwEAQAnkOgAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB6DoALgBE6DoAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAV2lkdGgBAeo6AC8BAEAJ6joAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAe46AC4ARO46AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAERh" +
           "dGUBAdg8AC8BAEAJ2DwAAAAM/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdw8AC4A" +
           "RNw8AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAFRpbWUBAd48AC8BAEAJ3jwAAAAM////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeI8AC4AROI8AAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEACwAAAFNlcmlhbE5yT3V0AQH2OgAvAQBACfY6AAAADP////8DA/////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQH6OgAuAET6OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0A" +
           "AABNZWFzdXJlZERyb3BBAQH8OgAvAQBACfw6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQEAOwAuAEQAOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZERy" +
           "b3BCAQECOwAvAQBACQI7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEGOwAu" +
           "AEQGOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZERyb3BDAQEIOwAvAQBA" +
           "CQg7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEMOwAuAEQMOwAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAkAAABEZWx0YURyb3ABAQ47AC8BAEAJDjsAAAAL/////wMD////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARI7AC4ARBI7AAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADQAAAE1lYXN1cmVkV2lkdGgBARQ7AC8BAEAJFDsAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBARg7AC4ARBg7AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEFw" +
           "cHJvdmVkAQEaOwAvAQBACRo7AAAAAf////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEe" +
           "OwAuAEQeOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABSZXRyeQEBkDwALwEAQAmQPAAA" +
           "AAH/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBlDwALgBElDwAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAIAAAAUmVqZWN0ZWQBAZY8AC8BAEAJljwAAAAB/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAZo8AC4ARJo8AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DwAAAE1vdW50T2ZmU2V0VmVydAEBxDsALwEAQAnEOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEByDsALgBEyDsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAAT2Zmc2V0" +
           "TGFzZXJPblByb2QBAco7AC8BAEAJyjsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFu" +
           "Z2UBAc47AC4ARM47AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFRvbGVyYW5jZVdpZHRo" +
           "UGx1cwEB0DsALwEAQAnQOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB1DsA" +
           "LgBE1DsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAAVG9sZXJhbmNlRHJvcFBsdXMBAdY7" +
           "AC8BAEAJ1jsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdo7AC4ARNo7AAAB" +
           "AHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAFRvbGVyYW5jZVdpZHRoTWludXMBAdw7AC8BAEAJ" +
           "3DsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAeA7AC4AROA7AAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFRvbGVyYW5jZURyb3BNaW51cwEB4jsALwEAQAniOwAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB5jsALgBE5jsAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQARAAAAVG9sZXJhbmNlRHJvcERpZmYBAeg7AC8BAEAJ6DsAAAAL/////wMD////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAew7AC4AROw7AAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADwAAAEJvdHRvbUJhclJhZGl1cwEB7jsALwEAQAnuOwAAAAv/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEB8jsALgBE8jsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAMAAAA" +
           "UHJlZk1lYXNEaXN0AQH0OwAvAQBACfQ7AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQH4OwAuAET4OwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABIAAABFbmRjYXBjb21wZW5z" +
           "YXRpb24BAfo7AC8BAEAJ+jsAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAf47" +
           "AC4ARP47AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE1lYXN1cmVEcm9wAQEAPAAvAQBA" +
           "CQA8AAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEEPAAuAEQEPAAAAQB0A///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAwAAABNZWFzdXJlV2lkdGgBAQY8AC8BAEAJBjwAAAAG/////wMD" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQo8AC4ARAo8AAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEQAAAE1lYXN1cmVTcXVhcmVuZXNzAQEMPAAvAQBACQw8AAAABv////8DA/////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQEQPAAuAEQQPAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAgAAABIYXNDb3JkcwEBEjwALwEAQAkSPAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQEBFjwALgBEFjwAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZU1ldGhv" +
           "ZAEBGDwALwEAQAkYPAAAAAb/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBHDwALgBE" +
           "HDwAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAU3RhcnRNZWFzdXJlAQEePAAvAQBACR48" +
           "AAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEiPAAuAEQiPAAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAoAAABIb2lzdFN0YXRlAQG0PAAvAQBACbQ8AAAADP////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQG4PAAuAES4PAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAoAAABIb2lzdEVycm9yAQG6PAAvAQBACbo8AAAABv////8DA/////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQG+PAAuAES+PAAAAQB0A/////8BAf////8AAAAA";
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
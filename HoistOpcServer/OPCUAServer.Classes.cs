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
           "AABJbnB1dEluc3RhbmNlAQGZOgEBmTr/////CwAAABVgiQoCAAAAAQAKAAAAU2VyaWFsTnJJbgEBmjoA" +
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
           "AAAHAAAARVVSYW5nZQEB2joALgBE2joAAAEAdAP/////AQH/////AAAAAA==";
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
           "b2RlAQAIAAAATXkgdGFncy4BAd06AC8BAZk63ToAAAH/////CwAAABVgiQoCAAAAAQAKAAAAU2VyaWFs" +
           "TnJJbgEB3joALwEAQAneOgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4joA" +
           "LgBE4joAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAEAAAARHJvcAEB5DoALwEAQAnkOgAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB6DoALgBE6DoAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAV2lkdGgBAeo6AC8BAEAJ6joAAAAL/////wMD/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAe46AC4ARO46AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAERh" +
           "dGVUaW1lAQHwOgAvAQBACfA6AAAADP////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH0" +
           "OgAuAET0OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABTZXJpYWxOck91dAEB9joALwEA" +
           "QAn2OgAAAAz/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB+joALgBE+joAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQQEB/DoALwEAQAn8OgAAAAv/////" +
           "AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBADsALgBEADsAAAEAdAP/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQANAAAATWVhc3VyZWREcm9wQgEBAjsALwEAQAkCOwAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBBjsALgBEBjsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAN" +
           "AAAATWVhc3VyZWREcm9wQwEBCDsALwEAQAkIOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBDDsALgBEDDsAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAJAAAARGVsdGFEcm9w" +
           "AQEOOwAvAQBACQ47AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQESOwAuAEQS" +
           "OwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABNZWFzdXJlZFdpZHRoAQEUOwAvAQBACRQ7" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEYOwAuAEQYOwAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAgAAABBcHByb3ZlZAEBGjsALwEAQAkaOwAAAAH/////AwP/////AQAA" +
           "ABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBHjsALgBEHjsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the My tags. Object.
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
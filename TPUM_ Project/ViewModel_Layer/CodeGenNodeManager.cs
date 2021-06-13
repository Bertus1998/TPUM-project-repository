//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using System.Xml;
using System.Threading;
using System.Numerics;
using Opc.Ua;
using Opc.Ua.Server;
using System.IO;

namespace CodeGenerated
{
   
    public class CodeGenNodeManager : CustomNodeManager2
    {
        public CodeGenNodeManager(IServerInternal server, ApplicationConfiguration configuration,
                                  string nodesetFilePath, EventHandler addressSpaceCallback)
        : base(server, configuration, Namespaces.URIs.ToArray())
        {
            m_nodesetFilePath      = nodesetFilePath;
            m_addressSpaceCallback = addressSpaceCallback;
            SystemContext.NodeIdFactory = this;

            m_configuration = configuration.ParseExtension<CodeGenServerConfiguration>();

            if (m_configuration == null)
            {
                m_configuration = new CodeGenServerConfiguration();
            }
        }
        
        #region INodeManager Members
        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock(Lock)
            {
                IList<IReference> references = null;

                if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out references))
                {
                    externalReferences[ObjectIds.ObjectsFolder] = references = new List<IReference>();
                }

                m_references = references;
                m_externalReferences = externalReferences;
                m_addressSpaceCallback(this, null); //This is provided from the main class. User code to add nodes to the address space.
                }
        }
        #endregion
        
        #region Public interfaces
        public void AddPredefinedNodeExt(ISystemContext context, NodeState node)
        {
            base.AddPredefinedNode(context, node);
        }
        
        public void AddToReferences(NodeStateReference nodeRef)
        {
            m_references.Add(nodeRef);
        }
                
        public void ImportProjectNodesetXml()
        {
            ImportXml(m_nodesetFilePath);

            // ensure the reverse references exist.
            AddReverseReferences(m_externalReferences);
        }
        
        /// <summary>
        /// Import NodeSets from xml
        /// </summary>
        /// <param name="path">String to path of XML</param>
        public void ImportXml(string resourcepath)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();

            Stream stream = new FileStream(resourcepath, FileMode.Open);
            Opc.Ua.Export.UANodeSet nodeSet = Opc.Ua.Export.UANodeSet.Read(stream);

            /*
            if (nodeSet.NamespaceUris != null)
            {
                foreach (string namespaceUri in nodeSet.NamespaceUris)
                {
                    //SystemContext.NamespaceUris.GetIndexOrAppend(namespaceUri);
                    SystemContext.NamespaceUris.Append(namespaceUri);
                }
            }
            */

            nodeSet.Import(SystemContext, predefinedNodes);

            for (int ii = 0; ii < predefinedNodes.Count; ii++)
            {
                AddPredefinedNode(SystemContext, predefinedNodes[ii]);
            }
        }

        public CodeGenObjectTypeBase CreateObject(
                                    Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                    NodeState parent,
                                    string fileNoExtension,
                                    string name,
                                    string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                    string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                    string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            BaseObjectState obj = new BaseObjectState(parent);

            obj.SymbolicName = name;
            obj.TypeDefinitionId = Helper.CreateID(typeId, typeNamespaceIndex, typeNodeIdType);
            obj.NodeId           = Helper.CreateID(childrenIDMap, this, nodeId, namespaceIndex, nodeIdType);
            obj.BrowseName       = new QualifiedName(name, NamespaceIndex);
            obj.DisplayName      = obj.BrowseName.Name;
            obj.UserWriteMask    = AttributeWriteMask.None;
            obj.EventNotifier    = EventNotifiers.None;

            if (parent != null)
            {
                parent.AddChild(obj);
            }

            CodeGenObjectTypeBase newNode = CodeGenNodeFactory.CreateObject(name, fileNoExtension,
                                                                            typeId, typeNamespaceIndex, typeNodeIdType,
                                                                            nodeId, namespaceIndex, nodeIdType,
                                                                            parentNodeId, parentNamespaceIndex, parentNodeIdType);


            newNode.SetNode(obj);
            newNode.Initialize(childrenIDMap, this);
            return newNode;
        }

        public CodeGenVariableTypeBase CreateVariable(  Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                                        NodeState parent,
                                                        string fileNoExtension,
                                                        string name,
                                                        string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                        string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                        string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType,
                                                        int valueRank)
        {
            BaseDataVariableState variable = new BaseDataVariableState(parent);

            variable.SymbolicName     = name;
            variable.TypeDefinitionId = Helper.CreateID(typeId, typeNamespaceIndex, typeNodeIdType);
            variable.NodeId           = Helper.CreateID(childrenIDMap, this, nodeId, namespaceIndex, nodeIdType);
            //variable.BrowseName       = new QualifiedName(name, NamespaceIndex);
            variable.ValueRank        = valueRank;
            variable.ArrayDimensions  = null;

            //TODO: More code for different types
            if (valueRank == ValueRanks.OneDimension)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0 });
            }
            else if (valueRank == ValueRanks.TwoDimensions)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0, 0 });
            }

            if (parent != null)
                parent.AddChild(variable);

            CodeGenVariableTypeBase newNode = CodeGenNodeFactory.CreateVariable(name, fileNoExtension,
                                                                typeId, typeNamespaceIndex, typeNodeIdType,
                                                                nodeId, namespaceIndex, nodeIdType,
                                                                parentNodeId, parentNamespaceIndex, parentNodeIdType);
            newNode.SetNode(variable);
            newNode.Initialize(childrenIDMap, this);            
            return newNode;
        }
        
        public CodeGenVariableTypeBase CreateProperty(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                                        NodeState parent,
                                                        string fileNoExtension,
                                                        string name,
                                                        string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                        string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                        string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType,
                                                        int valueRank)
        {
            PropertyState property = new PropertyState(parent);

            property.SymbolicName     = name;
            property.ReferenceTypeId  = ReferenceTypes.HasProperty;
            property.TypeDefinitionId = VariableTypeIds.PropertyType;
            property.NodeId           = Helper.CreateID(childrenIDMap, this, nodeId, namespaceIndex, nodeIdType);
            property.ValueRank        = valueRank;
            property.ArrayDimensions  = null;

            //TODO: More code for different types
            if (valueRank == ValueRanks.OneDimension)
            {
                property.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0 });
            }
            else if (valueRank == ValueRanks.TwoDimensions)
            {
                property.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0, 0 });
            }
            
            if (parent != null)
                parent.AddChild(property);
            
            CodeGenVariableTypeBase newNode = CodeGenNodeFactory.CreateVariable(name, fileNoExtension,
                                                                typeId, typeNamespaceIndex, typeNodeIdType,
                                                                nodeId, namespaceIndex, nodeIdType,
                                                                parentNodeId, parentNamespaceIndex, parentNodeIdType);
            newNode.SetNode(property);            
            newNode.IsProperty(true);
            newNode.Initialize(childrenIDMap, this);
            return newNode;
        }
        
        public CodeGenMethodTypeBase CreateMethod(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap, 
                                                    NodeState parent,
                                                    string fileNoExtension,
                                                    string name,
                                                    string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                    string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                    string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            MethodState method = new MethodState(parent);

            method.SymbolicName    = name;
            method.ReferenceTypeId = ReferenceTypeIds.HasComponent;
            method.NodeId          = Helper.CreateID(childrenIDMap, this, nodeId, namespaceIndex, nodeIdType);
            //method.BrowseName      = name;
            //method.DisplayName     = name;
            method.UserWriteMask   = AttributeWriteMask.None;
            method.UserExecutable  = true;

            if (parent != null)
            {
                parent.AddChild(method);
            }

            CodeGenMethodTypeBase newNode = CodeGenNodeFactory.CreateMethod(name, fileNoExtension,
                                                               typeId, typeNamespaceIndex, typeNodeIdType,
                                                               nodeId, namespaceIndex, nodeIdType,
                                                               parentNodeId, parentNamespaceIndex, parentNodeIdType);
            newNode.SetNode(method);
            newNode.Initialize(childrenIDMap, this);

            return newNode;
        }
        #endregion

        #region Private Fields
        private CodeGenServerConfiguration m_configuration;
        private EventHandler m_addressSpaceCallback;
        private string m_nodesetFilePath;
        private IList<IReference> m_references;
        private IDictionary<NodeId, IList<IReference>> m_externalReferences;        
        #endregion
    }
}

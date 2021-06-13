//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System.Collections.Generic;
using System;
using Opc.Ua;

namespace CodeGenerated
{
    public abstract class CodeGenNodeBase
    {
        public CodeGenNodeBase(string browseName,
                        string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                        string nodeId, ushort namespaceIndex, IdType nodeIdType,
                        string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)                           
        {
            //constructor 
            m_browseName            = browseName;
            m_typeId                = typeId;
            m_typeNamespaceIndex    = typeNamespaceIndex;
            m_typeNodeIdType        = typeNodeIdType;
            m_nodeId                = nodeId;
            m_namespaceIndex        = namespaceIndex;
            m_nodeIdType            = nodeIdType;
            m_parentNodeId          = parentNodeId;
            m_parentNamespaceIndex  = parentNamespaceIndex;
            m_parentNodeIdType      = parentNodeIdType;
        }
       
              
        public abstract bool Initialize(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap, CodeGenNodeManager addressSpaceMgr);
        
        #region Protected Fields
        protected string m_browseName;
    
        protected string m_typeId;
        protected ushort m_typeNamespaceIndex;
        protected IdType m_typeNodeIdType;
        
        protected string m_nodeId;
        protected ushort m_namespaceIndex;
        protected IdType m_nodeIdType;
        
        protected string m_parentNodeId;
        protected ushort m_parentNamespaceIndex;
        protected IdType m_parentNodeIdType;

        protected CodeGenNodeManager m_addressSpaceMgr; 

        protected NodeState m_inode;
        #endregion
    }
}

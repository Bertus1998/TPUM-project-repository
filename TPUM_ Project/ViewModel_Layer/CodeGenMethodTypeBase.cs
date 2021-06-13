//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using Opc.Ua;

namespace CodeGenerated
{
    public abstract class CodeGenMethodTypeBase : CodeGenNodeBase
    {
        public CodeGenMethodTypeBase(string browseName,
                                       string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                       string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                       string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
                              : base(browseName, 
                                     typeId, typeNamespaceIndex, typeNodeIdType,
                                     nodeId, namespaceIndex, nodeIdType,
                                     parentNodeId, parentNamespaceIndex, parentNodeIdType)
        {
            //constructor   
        }

        
        public abstract MethodState GetNode();
        public abstract void SetNode(MethodState node);

        #region Protected Fields
        protected MethodState m_node;
        #endregion      
    }
}


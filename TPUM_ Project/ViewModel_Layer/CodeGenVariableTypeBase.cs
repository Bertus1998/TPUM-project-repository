//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using Opc.Ua;

namespace CodeGenerated
{
    public abstract class CodeGenVariableTypeBase : CodeGenNodeBase
    {
        public CodeGenVariableTypeBase(string browseName,
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

        public void IsProperty(bool isProperty)
        {
            m_isProperty = isProperty;
        }

        public bool IsProperty()
        {
            return m_isProperty;
        }
        
        public void SetDataType(string dataTypeId, ushort dataTypeNS, IdType dataTypeNodeIdType)
        {
            this.GetNode().DataType = Helper.CreateID(dataTypeId, dataTypeNS, dataTypeNodeIdType);
        }
        
        public abstract BaseVariableState GetNode();
        public abstract void SetNode(BaseVariableState node);

        #region Protected Fields
        protected BaseVariableState m_node;
        protected bool m_isProperty;
        #endregion      
    }
}


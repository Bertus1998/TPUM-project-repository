//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: Station


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class ObjectType_Station_468461068_0 : CodeGenObjectTypeBase
    {        
        public ObjectType_Station_468461068_0(string browseName,
                               string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                               string nodeId, ushort namespaceIndex, IdType nodeIdType,
                               string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType
                               ) : base(browseName, 
                                        typeId, typeNamespaceIndex, typeNodeIdType,
                                        nodeId, namespaceIndex, nodeIdType,
                                        parentNodeId, parentNamespaceIndex, parentNodeIdType)
        {
            //constructor
        }


        public override bool Initialize(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                        CodeGenNodeManager addressSpaceMgr)
        {
            Console.WriteLine("ObjectType_Station_468461068_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;

            // Set attributes
            this.GetNode().BrowseName  = "Station";
            this.GetNode().DisplayName = "Station";
            this.GetNode().Description = "";
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
                                        
            //Create Children objects
            
            
            //Create Children variables
            
            {
            string childBrowseName = "Name";
    string childFileNoExtension = "type_VariableType_Name_420871476_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "9837";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("ModelStation");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Name_420871476_0 = (VariableType_Name_420871476_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Name_420871476_0 local = var_Name_420871476_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "TargetTemp";
    string childFileNoExtension = "type_VariableType_TargetTemp_1537019957_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "10";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "29520";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("ModelStation");
    ushort childSourceNodeIdType = 0;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_TargetTemp_1537019957_0 = (VariableType_TargetTemp_1537019957_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_TargetTemp_1537019957_0 local = var_TargetTemp_1537019957_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "NowTemp";
    string childFileNoExtension = "type_VariableType_NowTemp_1652098010_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "10";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "16599";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("ModelStation");
    ushort childSourceNodeIdType = 0;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_NowTemp_1652098010_0 = (VariableType_NowTemp_1652098010_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_NowTemp_1652098010_0 local = var_NowTemp_1652098010_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "Heat";
    string childFileNoExtension = "type_VariableType_Heat_2031185702_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "1";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "26810";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("ModelStation");
    ushort childSourceNodeIdType = 0;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Heat_2031185702_0 = (VariableType_Heat_2031185702_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Heat_2031185702_0 local = var_Heat_2031185702_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            
            //Create Children properties
            
            
            //Create Children methods
            
            
            
            return success;
        }

        public override BaseObjectState GetNode()
        {
            return m_node;
        }

        public override void SetNode(BaseObjectState node)
        {
            m_node  = node;
            m_inode = node;
        }
        
        #region Public Fields
        /* Children objects */  
        

            /* Children variables */
            public VariableType_Name_420871476_0 var_Name_420871476_0;
    public VariableType_TargetTemp_1537019957_0 var_TargetTemp_1537019957_0;
    public VariableType_NowTemp_1652098010_0 var_NowTemp_1652098010_0;
    public VariableType_Heat_2031185702_0 var_Heat_2031185702_0;


            /* Children properties */
        

            /* Children methods */
        
        #endregion
    }
}

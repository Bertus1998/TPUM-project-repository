//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: TargetTemp

using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class VariableType_TargetTemp_1537019957_0 : CodeGenVariableTypeBase
    {
        public VariableType_TargetTemp_1537019957_0(string browseName,
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
            Console.WriteLine("VariableType_TargetTemp_1537019957_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0; 
            
            // Set attributes
            this.GetNode().UserWriteMask    = AttributeWriteMask.None;
            this.GetNode().UserAccessLevel  = AccessLevels.CurrentRead;
            this.GetNode().Timestamp        = DateTime.UtcNow;
            this.GetNode().StatusCode       = StatusCodes.Good;
            this.GetNode().OnWriteValue     = CodeGenReadWriteHandler.GetInstance().OnWrite;
            this.GetNode().OnReadValue      = CodeGenReadWriteHandler.GetInstance().OnRead;
            this.GetNode().BrowseName  = "TargetTemp";
            this.GetNode().DisplayName = "TargetTemp";
            this.GetNode().Description = "";
            this.GetNode().Historizing = false;
            this.GetNode().MinimumSamplingInterval = 0;
            this.GetNode().AccessLevel = AccessLevels.None| AccessLevels.CurrentRead;
            this.GetNode().WriteMask   = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
    
            /*********************/
            // Set Default Value
            /*********************/
            bool setDefaultValue    = true;
            string defaultValueStr  = "0.000000";
            string defaultValueType = "Double";
            if (setDefaultValue)
            {
                try
                {
                    if (defaultValueType == "Decimal")
                        this.GetNode().Value = Convert.ToDecimal(defaultValueStr);
                    else if(defaultValueType == "Double")
                        this.GetNode().Value = Convert.ToDouble(defaultValueStr);
                    else if (defaultValueType == "Boolean")
                        this.GetNode().Value = (defaultValueStr == "1");
                    else if(defaultValueType == "SByte")
                        this.GetNode().Value = Convert.ToSByte(defaultValueStr);
                    else if (defaultValueType == "Int16")
                        this.GetNode().Value = Convert.ToInt16(defaultValueStr);
                    else if (defaultValueType == "Int32")
                        this.GetNode().Value = Convert.ToInt32(defaultValueStr);
                    else if (defaultValueType == "Int64")
                        this.GetNode().Value = Convert.ToInt64(defaultValueStr);
                    else if (defaultValueType == "Byte")
                        this.GetNode().Value = Convert.ToByte(defaultValueStr);
                    else if (defaultValueType == "UInt16")
                        this.GetNode().Value = Convert.ToUInt16(defaultValueStr);
                    else if (defaultValueType == "UInt32")
                        this.GetNode().Value = Convert.ToUInt16(defaultValueStr);
                    else if (defaultValueType == "UInt64")
                        this.GetNode().Value = Convert.ToUInt16(defaultValueStr);                    
                    else
                        this.GetNode().Value = defaultValueStr; //Everything else will be set as string.
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error setting node's default value to:{0} error:{1}", defaultValueStr, ex.ToString());
                }
            }
            
            //Create Children variables
            
            
            //Create Children properties
            

            return success;
        }

        public override BaseVariableState GetNode()
        {
            return m_node;
        }

        public override void SetNode(BaseVariableState node)
        {
            m_node  = node;
            m_inode = node;
        }
        #region Public Fields
        /* Children variables */
        
        
        #endregion
    }
}
    

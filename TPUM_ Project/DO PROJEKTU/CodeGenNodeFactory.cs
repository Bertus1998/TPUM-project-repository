//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace CodeGenerated
{
    public class CodeGenNodeFactory
    {
        public static CodeGenObjectTypeBase CreateObject(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_ObjectType_Station_468461068_0")
                return new ObjectType_Station_468461068_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }

        public static CodeGenVariableTypeBase CreateVariable(string szBrowseName,
                                                              string fileNoExtension,
                                                              string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                              string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                              string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            if (fileNoExtension == "type_VariableType_Heat_2031185702_0")
                return new VariableType_Heat_2031185702_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_NowTemp_1652098010_0")
                return new VariableType_NowTemp_1652098010_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_Name_420871476_0")
                return new VariableType_Name_420871476_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            if (fileNoExtension == "type_VariableType_TargetTemp_1537019957_0")
                return new VariableType_TargetTemp_1537019957_0(szBrowseName,
                                    typeId, typeNamespaceIndex, typeNodeIdType,
                                    nodeId, namespaceIndex, nodeIdType,
                                    parentNodeId, parentNamespaceIndex, parentNodeIdType);
        
            
            
            return null;
        }
        
        public static CodeGenMethodTypeBase CreateMethod(string szBrowseName,
                                                          string fileNoExtension,
                                                          string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                                                          string nodeId, ushort namespaceIndex, IdType nodeIdType,
                                                          string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType)
        {
            
            
            return null;
        }       
    }
}

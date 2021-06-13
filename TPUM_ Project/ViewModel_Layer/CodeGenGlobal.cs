//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;

namespace CodeGenerated
{
 
    public static partial class Namespaces
    {
        /// <summary>
        /// The namespace for the nodes provided by the server.
        /// </summary>
        public static List<string> URIs = new List<string>(){"ModelStation"};
    }
    
    public class Helper
    {
        public static NodeId CreateID(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap, CodeGenNodeManager nodeMgr,
                                      object nodeId, ushort namespaceIndex, IdType nodeIdType)
        {
            CodeGenNodeID newNodeID = null;
            CodeGenNodeID sourceNodeID = new CodeGenNodeID(nodeId, namespaceIndex, nodeIdType);
            NodeId newNodeIDToFind = null;

            bool foundInMap = childrenIDMap.TryGetValue(sourceNodeID, out newNodeID);
            if (foundInMap)
            {
                newNodeIDToFind = CreateID(newNodeID.NodeId, namespaceIndex, newNodeID.IDType);
                if (nodeMgr.Find(newNodeIDToFind) != null)
                    throw new Exception("Helper.CreateID from childrenIDMap already exists in the address space.");
            }

            /* If the needed new id is not in the childrenIDMap, create a custom ID with String Type
               by trying first from 1 to whatever is next id non-existent in the address space.
            */
            if (!foundInMap)
            {
                newNodeID = new CodeGenNodeID(0, 0, IdType.String);
                newNodeID.NamespaceIndex = namespaceIndex;


                int numericId = 1;

                do
                {
                    if (nodeIdType != IdType.Numeric)
                        newNodeID.NodeId = (String)nodeId + "_" + Convert.ToString(numericId);
                    else
                        newNodeID.NodeId = Convert.ToString(numericId);

                    newNodeIDToFind = CreateID(newNodeID.NodeId, namespaceIndex, newNodeID.IDType);
                    numericId++;                   
                }
                while (nodeMgr.Find(newNodeIDToFind) != null);
            }

            return CreateID(newNodeID.NodeId, namespaceIndex, newNodeID.IDType);
        }

        public static NodeId CreateID(object nodeId, ushort namespaceIndex, IdType nodeIdType)
        {
            if (nodeIdType == IdType.Numeric)
                return new NodeId(Convert.ToUInt32(nodeId), namespaceIndex);
            else
                return new NodeId((String)nodeId, namespaceIndex);
            //TODO: Add all other ID Types: GUID, etc..
        }
    }

    public class CodeGenNodeID: IEquatable<CodeGenNodeID>
    {
        public CodeGenNodeID(object nodeId, ushort namespaceIndex, IdType nodeIdType)
        {
            this.NodeId = nodeId;
            this.NamespaceIndex = namespaceIndex;
            this.IDType = nodeIdType;
        }
        public bool Equals(CodeGenNodeID other)
        {
            if (   this.NodeId.ToString() == other.NodeId.ToString()
                && this.NamespaceIndex == other.NamespaceIndex
                && this.IDType == other.IDType)
                return true;
            
            return false;
        }
        public override int GetHashCode()
        {
            return this.NodeId.GetHashCode() ^ this.NamespaceIndex.GetHashCode() ^ this.IDType.GetHashCode();
        }

        public object NodeId;
        public ushort NamespaceIndex;
        public IdType IDType;
    }
}

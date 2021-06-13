//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Configuration;

namespace CodeGenerated
{
    static class CodeGenMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType   = ApplicationType.Server;
            application.ConfigSectionName = "CodeGenServer";

            try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // load the application configuration.
                application.LoadApplicationConfiguration(false).Wait();

                // check the application certificate.
                if (!application.CheckApplicationInstanceCertificate(false, 0).Result)
                    throw new Exception("Application instance certificate invalid!");

                ///////////////////////////////////////
                //Sample code for adding referenced companion specification URIs.
                ///////////////////////////////////////
                //Namespaces.URIs.Insert(0, "http://opcfoundation.org/UA/ADI/");
                //Namespaces.URIs.Insert(0, "http://opcfoundation.org/UA/DI/");
                ///////////////////////////////////////  
                

                // start the server.
                CodeGenServer server = new CodeGenServer("project_nodeset.xml", SetupAddressSpace);
                application.Start(server).Wait();
                Console.WriteLine("Starting {0} at the following endpoints:", application.ApplicationName);
                foreach (var ep in server.GetEndpoints())
                {
                    Console.WriteLine("--->  URL: {0}\t\tPOLICY: {1}\tMODE: {2}", ep.EndpointUrl, ep.SecurityPolicyUri.TrimStart("http://opcfoundation.org/UA/SecurityPolicy#".ToCharArray()), ep.SecurityMode.ToString());
                }
                
                Console.WriteLine("Press <ENTER> to Exit...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Application {0} could not start. Error: {1}", application.ApplicationName, e.Message);
                return;
            }
        }
        
        static void SetupAddressSpace(object sender, EventArgs e)
        {
            CodeGenNodeManager mgr = sender as CodeGenNodeManager;

            ///////////////////////////////////////
            //Sample code for adding referenced companion specification nodeset file(s).
            ///////////////////////////////////////
            //mgr.ImportXml("Opc.Ua.Di.NodeSet2.xml");
            ///////////////////////////////////////     
            
            //Load actual project nodeset
            mgr.ImportProjectNodesetXml();
            
            /*
            ///////////////////////////////////////
            //Sample code for instantiating an object. Uncomment the code below.
            ///////////////////////////////////////
            //Opc.Ua.Server.ServerInternalData by default adds the application configuration <ApplicationUri>
            //to the namespace which makes our starting namespace index to 2.
            string fromObjectTypeNodeId         = "29855";          // Node id to instantiate from.
            ushort fromObjectTypeNamespaceIndex = 2;                // Node Id namespace index to instantiate from.
            IdType fromObjectTypeNodeIdType     = IdType.Numeric;   // Node Id Type  to instantiate from.

            string instanceBrowseName       = "myDotNetObjB";
            string instanceDisplayName      = "myDotNetObjD";
            string instanceNodeId           = "myDotNetObjI";
            ushort instanceNamespaceIndex   = 2;
            IdType instanceNodeIdType       = IdType.String;
            
            string parentNodeId             = "85";                 //Objects Folder
            ushort parentNamespaceIndex     = 0;                    //OPC UA namespace
            IdType parentNodeIdType         = IdType.Numeric;
            
            string objectTypeFileNoExtension = "type_ObjectType_MyObjectType_1991378193_0";
            
            Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap = new Dictionary<CodeGenNodeID, CodeGenNodeID>();
            //Uncomment code below to change children's Node ID. Add more in the map for other children.             
            //CodeGenNodeID nodeSource = new CodeGenNodeID("20600", 2, IdType.Numeric);
            //CodeGenNodeID newNodeId  = new CodeGenNodeID("myVarNewIdFromCode", 2, IdType.String);            
            //childrenIDMap.Add(nodeSource, newNodeId);

            CodeGenObjectTypeBase objectBase = mgr.CreateObject(childrenIDMap, null, 
                                                                 objectTypeFileNoExtension, instanceBrowseName,
                                                                 fromObjectTypeNodeId, fromObjectTypeNamespaceIndex, fromObjectTypeNodeIdType,
                                                                 instanceNodeId, instanceNamespaceIndex, parentNodeIdType,
                                                                 parentNodeId, parentNamespaceIndex, instanceNodeIdType
                                                                );
            ObjectType_MyObjectType_1991378193_0 obj = objectBase as ObjectType_MyObjectType_1991378193_0;
            obj.GetNode().DisplayName = instanceDisplayName;
            mgr.AddToReferences(new NodeStateReference(ReferenceTypes.Organizes, false, obj.GetNode().NodeId));
            mgr.AddPredefinedNodeExt(mgr.SystemContext, obj.GetNode());

            //Sample code to change the browse name of the child. Children are accessible directly from their parent.
            //obj.obj_MyObjectChild_obj1_1697828377_0.GetNode().BrowseName = "NewBrowseNameFromCode";
            */
        }
    }
}

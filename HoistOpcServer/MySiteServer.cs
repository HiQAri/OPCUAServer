using Opc.Ua;
using Opc.Ua.Server;
using System.Collections.Generic;

namespace OPCUAServer
{
    class MySiteServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating Node Manager");
            List<INodeManager> nodeManagers = new List<INodeManager>();
            nodeManagers.Add(new MySiteNodeManager(server, configuration));
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();
            properties.ManufacturerName = "MySiteServer";
            properties.ProductName = "MySite informationmodel server";
            properties.ProductUri = "http://opcfundation.org/MySite/InformationModelServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();
            return properties;
        }
    }
}

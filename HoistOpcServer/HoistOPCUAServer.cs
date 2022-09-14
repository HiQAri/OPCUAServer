using HoistOpcServer;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCUAServer
{
    public class HoistOPCUAServer : IDisposable
    {
        private bool isDisposed;
        private ApplicationInstance application;
        private StandardServer server;
        private ApplicationConfiguration configuration;

        private List<string> endpoints = new List<string>();

        public void Initialize()
        {
            application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "MySite";

            string path = AppDomain.CurrentDomain.BaseDirectory + "OPCUAServer.Config.xml";
            application.LoadApplicationConfiguration(path, false).Wait();
            application.CheckApplicationInstanceCertificate(false, 0).Wait();

            application.Start(new MySiteServer()).Wait();

            server = application.Server as StandardServer;
            configuration = application.ApplicationConfiguration;

            foreach (EndpointDescription endpoint in server.GetEndpoints())
            {
                if (!endpoints.Contains(endpoint.EndpointUrl))
                {
                    endpoints.Add(endpoint.EndpointUrl);
                }
            }

            Signals = new AllSignals(server);
        }

        public AllSignals Signals { get; set; }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (isDisposed)
                return;

            if (disposing)
            {
                application?.Stop();
            }

            isDisposed = true;
        }

    }
}

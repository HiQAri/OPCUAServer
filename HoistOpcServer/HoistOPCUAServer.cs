using HoistOpcServer;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;

namespace OPCUAServer
{
    /// <summary>
    /// <c>HoistOPCUAServer</c> is intended to be used as entry point when this assembly is loaded as a dll.
    /// The server is started in <see cref="Initialize"/>
    /// </summary>
    public class HoistOPCUAServer : IDisposable
    {
        private bool isDisposed;
        private ApplicationInstance application;
        private StandardServer server;
        private ApplicationConfiguration configuration;

        private List<string> endpoints = new List<string>();

        /// <summary>
        /// Initializes and start the server
        /// </summary>
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

        /// <summary>
        /// Access to all exposed Tags in the server for easy use by calling assembly
        /// </summary>
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

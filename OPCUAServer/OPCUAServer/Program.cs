using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace OPCUAServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            string path = AppDomain.CurrentDomain.BaseDirectory + "OPCUAServer.Config.xml";

            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "MySite";
            application.LoadApplicationConfiguration(path, false).Wait();
            application.CheckApplicationInstanceCertificate(false, 0).Wait();


        }
    }
}

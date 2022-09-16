using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;
using OPCUAServer;

namespace HoistOpcServer
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

            try
            {
                if (application.ProcessCommandLine())
                {
                    return;
                }

                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new MySiteServer());
                    return;
                }


                application.LoadApplicationConfiguration(path, false).Wait();
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                application.Start(new MySiteServer()).Wait();

                Application.Run(new Form1(application));
            }
            catch (Exception ex)
            {
                string MessageText = "Exception: " + ex.Message;
                if (ex.InnerException != null)
                {
                    MessageText += "\r\nInner exception: ";
                    MessageText += ex.InnerException.Message;
                }
                MessageBox.Show(MessageText, application.ApplicationName);
            }
        }
    }
}

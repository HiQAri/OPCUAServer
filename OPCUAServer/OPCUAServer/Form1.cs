using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCUAServer
{
    public partial class Form1 : Form
    {
        private ApplicationInstance mysite_application;
        private StandardServer mysite_server;
        private ApplicationConfiguration mysite_configuration;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(ApplicationInstance application)
        {
            InitializeComponent();
            mysite_application = application;
            mysite_server = application.Server as StandardServer;
            mysite_configuration = application.ApplicationConfiguration;

            comboBoxNodes.Items.Clear();

            foreach (EndpointDescription endpoint in mysite_server.GetEndpoints())
            {
                if (comboBoxNodes.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    comboBoxNodes.Items.Add(endpoint.EndpointUrl);
                }
            }
            if (comboBoxNodes.Items.Count>0)
            {
                comboBoxNodes.SelectedIndex = 0;
            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

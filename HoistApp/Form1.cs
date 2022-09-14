using OPCUAServer;
using System;
using System.Windows.Forms;

namespace HoistApp
{
    public partial class Form1 : Form
    {
        private HoistOPCUAServer server;

        public Form1()
        {
            InitializeComponent();
            server = new HoistOPCUAServer();
            server.Initialize();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            server?.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server?.Signals.DropB();
        }
    }
}

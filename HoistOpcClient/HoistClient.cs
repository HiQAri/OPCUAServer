using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Client.Controls;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoistOpcClient
{
    public class HoistClient : IDisposable
    {
        private ConnectServerCtrl connectServerCtrl1;
        private bool isdisposed;
        private Session session;
        private bool connectedOnce;
        private Subscription subscription;

        public void Initialize()
        {
            connectServerCtrl1 = new ConnectServerCtrl();
            this.connectServerCtrl1.Configuration = null;
            this.connectServerCtrl1.DisableDomainCheck = false;
            this.connectServerCtrl1.DiscoverTimeout = 15000;
            //this.connectServerCtrl1.Location = new System.Drawing.Point(12, 22);
            //this.connectServerCtrl1.MaximumSize = new System.Drawing.Size(2048, 23);
            //this.connectServerCtrl1.MinimumSize = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.Name = "connectServerCtrl1";
            this.connectServerCtrl1.PreferredLocales = null;
            this.connectServerCtrl1.ReconnectPeriod = 10;
            this.connectServerCtrl1.ServerUrl = "";
            this.connectServerCtrl1.SessionName = "TestSession1";
            this.connectServerCtrl1.SessionTimeout = ((uint)(60000u));
            //this.connectServerCtrl1.Size = new System.Drawing.Size(500, 23);
            //this.connectServerCtrl1.StatusStrip = this.statusStrip1;
            this.connectServerCtrl1.TabIndex = 0;
            this.connectServerCtrl1.UserIdentity = null;
            this.connectServerCtrl1.UseSecurity = true;
            this.connectServerCtrl1.ConnectComplete += new System.EventHandler(this.connectServerCtrl1_ConnectComplete);


            connectServerCtrl1.ServerUrl = "opc.tcp://localhost:26543/OPCUAServer";
            var config = new ApplicationConfiguration()
            {
                ApplicationName = "MyClient",
                ApplicationUri = Utils.Format(@"urn:{0}:MyClient", System.Net.Dns.GetHostName()),
                ApplicationType = ApplicationType.Client,
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault",
                        SubjectName = "BatchPlantClient2"
                    },
                    TrustedIssuerCertificates = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities"
                    },
                    TrustedPeerCertificates = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications"
                    },
                    RejectedCertificateStore = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates"
                    },
                    AutoAcceptUntrustedCertificates = true,
                    AddAppCertToTrustedStore = false,
                    RejectSHA1SignedCertificates = false
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                TraceConfiguration = new TraceConfiguration()
            };

            config.Validate(ApplicationType.Client).GetAwaiter().GetResult();
            if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += (s, x) => { x.Accept = (x.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
            }
            this.connectServerCtrl1.Configuration = config;
            this.connectServerCtrl1.UserIdentity = new UserIdentity(); //"User","Pass"
            this.connectServerCtrl1.UseSecurity = true;

            var application = new ApplicationInstance
            {
                ApplicationName = "MySiteClient",
                ApplicationType = ApplicationType.Client,
                ApplicationConfiguration = config
            };
            Opc.Ua.Utils.SetTraceMask(0);
            application.CheckApplicationInstanceCertificate(true, 2048).GetAwaiter().GetResult();

            this.connectServerCtrl1.Connect().Wait();


        }

        private void connectServerCtrl1_ConnectComplete(object sender, EventArgs e)
        {
            try
            {
                session = connectServerCtrl1.Session;

                if (session != null && !connectedOnce)
                {
                    connectedOnce = true;
                    CreateSubscriptionAndMonitorItem();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPC Exception: " + ex.ToString());
                //ClientUtils.HandleException(this.Text, ex);
            }
        }


        private void CreateSubscriptionAndMonitorItem()
        {
            try
            {
                if (session == null)
                {
                    return;
                }
                if (subscription != null)
                {
                    session.RemoveSubscription(subscription);
                    subscription = null;
                }
                subscription = new Subscription();
                subscription.PublishingEnabled = true;
                subscription.PublishingInterval = 1000;
                subscription.Priority = 1;
                subscription.KeepAliveCount = 10;
                subscription.LifetimeCount = 20;
                subscription.MaxNotificationsPerPublish = 1000;

                session.AddSubscription(subscription);
                subscription.Create();

                MonitoredItem monitoredItem = new MonitoredItem();
                monitoredItem.StartNodeId = new NodeId("ns=2;i=15156"); //DateTime tag
                monitoredItem.AttributeId = Attributes.Value;
                monitoredItem.Notification += MonitoredItem_Notification;
                subscription.AddItem(monitoredItem);
                subscription.ApplyChanges();




            }
            catch (Exception ex)
            {
                //ClientUtils.HandleException(this.Text, ex);
            }
        }

        private void MonitoredItem_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            Console.WriteLine("OPC: " + ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString());
            //if (InvokeRequired)
            //{
            //    BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem_Notification), monitoredItem, e);
            //    return;
            //}
            //this.lblDateTime.Text = ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString();


            //throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
        }
        public void Dispose(bool disposing)
        {
            if (isdisposed)
                return;

            if (disposing)
            {
                this.connectServerCtrl1?.Disconnect();
            }

            isdisposed = true;
        }


    }
}

﻿using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Client.Controls;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Session session;
        private bool connectedOnce;
        private Subscription subscription;

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
                ClientUtils.HandleException(this.Text, ex);
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
                ClientUtils.HandleException(this.Text, ex);
            }
        }

        private void MonitoredItem_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MonitoredItemNotificationEventHandler(MonitoredItem_Notification), monitoredItem, e);
                return;
            }
            this.lblDateTime.Text = ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString();


            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.connectServerCtrl1.ServerUrl = "opc.tcp://hiqarbl344:26543/OPCUAServer";
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
                        SubjectName = "BatchPlantClient"
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


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.connectServerCtrl1.Disconnect();
        }
    }
}

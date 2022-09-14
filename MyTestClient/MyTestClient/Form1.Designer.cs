namespace MyTestClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectServerCtrl1 = new Opc.Ua.Client.Controls.ConnectServerCtrl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxWriteToTag = new System.Windows.Forms.TextBox();
            this.btnWriteToTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectServerCtrl1
            // 
            this.connectServerCtrl1.Configuration = null;
            this.connectServerCtrl1.DisableDomainCheck = false;
            this.connectServerCtrl1.DiscoverTimeout = 15000;
            this.connectServerCtrl1.Location = new System.Drawing.Point(12, 22);
            this.connectServerCtrl1.MaximumSize = new System.Drawing.Size(2048, 23);
            this.connectServerCtrl1.MinimumSize = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.Name = "connectServerCtrl1";
            this.connectServerCtrl1.PreferredLocales = null;
            this.connectServerCtrl1.ReconnectPeriod = 10;
            this.connectServerCtrl1.ServerUrl = "";
            this.connectServerCtrl1.SessionName = "TestSession1";
            this.connectServerCtrl1.SessionTimeout = ((uint)(60000u));
            this.connectServerCtrl1.Size = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.StatusStrip = this.statusStrip1;
            this.connectServerCtrl1.TabIndex = 0;
            this.connectServerCtrl1.UserIdentity = null;
            this.connectServerCtrl1.UseSecurity = true;
            this.connectServerCtrl1.ConnectComplete += new System.EventHandler(this.connectServerCtrl1_ConnectComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 131);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(103, 93);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(70, 13);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "testDateTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DateTime tag:";
            // 
            // txtBoxWriteToTag
            // 
            this.txtBoxWriteToTag.Location = new System.Drawing.Point(222, 89);
            this.txtBoxWriteToTag.Name = "txtBoxWriteToTag";
            this.txtBoxWriteToTag.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWriteToTag.TabIndex = 4;
            // 
            // btnWriteToTag
            // 
            this.btnWriteToTag.Location = new System.Drawing.Point(328, 88);
            this.btnWriteToTag.Name = "btnWriteToTag";
            this.btnWriteToTag.Size = new System.Drawing.Size(75, 23);
            this.btnWriteToTag.TabIndex = 5;
            this.btnWriteToTag.Text = "Write to tag";
            this.btnWriteToTag.UseVisualStyleBackColor = true;
            this.btnWriteToTag.Click += new System.EventHandler(this.btnWriteToTag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 153);
            this.Controls.Add(this.btnWriteToTag);
            this.Controls.Add(this.txtBoxWriteToTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connectServerCtrl1);
            this.Name = "Form1";
            this.Text = "OPC UA Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Opc.Ua.Client.Controls.ConnectServerCtrl connectServerCtrl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxWriteToTag;
        private System.Windows.Forms.Button btnWriteToTag;
    }
}


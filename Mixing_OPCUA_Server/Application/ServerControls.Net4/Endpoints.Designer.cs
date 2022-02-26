
namespace Opc.Ua.Server.Controls
{
    partial class Endpoints
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBasic256SHA256bis = new System.Windows.Forms.CheckBox();
            this.cbBasic128RSA15bis = new System.Windows.Forms.CheckBox();
            this.gbPoliciesSignAndEncypt = new System.Windows.Forms.GroupBox();
            this.cbBasic256bis = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPoliciesSign = new System.Windows.Forms.GroupBox();
            this.cbBasic256SHA256 = new System.Windows.Forms.CheckBox();
            this.cbBasic256 = new System.Windows.Forms.CheckBox();
            this.cbBasic128RSA15 = new System.Windows.Forms.CheckBox();
            this.btnApplySetting = new System.Windows.Forms.Button();
            this.cbUAHTTPSSign = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUAHTTPSNone = new System.Windows.Forms.CheckBox();
            this.cbUATCPSignAndEncypt = new System.Windows.Forms.CheckBox();
            this.cbUATCPSign = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUATCPNone = new System.Windows.Forms.CheckBox();
            this.tbUAHTTPS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUATCP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHTTPS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUATCP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSignEncyptAes128Sha256RsaOaep = new System.Windows.Forms.CheckBox();
            this.cbSignEncyptAes128Sha256RsaPss = new System.Windows.Forms.CheckBox();
            this.cbSignAes128Sha256RsaOaep = new System.Windows.Forms.CheckBox();
            this.cbSignAes128Sha256RsaPss = new System.Windows.Forms.CheckBox();
            this.gbPoliciesSignAndEncypt.SuspendLayout();
            this.gbPoliciesSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBasic256SHA256bis
            // 
            this.cbBasic256SHA256bis.AutoSize = true;
            this.cbBasic256SHA256bis.Location = new System.Drawing.Point(36, 125);
            this.cbBasic256SHA256bis.Name = "cbBasic256SHA256bis";
            this.cbBasic256SHA256bis.Size = new System.Drawing.Size(176, 26);
            this.cbBasic256SHA256bis.TabIndex = 24;
            this.cbBasic256SHA256bis.Text = "Basic256SHA256";
            this.cbBasic256SHA256bis.UseVisualStyleBackColor = true;
            // 
            // cbBasic128RSA15bis
            // 
            this.cbBasic128RSA15bis.AutoSize = true;
            this.cbBasic128RSA15bis.Location = new System.Drawing.Point(36, 29);
            this.cbBasic128RSA15bis.Name = "cbBasic128RSA15bis";
            this.cbBasic128RSA15bis.Size = new System.Drawing.Size(165, 26);
            this.cbBasic128RSA15bis.TabIndex = 22;
            this.cbBasic128RSA15bis.Text = "Basic128RSA15";
            this.cbBasic128RSA15bis.UseVisualStyleBackColor = true;
            // 
            // gbPoliciesSignAndEncypt
            // 
            this.gbPoliciesSignAndEncypt.Controls.Add(this.cbSignEncyptAes128Sha256RsaPss);
            this.gbPoliciesSignAndEncypt.Controls.Add(this.cbSignEncyptAes128Sha256RsaOaep);
            this.gbPoliciesSignAndEncypt.Controls.Add(this.cbBasic256SHA256bis);
            this.gbPoliciesSignAndEncypt.Controls.Add(this.cbBasic256bis);
            this.gbPoliciesSignAndEncypt.Controls.Add(this.cbBasic128RSA15bis);
            this.gbPoliciesSignAndEncypt.Location = new System.Drawing.Point(698, 186);
            this.gbPoliciesSignAndEncypt.Name = "gbPoliciesSignAndEncypt";
            this.gbPoliciesSignAndEncypt.Size = new System.Drawing.Size(295, 282);
            this.gbPoliciesSignAndEncypt.TabIndex = 47;
            this.gbPoliciesSignAndEncypt.TabStop = false;
            this.gbPoliciesSignAndEncypt.Text = "Security Policies";
            // 
            // cbBasic256bis
            // 
            this.cbBasic256bis.AutoSize = true;
            this.cbBasic256bis.Location = new System.Drawing.Point(36, 77);
            this.cbBasic256bis.Name = "cbBasic256bis";
            this.cbBasic256bis.Size = new System.Drawing.Size(107, 26);
            this.cbBasic256bis.TabIndex = 23;
            this.cbBasic256bis.Text = "Basic256";
            this.cbBasic256bis.UseVisualStyleBackColor = true;
            // 
            // gbPoliciesSign
            // 
            this.gbPoliciesSign.Controls.Add(this.cbSignAes128Sha256RsaPss);
            this.gbPoliciesSign.Controls.Add(this.cbSignAes128Sha256RsaOaep);
            this.gbPoliciesSign.Controls.Add(this.cbBasic256SHA256);
            this.gbPoliciesSign.Controls.Add(this.cbBasic256);
            this.gbPoliciesSign.Controls.Add(this.cbBasic128RSA15);
            this.gbPoliciesSign.Location = new System.Drawing.Point(385, 186);
            this.gbPoliciesSign.Name = "gbPoliciesSign";
            this.gbPoliciesSign.Size = new System.Drawing.Size(278, 282);
            this.gbPoliciesSign.TabIndex = 46;
            this.gbPoliciesSign.TabStop = false;
            this.gbPoliciesSign.Text = "Security Policies";
            // 
            // cbBasic256SHA256
            // 
            this.cbBasic256SHA256.AutoSize = true;
            this.cbBasic256SHA256.Location = new System.Drawing.Point(36, 125);
            this.cbBasic256SHA256.Name = "cbBasic256SHA256";
            this.cbBasic256SHA256.Size = new System.Drawing.Size(176, 26);
            this.cbBasic256SHA256.TabIndex = 24;
            this.cbBasic256SHA256.Text = "Basic256SHA256";
            this.cbBasic256SHA256.UseVisualStyleBackColor = true;
            // 
            // cbBasic256
            // 
            this.cbBasic256.AutoSize = true;
            this.cbBasic256.Location = new System.Drawing.Point(37, 77);
            this.cbBasic256.Name = "cbBasic256";
            this.cbBasic256.Size = new System.Drawing.Size(107, 26);
            this.cbBasic256.TabIndex = 23;
            this.cbBasic256.Text = "Basic256";
            this.cbBasic256.UseVisualStyleBackColor = true;
            // 
            // cbBasic128RSA15
            // 
            this.cbBasic128RSA15.AutoSize = true;
            this.cbBasic128RSA15.Location = new System.Drawing.Point(36, 29);
            this.cbBasic128RSA15.Name = "cbBasic128RSA15";
            this.cbBasic128RSA15.Size = new System.Drawing.Size(165, 26);
            this.cbBasic128RSA15.TabIndex = 22;
            this.cbBasic128RSA15.Text = "Basic128RSA15";
            this.cbBasic128RSA15.UseVisualStyleBackColor = true;
            // 
            // btnApplySetting
            // 
            this.btnApplySetting.Location = new System.Drawing.Point(81, 643);
            this.btnApplySetting.Name = "btnApplySetting";
            this.btnApplySetting.Size = new System.Drawing.Size(218, 39);
            this.btnApplySetting.TabIndex = 45;
            this.btnApplySetting.Text = "APPLY SETTINGS";
            this.btnApplySetting.UseVisualStyleBackColor = true;
            this.btnApplySetting.Click += new System.EventHandler(this.btnApplySetting_Click);
            // 
            // cbUAHTTPSSign
            // 
            this.cbUAHTTPSSign.AutoSize = true;
            this.cbUAHTTPSSign.Location = new System.Drawing.Point(462, 568);
            this.cbUAHTTPSSign.Name = "cbUAHTTPSSign";
            this.cbUAHTTPSSign.Size = new System.Drawing.Size(67, 26);
            this.cbUAHTTPSSign.TabIndex = 44;
            this.cbUAHTTPSSign.Text = "Sign";
            this.cbUAHTTPSSign.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Security Mode";
            // 
            // cbUAHTTPSNone
            // 
            this.cbUAHTTPSNone.AutoSize = true;
            this.cbUAHTTPSNone.Location = new System.Drawing.Point(277, 569);
            this.cbUAHTTPSNone.Name = "cbUAHTTPSNone";
            this.cbUAHTTPSNone.Size = new System.Drawing.Size(74, 26);
            this.cbUAHTTPSNone.TabIndex = 42;
            this.cbUAHTTPSNone.Text = "None";
            this.cbUAHTTPSNone.UseVisualStyleBackColor = true;
            // 
            // cbUATCPSignAndEncypt
            // 
            this.cbUATCPSignAndEncypt.AutoSize = true;
            this.cbUATCPSignAndEncypt.Location = new System.Drawing.Point(734, 138);
            this.cbUATCPSignAndEncypt.Name = "cbUATCPSignAndEncypt";
            this.cbUATCPSignAndEncypt.Size = new System.Drawing.Size(154, 26);
            this.cbUATCPSignAndEncypt.TabIndex = 41;
            this.cbUATCPSignAndEncypt.Text = "SignAndEncypt";
            this.cbUATCPSignAndEncypt.UseVisualStyleBackColor = true;
            this.cbUATCPSignAndEncypt.CheckedChanged += new System.EventHandler(this.cbUATCPSignAndEncypt_CheckedChanged);
            // 
            // cbUATCPSign
            // 
            this.cbUATCPSign.AutoSize = true;
            this.cbUATCPSign.Location = new System.Drawing.Point(461, 138);
            this.cbUATCPSign.Name = "cbUATCPSign";
            this.cbUATCPSign.Size = new System.Drawing.Size(67, 26);
            this.cbUATCPSign.TabIndex = 40;
            this.cbUATCPSign.Text = "Sign";
            this.cbUATCPSign.UseVisualStyleBackColor = true;
            this.cbUATCPSign.CheckedChanged += new System.EventHandler(this.cbUATCPSign_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "Security Mode";
            // 
            // cbUATCPNone
            // 
            this.cbUATCPNone.AutoSize = true;
            this.cbUATCPNone.Location = new System.Drawing.Point(276, 138);
            this.cbUATCPNone.Name = "cbUATCPNone";
            this.cbUATCPNone.Size = new System.Drawing.Size(74, 26);
            this.cbUATCPNone.TabIndex = 38;
            this.cbUATCPNone.Text = "None";
            this.cbUATCPNone.UseVisualStyleBackColor = true;
            // 
            // tbUAHTTPS
            // 
            this.tbUAHTTPS.Location = new System.Drawing.Point(224, 518);
            this.tbUAHTTPS.Name = "tbUAHTTPS";
            this.tbUAHTTPS.Size = new System.Drawing.Size(375, 30);
            this.tbUAHTTPS.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Server Address: ";
            // 
            // tbUATCP
            // 
            this.tbUATCP.Location = new System.Drawing.Point(224, 84);
            this.tbUATCP.Name = "tbUATCP";
            this.tbUATCP.Size = new System.Drawing.Size(375, 30);
            this.tbUATCP.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Server Address: ";
            // 
            // lbHTTPS
            // 
            this.lbHTTPS.AutoSize = true;
            this.lbHTTPS.Location = new System.Drawing.Point(198, 486);
            this.lbHTTPS.Name = "lbHTTPS";
            this.lbHTTPS.Size = new System.Drawing.Size(101, 22);
            this.lbHTTPS.TabIndex = 33;
            this.lbHTTPS.Text = "UA HTTPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "UA HTTPS :";
            // 
            // lbUATCP
            // 
            this.lbUATCP.AutoSize = true;
            this.lbUATCP.Location = new System.Drawing.Point(198, 50);
            this.lbUATCP.Name = "lbUATCP";
            this.lbUATCP.Size = new System.Drawing.Size(77, 22);
            this.lbUATCP.TabIndex = 31;
            this.lbUATCP.Text = "UA TCP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "UA TCP :";
            // 
            // cbSignEncyptAes128Sha256RsaOaep
            // 
            this.cbSignEncyptAes128Sha256RsaOaep.AutoSize = true;
            this.cbSignEncyptAes128Sha256RsaOaep.Location = new System.Drawing.Point(36, 179);
            this.cbSignEncyptAes128Sha256RsaOaep.Name = "cbSignEncyptAes128Sha256RsaOaep";
            this.cbSignEncyptAes128Sha256RsaOaep.Size = new System.Drawing.Size(224, 26);
            this.cbSignEncyptAes128Sha256RsaOaep.TabIndex = 25;
            this.cbSignEncyptAes128Sha256RsaOaep.Text = "Aes128Sha256RsaOaep";
            this.cbSignEncyptAes128Sha256RsaOaep.UseVisualStyleBackColor = true;
            // 
            // cbSignEncyptAes128Sha256RsaPss
            // 
            this.cbSignEncyptAes128Sha256RsaPss.AutoSize = true;
            this.cbSignEncyptAes128Sha256RsaPss.Location = new System.Drawing.Point(36, 240);
            this.cbSignEncyptAes128Sha256RsaPss.Name = "cbSignEncyptAes128Sha256RsaPss";
            this.cbSignEncyptAes128Sha256RsaPss.Size = new System.Drawing.Size(209, 26);
            this.cbSignEncyptAes128Sha256RsaPss.TabIndex = 26;
            this.cbSignEncyptAes128Sha256RsaPss.Text = "Aes128Sha256RsaPss";
            this.cbSignEncyptAes128Sha256RsaPss.UseVisualStyleBackColor = true;
            // 
            // cbSignAes128Sha256RsaOaep
            // 
            this.cbSignAes128Sha256RsaOaep.AutoSize = true;
            this.cbSignAes128Sha256RsaOaep.Location = new System.Drawing.Point(37, 179);
            this.cbSignAes128Sha256RsaOaep.Name = "cbSignAes128Sha256RsaOaep";
            this.cbSignAes128Sha256RsaOaep.Size = new System.Drawing.Size(224, 26);
            this.cbSignAes128Sha256RsaOaep.TabIndex = 25;
            this.cbSignAes128Sha256RsaOaep.Text = "Aes128Sha256RsaOaep";
            this.cbSignAes128Sha256RsaOaep.UseVisualStyleBackColor = true;
            // 
            // cbSignAes128Sha256RsaPss
            // 
            this.cbSignAes128Sha256RsaPss.AutoSize = true;
            this.cbSignAes128Sha256RsaPss.Location = new System.Drawing.Point(36, 240);
            this.cbSignAes128Sha256RsaPss.Name = "cbSignAes128Sha256RsaPss";
            this.cbSignAes128Sha256RsaPss.Size = new System.Drawing.Size(209, 26);
            this.cbSignAes128Sha256RsaPss.TabIndex = 26;
            this.cbSignAes128Sha256RsaPss.Text = "Aes128Sha256RsaPss";
            this.cbSignAes128Sha256RsaPss.UseVisualStyleBackColor = true;
            // 
            // Endpoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPoliciesSignAndEncypt);
            this.Controls.Add(this.gbPoliciesSign);
            this.Controls.Add(this.btnApplySetting);
            this.Controls.Add(this.cbUAHTTPSSign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUAHTTPSNone);
            this.Controls.Add(this.cbUATCPSignAndEncypt);
            this.Controls.Add(this.cbUATCPSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUATCPNone);
            this.Controls.Add(this.tbUAHTTPS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUATCP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHTTPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUATCP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Endpoints";
            this.Size = new System.Drawing.Size(1021, 722);
            this.gbPoliciesSignAndEncypt.ResumeLayout(false);
            this.gbPoliciesSignAndEncypt.PerformLayout();
            this.gbPoliciesSign.ResumeLayout(false);
            this.gbPoliciesSign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbBasic256SHA256bis;
        private System.Windows.Forms.CheckBox cbBasic128RSA15bis;
        private System.Windows.Forms.GroupBox gbPoliciesSignAndEncypt;
        private System.Windows.Forms.CheckBox cbBasic256bis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbPoliciesSign;
        private System.Windows.Forms.CheckBox cbBasic256SHA256;
        private System.Windows.Forms.CheckBox cbBasic256;
        private System.Windows.Forms.CheckBox cbBasic128RSA15;
        private System.Windows.Forms.Button btnApplySetting;
        private System.Windows.Forms.CheckBox cbUAHTTPSSign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUAHTTPSNone;
        private System.Windows.Forms.CheckBox cbUATCPSignAndEncypt;
        private System.Windows.Forms.CheckBox cbUATCPSign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbUATCPNone;
        private System.Windows.Forms.TextBox tbUAHTTPS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUATCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHTTPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUATCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSignEncyptAes128Sha256RsaPss;
        private System.Windows.Forms.CheckBox cbSignEncyptAes128Sha256RsaOaep;
        private System.Windows.Forms.CheckBox cbSignAes128Sha256RsaPss;
        private System.Windows.Forms.CheckBox cbSignAes128Sha256RsaOaep;
    }
}

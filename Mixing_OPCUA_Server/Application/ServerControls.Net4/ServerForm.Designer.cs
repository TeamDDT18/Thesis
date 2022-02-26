/* ========================================================================
 * Copyright (c) 2005-2020 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using Opc.Ua.Server.Controls;

namespace Opc.Ua.Server.Controls
{
    partial class ServerForm 
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
            this.components = new System.ComponentModel.Container();
            this.statusBAR = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerStateLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerTimeLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sessionsLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.subscriptionsLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemsLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpdateTimerCTRL = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.a = new System.Windows.Forms.TabPage();
            this.HOME = new Opc.Ua.Server.Controls.Home();
            this.s = new System.Windows.Forms.TabPage();
            this.ENDPOINTS = new Opc.Ua.Server.Controls.Endpoints();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SEESION = new Opc.Ua.Server.Controls.Seesion();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CERTIFICATION = new Opc.Ua.Server.Controls.Certification();
            this.statusBAR.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.a.SuspendLayout();
            this.s.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBAR
            // 
            this.statusBAR.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBAR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ServerStateLB,
            this.toolStripStatusLabel2,
            this.ServerTimeLB,
            this.toolStripStatusLabel3,
            this.sessionsLB,
            this.toolStripStatusLabel4,
            this.subscriptionsLB,
            this.toolStripStatusLabel5,
            this.itemsLB});
            this.statusBAR.Location = new System.Drawing.Point(0, 727);
            this.statusBAR.Name = "statusBAR";
            this.statusBAR.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBAR.Size = new System.Drawing.Size(1272, 26);
            this.statusBAR.TabIndex = 1;
            this.statusBAR.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // ServerStateLB
            // 
            this.ServerStateLB.Name = "ServerStateLB";
            this.ServerStateLB.Size = new System.Drawing.Size(63, 20);
            this.ServerStateLB.Text = "Running";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel2.Text = "Current Time:";
            // 
            // ServerTimeLB
            // 
            this.ServerTimeLB.Name = "ServerTimeLB";
            this.ServerTimeLB.Size = new System.Drawing.Size(63, 20);
            this.ServerTimeLB.Text = "00:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 20);
            this.toolStripStatusLabel3.Text = "Session:";
            // 
            // sessionsLB
            // 
            this.sessionsLB.Name = "sessionsLB";
            this.sessionsLB.Size = new System.Drawing.Size(17, 20);
            this.sessionsLB.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(93, 20);
            this.toolStripStatusLabel4.Text = "Subcription:";
            // 
            // subscriptionsLB
            // 
            this.subscriptionsLB.Name = "subscriptionsLB";
            this.subscriptionsLB.Size = new System.Drawing.Size(17, 20);
            this.subscriptionsLB.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(53, 20);
            this.toolStripStatusLabel5.Text = "Items:";
            // 
            // itemsLB
            // 
            this.itemsLB.Name = "itemsLB";
            this.itemsLB.Size = new System.Drawing.Size(17, 20);
            this.itemsLB.Text = "0";
            // 
            // UpdateTimerCTRL
            // 
            this.UpdateTimerCTRL.Interval = 1000;
            this.UpdateTimerCTRL.Tick += new System.EventHandler(this.UpdateTimerCTRL_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.a);
            this.tabControl1.Controls.Add(this.s);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 700);
            this.tabControl1.TabIndex = 2;
            // 
            // a
            // 
            this.a.Controls.Add(this.HOME);
            this.a.Location = new System.Drawing.Point(4, 31);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(3);
            this.a.Size = new System.Drawing.Size(1252, 665);
            this.a.TabIndex = 0;
            this.a.Text = "HOME";
            this.a.UseVisualStyleBackColor = true;
            // 
            // HOME
            // 
            this.HOME.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME.Location = new System.Drawing.Point(53, 29);
            this.HOME.Margin = new System.Windows.Forms.Padding(2);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(1115, 631);
            this.HOME.TabIndex = 0;
            // 
            // s
            // 
            this.s.Controls.Add(this.ENDPOINTS);
            this.s.Location = new System.Drawing.Point(4, 31);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(3);
            this.s.Size = new System.Drawing.Size(1252, 665);
            this.s.TabIndex = 1;
            this.s.Text = "ENDPOINTS";
            this.s.UseVisualStyleBackColor = true;
            // 
            // ENDPOINTS
            // 
            this.ENDPOINTS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDPOINTS.Location = new System.Drawing.Point(162, 7);
            this.ENDPOINTS.Margin = new System.Windows.Forms.Padding(4);
            this.ENDPOINTS.Name = "ENDPOINTS";
            this.ENDPOINTS.Size = new System.Drawing.Size(954, 665);
            this.ENDPOINTS.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SEESION);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1252, 665);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SEESION";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SEESION
            // 
            this.SEESION.Location = new System.Drawing.Point(4, 0);
            this.SEESION.Margin = new System.Windows.Forms.Padding(4);
            this.SEESION.Name = "SEESION";
            this.SEESION.Size = new System.Drawing.Size(1241, 596);
            this.SEESION.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CERTIFICATION);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 665);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "CERTIFICATIONS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CERTIFICATION
            // 
            this.CERTIFICATION.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CERTIFICATION.Location = new System.Drawing.Point(7, 7);
            this.CERTIFICATION.Margin = new System.Windows.Forms.Padding(4);
            this.CERTIFICATION.Name = "CERTIFICATION";
            this.CERTIFICATION.Size = new System.Drawing.Size(1236, 654);
            this.CERTIFICATION.TabIndex = 0;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1272, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBAR);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thesis Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.statusBAR.ResumeLayout(false);
            this.statusBAR.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.a.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBAR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ServerStateLB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ServerTimeLB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sessionsLB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel subscriptionsLB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel itemsLB;
        private System.Windows.Forms.Timer UpdateTimerCTRL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage a;
        private System.Windows.Forms.TabPage s;
        private Home HOME;
        private Endpoints ENDPOINTS;
        private System.Windows.Forms.TabPage tabPage3;
        private Seesion SEESION;
        private System.Windows.Forms.TabPage tabPage1;
        private Certification CERTIFICATION;
    }
}

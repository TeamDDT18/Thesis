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

namespace Opc.Ua.Server.Controls
{
    partial class Seesion
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
            this.MainPN = new System.Windows.Forms.SplitContainer();
            this.SessionsGB = new System.Windows.Forms.GroupBox();
            this.SessionsLV = new System.Windows.Forms.ListView();
            this.SessionIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SessionNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastContactTimeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubscriptionsGB = new System.Windows.Forms.GroupBox();
            this.SubscriptionsLV = new System.Windows.Forms.ListView();
            this.SubscriptionIdCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishingIntervalCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemCountCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SequenceNumberCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressPN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainPN)).BeginInit();
            this.MainPN.Panel1.SuspendLayout();
            this.MainPN.Panel2.SuspendLayout();
            this.MainPN.SuspendLayout();
            this.SessionsGB.SuspendLayout();
            this.SubscriptionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPN
            // 
            this.MainPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPN.Location = new System.Drawing.Point(0, 10);
            this.MainPN.Margin = new System.Windows.Forms.Padding(4);
            this.MainPN.Name = "MainPN";
            this.MainPN.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainPN.Panel1
            // 
            this.MainPN.Panel1.Controls.Add(this.SessionsGB);
            this.MainPN.Panel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // MainPN.Panel2
            // 
            this.MainPN.Panel2.Controls.Add(this.SubscriptionsGB);
            this.MainPN.Panel2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPN.Size = new System.Drawing.Size(709, 415);
            this.MainPN.SplitterDistance = 176;
            this.MainPN.SplitterWidth = 5;
            this.MainPN.TabIndex = 3;
            // 
            // SessionsGB
            // 
            this.SessionsGB.Controls.Add(this.SessionsLV);
            this.SessionsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionsGB.Location = new System.Drawing.Point(3, 2);
            this.SessionsGB.Margin = new System.Windows.Forms.Padding(4);
            this.SessionsGB.Name = "SessionsGB";
            this.SessionsGB.Padding = new System.Windows.Forms.Padding(4);
            this.SessionsGB.Size = new System.Drawing.Size(703, 172);
            this.SessionsGB.TabIndex = 0;
            this.SessionsGB.TabStop = false;
            this.SessionsGB.Text = "Sessions";
            // 
            // SessionsLV
            // 
            this.SessionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SessionIdCH,
            this.SessionNameCH,
            this.UserNameCH,
            this.LastContactTimeCH});
            this.SessionsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionsLV.FullRowSelect = true;
            this.SessionsLV.HideSelection = false;
            this.SessionsLV.Location = new System.Drawing.Point(4, 19);
            this.SessionsLV.Margin = new System.Windows.Forms.Padding(4);
            this.SessionsLV.Name = "SessionsLV";
            this.SessionsLV.Size = new System.Drawing.Size(695, 149);
            this.SessionsLV.TabIndex = 0;
            this.SessionsLV.UseCompatibleStateImageBehavior = false;
            this.SessionsLV.View = System.Windows.Forms.View.Details;
            // 
            // SessionIdCH
            // 
            this.SessionIdCH.Text = "SessionId";
            this.SessionIdCH.Width = 101;
            // 
            // SessionNameCH
            // 
            this.SessionNameCH.Text = "Name";
            this.SessionNameCH.Width = 90;
            // 
            // UserNameCH
            // 
            this.UserNameCH.Text = "User";
            this.UserNameCH.Width = 90;
            // 
            // LastContactTimeCH
            // 
            this.LastContactTimeCH.Text = "Last Contact";
            this.LastContactTimeCH.Width = 126;
            // 
            // SubscriptionsGB
            // 
            this.SubscriptionsGB.Controls.Add(this.SubscriptionsLV);
            this.SubscriptionsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriptionsGB.Location = new System.Drawing.Point(3, 2);
            this.SubscriptionsGB.Margin = new System.Windows.Forms.Padding(4);
            this.SubscriptionsGB.Name = "SubscriptionsGB";
            this.SubscriptionsGB.Padding = new System.Windows.Forms.Padding(4);
            this.SubscriptionsGB.Size = new System.Drawing.Size(703, 230);
            this.SubscriptionsGB.TabIndex = 0;
            this.SubscriptionsGB.TabStop = false;
            this.SubscriptionsGB.Text = "Subscriptions";
            // 
            // SubscriptionsLV
            // 
            this.SubscriptionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubscriptionIdCH,
            this.PublishingIntervalCH,
            this.ItemCountCH,
            this.SequenceNumberCH});
            this.SubscriptionsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriptionsLV.FullRowSelect = true;
            this.SubscriptionsLV.HideSelection = false;
            this.SubscriptionsLV.Location = new System.Drawing.Point(4, 19);
            this.SubscriptionsLV.Margin = new System.Windows.Forms.Padding(4);
            this.SubscriptionsLV.Name = "SubscriptionsLV";
            this.SubscriptionsLV.Size = new System.Drawing.Size(695, 207);
            this.SubscriptionsLV.TabIndex = 0;
            this.SubscriptionsLV.UseCompatibleStateImageBehavior = false;
            this.SubscriptionsLV.View = System.Windows.Forms.View.Details;
            // 
            // SubscriptionIdCH
            // 
            this.SubscriptionIdCH.Text = "SubscriptionId";
            this.SubscriptionIdCH.Width = 90;
            // 
            // PublishingIntervalCH
            // 
            this.PublishingIntervalCH.Text = "Publishing Interval";
            this.PublishingIntervalCH.Width = 101;
            // 
            // ItemCountCH
            // 
            this.ItemCountCH.Text = "Item Count";
            this.ItemCountCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemCountCH.Width = 126;
            // 
            // SequenceNumberCH
            // 
            this.SequenceNumberCH.Text = "Seq No";
            this.SequenceNumberCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressPN
            // 
            this.AddressPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddressPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressPN.Location = new System.Drawing.Point(0, 0);
            this.AddressPN.Margin = new System.Windows.Forms.Padding(4);
            this.AddressPN.Name = "AddressPN";
            this.AddressPN.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddressPN.Size = new System.Drawing.Size(709, 10);
            this.AddressPN.TabIndex = 0;
            // 
            // Seesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPN);
            this.Controls.Add(this.AddressPN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seesion";
            this.Size = new System.Drawing.Size(709, 425);
            this.MainPN.Panel1.ResumeLayout(false);
            this.MainPN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPN)).EndInit();
            this.MainPN.ResumeLayout(false);
            this.SessionsGB.ResumeLayout(false);
            this.SubscriptionsGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainPN;
        private System.Windows.Forms.GroupBox SessionsGB;
        private System.Windows.Forms.ListView SessionsLV;
        private System.Windows.Forms.ColumnHeader SessionIdCH;
        private System.Windows.Forms.ColumnHeader SessionNameCH;
        private System.Windows.Forms.ColumnHeader UserNameCH;
        private System.Windows.Forms.ColumnHeader LastContactTimeCH;
        private System.Windows.Forms.GroupBox SubscriptionsGB;
        private System.Windows.Forms.ListView SubscriptionsLV;
        private System.Windows.Forms.ColumnHeader SubscriptionIdCH;
        private System.Windows.Forms.ColumnHeader PublishingIntervalCH;
        private System.Windows.Forms.ColumnHeader ItemCountCH;
        private System.Windows.Forms.ColumnHeader SequenceNumberCH;
        private System.Windows.Forms.Panel AddressPN;
    }
}

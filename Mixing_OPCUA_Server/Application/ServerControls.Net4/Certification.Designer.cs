

namespace Opc.Ua.Server.Controls
{
    partial class Certification
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpenCerFolder = new System.Windows.Forms.Button();
            this.btnTrusted = new System.Windows.Forms.Button();
            this.btnRejected = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(200, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnOpenCerFolder
            // 
            this.btnOpenCerFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCerFolder.Location = new System.Drawing.Point(927, 3);
            this.btnOpenCerFolder.Name = "btnOpenCerFolder";
            this.btnOpenCerFolder.Size = new System.Drawing.Size(169, 48);
            this.btnOpenCerFolder.TabIndex = 1;
            this.btnOpenCerFolder.Text = "Open Cer folder";
            this.btnOpenCerFolder.UseVisualStyleBackColor = true;
            this.btnOpenCerFolder.Click += new System.EventHandler(this.btnOpenCerFolder_Click);
            // 
            // btnTrusted
            // 
            this.btnTrusted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrusted.Location = new System.Drawing.Point(953, 332);
            this.btnTrusted.Name = "btnTrusted";
            this.btnTrusted.Size = new System.Drawing.Size(137, 48);
            this.btnTrusted.TabIndex = 2;
            this.btnTrusted.Text = "Trusted";
            this.btnTrusted.UseVisualStyleBackColor = true;
            this.btnTrusted.Click += new System.EventHandler(this.btnTrusted_Click);
            // 
            // btnRejected
            // 
            this.btnRejected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejected.Location = new System.Drawing.Point(953, 408);
            this.btnRejected.Name = "btnRejected";
            this.btnRejected.Size = new System.Drawing.Size(137, 48);
            this.btnRejected.TabIndex = 3;
            this.btnRejected.Text = "Rejected";
            this.btnRejected.UseVisualStyleBackColor = true;
            this.btnRejected.Click += new System.EventHandler(this.btnRejected_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(953, 480);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 48);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // Certification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRejected);
            this.Controls.Add(this.btnTrusted);
            this.Controls.Add(this.btnOpenCerFolder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Certification";
            this.Size = new System.Drawing.Size(1124, 556);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOpenCerFolder;
        private System.Windows.Forms.Button btnTrusted;
        private System.Windows.Forms.Button btnRejected;
        private System.Windows.Forms.Button btnRemove;
    }
}

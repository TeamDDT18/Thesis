using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opc.Ua.Server.Controls
{
    public partial class Certification : UserControl
    {
        public Certification()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DirectoryInfo TrustedCerPath = new DirectoryInfo(@"..\..\..\..\Security\pki\trusted\certs");
        DirectoryInfo RejectedCerPath = new DirectoryInfo(@"..\..\..\..\Security\pki\rejected\certs");
        FileInfo[] CerTrusted = { };
        FileInfo[] CerRejected = { };
        string Filename = "";
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            dt.Clear();
            dt.Columns.Add("Trusted Certification");
            dt.Columns.Add("Rejected Certification");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].MinimumWidth = 380;
            dataGridView1.Columns[0].MinimumWidth = 380;
            btnTrusted.Enabled = false;
            btnRejected.Enabled = false;

        }

        public void UpdateCertification()
        {
            if ((TrustedCerPath.GetFiles().Length != CerTrusted.Length) || (RejectedCerPath.GetFiles().Length != CerRejected.Length))
            {
                dt.Rows.Clear();
                //Trusted Certification         
                CerTrusted = TrustedCerPath.GetFiles();
                foreach (FileInfo file in CerTrusted)
                {
                    DataRow row1 = dt.NewRow();
                    row1["Trusted Certification"] = file.Name;
                    dt.Rows.Add(row1);
                }

                //Rejected Certification
                CerRejected = RejectedCerPath.GetFiles();
                foreach (FileInfo file in CerRejected)
                {
                    DataRow row1 = dt.NewRow();
                    row1["Rejected Certification"] = file.Name;
                    dt.Rows.Add(row1);
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnOpenCerFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\\Security\pki");
        }

        private void btnTrusted_Click(object sender, EventArgs e)
        {
            string sourceFile = Path.Combine(RejectedCerPath.ToString(), Filename);
            string destFile = Path.Combine(TrustedCerPath.ToString(), Filename);
            File.Move(sourceFile, destFile);
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            string sourceFile = Path.Combine(TrustedCerPath.ToString(), Filename);
            string destFile = Path.Combine(RejectedCerPath.ToString(), Filename);
            File.Move(sourceFile, destFile);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Filename = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                btnRejected.Enabled = true;
                btnTrusted.Enabled = false;
            }
            if (e.ColumnIndex == 1)
            {
                btnRejected.Enabled = false;
                btnTrusted.Enabled = true;
            }
            if (Filename == "")
            {
                btnRejected.Enabled = false;
                btnTrusted.Enabled = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFile = Path.Combine(TrustedCerPath.ToString(), Filename);
                File.Delete(sourceFile);
            }
            catch
            {

            }
            try
            {
                string sourceFile = Path.Combine(RejectedCerPath.ToString(), Filename);
                File.Delete(sourceFile);
            }
            catch
            {

            }
        }
    }
}

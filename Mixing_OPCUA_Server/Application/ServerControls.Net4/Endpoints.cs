using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Opc.Ua.Server.Controls
{
    public partial class Endpoints : UserControl
    {
        public Endpoints()
        {
            InitializeComponent();
        }

        string[] EndpointUrl = new string[11];
        private string path = @"..\..\ThesisServer.Config.xml";

        #region Private Fields
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        string[] SecurityMode = new string[11];
        string[] SecurityPolicies = new string[11];
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;


            int count = 0;
            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                EndpointUrl[count] = endpoint.EndpointUrl;
                count++;
            }
            lbUATCP.Text = EndpointUrl[0];
            lbHTTPS.Text = EndpointUrl[count - 1];
            tbUATCP.Text = EndpointUrl[0];
            tbUAHTTPS.Text = EndpointUrl[count - 1];

            //Update Server Security
            DataSet SecurityDataSet = new DataSet();
            SecurityDataSet.ReadXml(path);
            DataTable dt = new DataTable();
            dt = SecurityDataSet.Tables["ServerSecurityPolicy"];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                SecurityMode[i] = dr["SecurityMode"].ToString();
                SecurityPolicies[i] = dr["SecurityPolicyUri"].ToString();
                i++;
            }

            for (int j = 0; j < 11; j++)
            {
                try
                {
                    if (SecurityMode[j] == "None_1") cbUATCPNone.Checked = true;
                    if (SecurityMode[j] == "Sign_2")
                    {
                        cbUATCPSign.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256") cbBasic256.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256") cbBasic256SHA256.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15") cbBasic128RSA15.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep") cbSignAes128Sha256RsaOaep.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss") cbSignAes128Sha256RsaPss.Checked = true;
                    }
                    if (SecurityMode[j] == "SignAndEncrypt_3")
                    {
                        cbUATCPSignAndEncypt.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256") cbBasic256bis.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256") cbBasic256SHA256bis.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15") cbBasic128RSA15bis.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep") cbSignEncyptAes128Sha256RsaOaep.Checked = true;
                        if (SecurityPolicies[j] == "http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss") cbSignEncyptAes128Sha256RsaPss.Checked = true;
                    }
                }
                catch
                {

                }

            }
            if (cbUATCPSign.Checked == false) gbPoliciesSign.Visible = false;
            if (cbUATCPSignAndEncypt.Checked == false) gbPoliciesSignAndEncypt.Visible = false;
        }

        public void UpdateServer()
        {
            //foreach (Control c in this.Controls)
            //{
            //    c.TextChanged += new EventHandler(c_ControlChanged);
            //    c.VisibleChanged += new EventHandler(c_ControlChanged);
            //}

        }
        private void cbUATCPSign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUATCPSign.Checked) gbPoliciesSign.Visible = true;
            else gbPoliciesSign.Visible = false;
        }

        private void cbUATCPSignAndEncypt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUATCPSignAndEncypt.Checked) gbPoliciesSignAndEncypt.Visible = true;
            else gbPoliciesSignAndEncypt.Visible = false;
        }

        private void btnApplySetting_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Creating namespace object    
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            nsmgr.AddNamespace("ua", "http://opcfoundation.org/UA/2008/02/Types.xsd");
            nsmgr.AddNamespace("ns", "http://opcfoundation.org/UA/SDK/Configuration.xsd");

            XmlNode xNode = doc.SelectSingleNode("ns:ApplicationConfiguration/ns:ServerConfiguration/ns:SecurityPolicies", nsmgr);

            xNode.RemoveAll();

            if (cbUATCPNone.Checked)
            {
                XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                value.AppendChild(doc.CreateTextNode("None_1"));

                value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#None"));
                xNode.AppendChild(elem);
            }
            if (cbUATCPSign.Checked)
            {
                if (cbBasic128RSA15.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("Sign_2"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15"));
                    xNode.AppendChild(elem);
                }
                if (cbBasic256.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("Sign_2"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256"));
                    xNode.AppendChild(elem);
                }
                if (cbBasic256SHA256.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("Sign_2"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256"));
                    xNode.AppendChild(elem);
                }
                if (cbSignAes128Sha256RsaOaep.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("Sign_2"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep"));
                    xNode.AppendChild(elem);
                }
                if (cbSignAes128Sha256RsaPss.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("Sign_2"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss"));
                    xNode.AppendChild(elem);
                }

            }
            if (cbUATCPSignAndEncypt.Checked)
            {
                if (cbBasic128RSA15bis.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("SignAndEncrypt_3"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15"));
                    xNode.AppendChild(elem);
                }
                if (cbBasic256bis.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("SignAndEncrypt_3"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256"));
                    xNode.AppendChild(elem);
                }
                if (cbBasic256SHA256bis.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("SignAndEncrypt_3"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256"));
                    xNode.AppendChild(elem);
                }
                if (cbSignEncyptAes128Sha256RsaOaep.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("SignAndEncrypt_3"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep"));
                    xNode.AppendChild(elem);
                }
                if (cbSignEncyptAes128Sha256RsaPss.Checked)
                {
                    XmlNode elem = doc.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("SignAndEncrypt_3"));

                    value = elem.AppendChild(doc.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(doc.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss"));
                    xNode.AppendChild(elem);
                }
            }

            doc.Save(path);
        }
    }
}

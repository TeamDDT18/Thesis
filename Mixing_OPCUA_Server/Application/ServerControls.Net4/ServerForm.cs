using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Opc.Ua;
using Opc.Ua.Configuration;
using System.IO;
using System.Linq;

namespace Opc.Ua.Server.Controls
{
    /// <summary>
    /// The primary form displayed by the application.
    /// </summary>
    public partial class ServerForm : Form
    {
        #region Constructors
        /// <summary>
        /// Creates an empty form.
        /// </summary>
        public ServerForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        public ServerForm(StandardServer server, ApplicationConfiguration configuration)
        {
            InitializeComponent();

            m_server = server;
            m_configuration = configuration;

            this.HOME.Initialize(m_server, m_configuration);
            this.SEESION.Initialize(m_server, m_configuration);
            this.ENDPOINTS.Initialize(m_server, m_configuration);
        }


        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        public ServerForm(ApplicationInstance application, bool showCertificateValidationDialog = false)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            if (showCertificateValidationDialog &&
                !application.ApplicationConfiguration.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                application.ApplicationConfiguration.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }

            //Enable Timer for update server information
            UpdateTimerCTRL.Enabled = true;
            UpdateTimerCTRL.Interval = 1000;

            //Set up for home tab
            this.HOME.Initialize(m_server, m_configuration);
            this.SEESION.Initialize(m_server, m_configuration);
            this.ENDPOINTS.Initialize(m_server, m_configuration);
            this.CERTIFICATION.Initialize(m_server, m_configuration);
        }


        #endregion

        #region Private Fields
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;


        public static void HandleCertificateValidationError(Form caller, CertificateValidator validator, CertificateValidationEventArgs e)
        {
            StringBuilder buffer = new StringBuilder();
            buffer.AppendLine("Certificate could not be validated!");
            buffer.AppendLine("Validation error(s):");
            ServiceResult error = e.Error;
            while (error != null)
            {
                buffer.AppendFormat("- {0}\r\n", error.ToString().Split('\r', '\n').FirstOrDefault());
                error = error.InnerResult;
            }
            buffer.AppendFormat("\r\nSubject: {0}\r\n", e.Certificate.Subject);
            buffer.AppendFormat("Issuer: {0}\r\n", X509Utils.CompareDistinguishedName(e.Certificate.Subject, e.Certificate.Issuer)
                ? "Self-signed" : e.Certificate.Issuer);
            buffer.AppendFormat("Valid From: {0}\r\n", e.Certificate.NotBefore);
            buffer.AppendFormat("Valid To: {0}\r\n", e.Certificate.NotAfter);
            buffer.AppendFormat("Thumbprint: {0}\r\n\r\n", e.Certificate.Thumbprint);
            buffer.Append("Security certificate problems may indicate an attempt to intercept any data you send ");
            buffer.Append("to a server or to allow an untrusted client to connect to your server.");
            buffer.Append("\r\n\r\nAccept anyway?");

            if (MessageBox.Show(buffer.ToString(), caller.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.AcceptAll = true;
                
            }
        }

        void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            try
            {
                HandleCertificateValidationError(this, validator, e);
            }
            catch (Exception exception)
            {
                HandleException(this.Text, MethodBase.GetCurrentMethod(), exception);
            }
        }

        public static void HandleException(string caption, MethodBase method, Exception e)
        {
            if (String.IsNullOrEmpty(caption))
            {
                caption = method.Name;
            }
            ExceptionDlg.Show(caption, e);
        }
        #endregion

        #region Event Handlers
        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                m_server.Stop();
            }
            catch (Exception exception)
            {
                Utils.Trace(exception, "Error stopping server.");
            }
        }

        private void UpdateTimerCTRL_Tick(object sender, EventArgs e)
        {
            try
            {
                ServerStateLB.Text = m_server.CurrentInstance.CurrentState.ToString();
                ServerTimeLB.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
                sessionsLB.Text = Convert.ToString(this.SEESION.NumberofSeesion());
                subscriptionsLB.Text = Convert.ToString(this.SEESION.NumberofSubcriptions());
                itemsLB.Text = Convert.ToString(this.SEESION.ItenCount());

                this.HOME.UpdateServer();
                this.SEESION.UpdateServer();
                this.ENDPOINTS.UpdateServer();
                this.CERTIFICATION.UpdateCertification();

            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        #endregion



    }
}

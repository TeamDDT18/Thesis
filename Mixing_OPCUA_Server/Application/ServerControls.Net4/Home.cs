using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opc.Ua.Server.Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        #region Private Fields
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        string[] EndpointUrl = new string[10];

        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;
            lbServerStartingTime.Text = String.Format("{0:dd/MM/yyy HH:mm:ss}", DateTime.Now);

            int count = 0;
            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                EndpointUrl[count] = endpoint.EndpointUrl;
                count++;
            }
            lbTCPAddress.Text = EndpointUrl[0];
            lbHTTPSAddress.Text = EndpointUrl[count - 1];
        }

        public void UpdateServer()
        {
            try
            {
                lbStatus.Text = m_server.CurrentInstance.CurrentState.ToString();
                lbCurrentTime.Text = String.Format("{0:dd/MM/yyy HH:mm:ss}", DateTime.Now);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Opc.Ua.Server;

namespace Opc.Ua.Server.Controls
{
    /// <summary>
    /// Displays diagnostics information for a server running within the process.
    /// </summary>
    public partial class Seesion : UserControl
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Seesion"/> class.
        /// </summary>
        public Seesion()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion
        
        #region Public Interface
        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        /// <param name="server">The server displayed in the form.</param>
        /// <param name="configuration">The configuration used to initialize the server.</param>
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Updates the sessions displayed in the form.
        /// </summary>
        private void UpdateSessions()
        {
            SessionsLV.Items.Clear();

            IList<Session> sessions = m_server.CurrentInstance.SessionManager.GetSessions();

            for (int ii = 0; ii < sessions.Count; ii++)
            {
                Session session = sessions[ii];

                lock (session.DiagnosticsLock)
                {
                    ListViewItem item = new ListViewItem(session.SessionDiagnostics.SessionName);

                    if (session.Identity != null)
                    {
                        item.SubItems.Add(session.Identity.DisplayName);
                    }
                    else
                    {
                        item.SubItems.Add(String.Empty);
                    }

                    item.SubItems.Add(String.Format("{0}", session.Id));
                    item.SubItems.Add(String.Format("{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime()));

                    SessionsLV.Items.Add(item);
                }
            }

            // adjust 
            for (int ii = 0; ii < SessionsLV.Columns.Count; ii++)
            {
                SessionsLV.Columns[ii].Width = -2;
            }
        }

        /// <summary>
        /// Updates the subscriptions displayed in the form.
        /// </summary>
        private void UpdateSubscriptions()
        {
            SubscriptionsLV.Items.Clear();

            IList<Subscription> subscriptions = m_server.CurrentInstance.SubscriptionManager.GetSubscriptions();

            for (int ii = 0; ii < subscriptions.Count; ii++)
            {
                Subscription subscription = subscriptions[ii];

                ListViewItem item = new ListViewItem(subscription.Id.ToString());

                item.SubItems.Add(String.Format("{0}", (int)subscription.PublishingInterval));
                item.SubItems.Add(String.Format("{0}", subscription.MonitoredItemCount));

                lock (subscription.DiagnosticsLock)
                {
                    item.SubItems.Add(String.Format("{0}", subscription.Diagnostics.NextSequenceNumber));
                }

                SubscriptionsLV.Items.Add(item);
            }

            for (int ii = 0; ii < SubscriptionsLV.Columns.Count; ii++)
            {
                SubscriptionsLV.Columns[ii].Width = -2;
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// A callback used to periodically refresh the form contents.
        /// </summary>
        /// 
        int itemTotal = 0;
        public int NumberofSeesion()
        {
            return SessionsLV.Items.Count;
        }
        public int NumberofSubcriptions()
        {
            return SubscriptionsLV.Items.Count;
        }
        public int ItenCount()
        {
            return itemTotal;
        }

        public void UpdateServer()
        {
            try
            {
                UpdateSessions();
                UpdateSubscriptions();
                itemTotal = 0;
                for (int i = 0; i < SubscriptionsLV.Items.Count; i++)
                {
                    itemTotal += Convert.ToInt32(SubscriptionsLV.Items[i].SubItems[2].Text);
                }
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        #endregion

    }
}

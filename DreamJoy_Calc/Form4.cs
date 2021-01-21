using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class Form4 : Form
    {
        Subscriber user;
        List<Notification> notifications = new List<Notification>();
        public Form4()
        {
            InitializeComponent();
        }

      
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            user = new Subscriber(null ,textBoxName.Text);
            CBEmail.Visible = true;
            CBSMS.Visible = true;
            CBPopup.Visible = true;
            textBoxMessage.Visible = true;
            btnSendNotification.Visible = true;

        }


       

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            if (CBEmail.Checked)
            {
                notifications.Add(new Email());
            }
            if (CBSMS.Checked)
            {
                notifications.Add(new SMS());
            }
            if (CBPopup.Checked)
            {
                notifications.Add(new Popup());
            }
            foreach (Notification notification in notifications)
            {
                notification.Send(textBoxMessage.Text);
            }
        }

        private void CBEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

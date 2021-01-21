using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    abstract class Notification
    {
        
      
        public abstract void Send(string messageContent);

    }

    class Email : Notification
    {
     
        public override void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an email: \n{messageContent}");
        }
    }
    class SMS : Notification
    {
      
        public override void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an SMS: \n{messageContent}");
        }
    }
    class Popup : Notification
    {
        public override void Send(string messageContent)
        {
            MessageBox.Show($"popup: \n{messageContent}");
        }
    }
}

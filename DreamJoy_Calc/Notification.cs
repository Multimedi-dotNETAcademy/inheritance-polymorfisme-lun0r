using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    interface INotification
    {
        
      
         void Send(string messageContent);

    }

    class Email : INotification
    {
     
        public void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an email: \n{messageContent}");
        }
    }
    class SMS : INotification
    {
      
        public void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an SMS: \n{messageContent}");
        }
    }
    class Popup : INotification
    {
        public void Send(string messageContent)
        {
            MessageBox.Show($"popup: \n{messageContent}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJoy_Calc
{
    class Subscriber
    {
        public string Name { get; set; }
        public List<INotification> _notifications;

        public Subscriber(List<INotification> notification, string name)
        {
            Name = name;
            _notifications = notification;
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJoy_Calc
{
    class Subscriber
    {
        public string Name { get; set; }
        public List<Notification> _notifications;

        public Subscriber(List<Notification> notification, string name)
        {
            Name = name;
            _notifications = notification;
            
        }

    }
}

﻿using sabatex.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persik_Chat_Classes
{
    public class Chat:ObservableObject
    {
        private User user1;
        private User user2;  
        private DateTime lastActivity = DateTime.Now;

        private ObservableCollection<Message> messages = new ObservableCollection<Message>();
      
        public Chat(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
            this.lastActivity = DateTime.Now;
        }

        public Chat() { }

        #region NotifyingProperties
        public User User1
        {
            get => user1;
            set => SetProperty(ref user1, value);
        }

        public User User2
        {
            get => user2;
            set => SetProperty(ref user2, value);
        }

        public DateTime LastActivity
        {
            get => lastActivity;
            set => SetProperty(ref lastActivity, value);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persik_Chat_Classes
{
    public class Chat
    {
        private User user1;
        private User user2;
        private ObservableCollection<Message> messages = new ObservableCollection<Message>();
        private DateTime lastActivity = DateTime.Now;

        public Chat(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
            this.lastActivity = DateTime.Now;
        }

        public Chat() { }
    }
}

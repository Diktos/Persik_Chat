using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using sabatex.Extensions;

namespace Persik_Chat_Classes
{
    public class Message : ObservableObject
    {
        private string sender;        // Відправник
        private string recipient;     // Одержувач 
        private string content;       // Текст повідомлення
        private DateTime timestamp;   // Час відправлення

        public Message(string sender, string recipient, string content)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.content = content;
            this.timestamp = DateTime.Now;
        }

        public Message() { }

        #region NotifyingProperties

        public string Sender
        {
            get => sender;
            set => SetProperty(ref sender, value);
        }

        public string Recipient
        {
            get => recipient;
            set => SetProperty(ref recipient, value);
        }

        public string Content
        {
            get => content;
            set => SetProperty(ref content, value);
        }

        public DateTime Timestamp
        {
            get => timestamp;
            set => SetProperty(ref timestamp, value);
        }

        #endregion
    }
}

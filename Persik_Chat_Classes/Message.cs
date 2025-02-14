using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persik_Chat_Classes
{
    public class Message : NotifyPropertyChanged
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
    }

}

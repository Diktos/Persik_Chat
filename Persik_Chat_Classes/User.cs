using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.ObjectModel;


namespace Persik_Chat_Classes
{
    public class User:NotifyPropertyChanged
    {
        private string userName = "Default";
        private string lastName = string.Empty;
        private string login = "userName";
        private string password = "123";
        private DateTime dateOfBirth = DateTime.Parse("01.01.2020");
        private Status status = Status.Offline;
        private string avatarPath = string.Empty;
        //private Image avatar = null; ------ Можна зберігати шлях, якщо імедж тіки у ВПФ файлі
        private DateTime lastSeen = DateTime.Now;
        private string email = string.Empty;

        private Dictionary<User,Chat> chats = new Dictionary<User, Chat>();


        public User(string userName, string lastName, string login, string password, DateTime dateOfBirth,
               Status status, string avatarPath, DateTime lastSeen, string email)
        {
            this.userName = userName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            this.dateOfBirth = dateOfBirth;
            this.status = status;
            this.avatarPath = avatarPath;
            this.lastSeen = lastSeen;
            this.email = email;
        }

        public User() { }

    }

    public enum Status
    {
        Online,
        Busy,
        Offline
    }

    #region NotifyingProperties

    //public string UserName ------- так не можна, треба тільки у ВПФ середовищі?
    //{
    //    get { return userName; }
    //    set
    //    {
    //        if (userName != value)
    //        {
    //            userName = value;
    //            UserName(nameof(UserName));
    //        }
    //    }
    //}

    #endregion
}
// Коли користувач робить пошук користувача за логіном у месенджері він робить запит до сервера коли пише логін, на сервер
// і цей запит приймається і відправляється відповідь через метод потрібний набір користувачів які співпадають за логіном

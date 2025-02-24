﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.ObjectModel;
using sabatex.Extensions;


namespace Persik_Chat_Classes
{
    public class User:ObservableObject
    {
        private string userName = "Default";
        private string lastName = string.Empty;
        private string login = "userName";
        private string password = "123";
        private DateTime dateOfBirth = DateTime.Parse("01.01.2020");
        private Status status = Status.Offline;
        private string avatarPath = string.Empty; // byte[] for photo
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

        #region NotifyingProperties

        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public string Login
        {
            get => login;
            set => SetProperty(ref login, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => SetProperty(ref dateOfBirth, value);
        }

        public Status Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        public string AvatarPath
        {
            get => avatarPath;
            set => SetProperty(ref avatarPath, value);
        }

        public DateTime LastSeen
        {
            get => lastSeen;
            set => SetProperty(ref lastSeen, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        #endregion

    }

    public enum Status
    {
        Online,
        Busy,
        Offline
    }
}
// Коли користувач робить пошук користувача за логіном у месенджері він робить запит до сервера коли пише логін, на сервер
// і цей запит приймається і відправляється відповідь через метод потрібний набір користувачів які співпадають за логіном

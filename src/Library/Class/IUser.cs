using System;
using Library;
using Telegram.Bot.Types;


namespace Library
{
    public interface IUser
    {
        private string email{get; private set; }

        private string nameUser();

        private string phoneNumber {get; private set; }

        private string password();

        private Location location();   

        public void unsubscribe()
        {
        }

        public void obtaininformation()
        {
            this.email.get;
            this.nameUser.get;
            this.phoneNumber.get;
            this.password.get;
            this.ubication.get;
        }
    }
}
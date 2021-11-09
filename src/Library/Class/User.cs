using System;
using Library;
using Telegram.Bot.Types;


namespace Library
{
    public abstract class User
        {
            /*We create an abstract class called user to heredate the 
            common atributes between CompanyUser, AdminUser and EntrepreneurUser*/
            public User(string idUser, string email, string nameUser, string phoneNumber, string password, string ubication)
            {
                this.IdUser = idUser;
                this.Email = email;
                this.NameUser = nameUser;
                this.PhoneNumer = phoneNumber;
                this.Password = password;
                this.Ubication = ubication;
                Active = 1;
            }

            public object IdUser { get; private set; }
            public object Email { get; private set; }
            public string NameUser { get; private set; }
            public string PhoneNumer { get; private set; }
            public string Password { get; private set; }
            public string Ubication { get; private set; }
            public int Active { get; private set; }

            public void unsubscribe()
            {
                this.Active = 0;
            }
        }
}
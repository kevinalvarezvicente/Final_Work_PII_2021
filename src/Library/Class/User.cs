using System.Collections.Generic;
using FINAL_WORK_PII_2021.src.Library.Class.Commands;

namespace Library
{
    public abstract class User
    {
        /*We create an abstract class called user to heredate the 
          common atributes between CompanyUser, AdminUser and EntrepreneurUser*/
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser">identificación del usuario</param>
        /// <param name="email">email del usuario</param>
        /// <param name="nameUser">nombre de usuario</param>
        /// <param name="phoneNumber">telefono del usuario</param>
        public User(string idUser, string email, string nameUser, string phoneNumber)
        {
            this.IdUser = idUser;
            this.Email = email;
            this.NameUser = nameUser;
            this.PhoneNumber = phoneNumber;
            Active = 1;
        }

        public object IdUser { get; private set; }
        public object Email { get; private set; }
        public string NameUser { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Location { get; private set; }
        public int Active { get; private set; }

        public void unsubscribe()
        {
            this.Active = 0;
        }
    }
}
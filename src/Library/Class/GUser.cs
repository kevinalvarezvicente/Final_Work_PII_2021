namespace Library
{
    public abstract class GUser
    {
        /*We create an abstract class called user to heredate the 
          common atributes between CompanyUser, AdminUser and EntrepreneurUser*/
        
        /// <summary>
        /// Esta clase fue creada con este nombre porque generaba conflicto con la API de Location
        /// </summary>
        /// <param name="idUser">identificación del usuario</param>
        /// <param name="email">email del usuario</param>
        /// <param name="nameUser">nombre de usuario</param>
        /// <param name="phoneNumber">telefono del usuario</param>
        /// <param name="location">ubicacion del usuario</param>
        public GUser(string idUser, string email, string nameUser, string phoneNumber, string location)
        {
            this.IdUser = idUser;
            this.Email = email;
            this.NameUser = nameUser;
            this.PhoneNumber = phoneNumber;
            this.Location = location;
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
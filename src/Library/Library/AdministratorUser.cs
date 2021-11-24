namespace Library
{
    public class AdministratorUser : User
    {
        public string NameCompany { get; private set; }
        public string Ocuppation { get; private set; }
        public AdministratorUser(string idUser, string email, string nameUser, string phoneNumber, string nameCompany, string ocuppation)
           : base(idUser, email, nameUser, phoneNumber)
        {
            this.NameCompany = nameCompany;
            this.Ocuppation = ocuppation;
        }

    }
}

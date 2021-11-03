namespace Library
{
    public class CompanyUser : GUser
    {
        public CompanyUser(string idUser, string email, string nameUser, string phoneNumber, string password, string ubication, string nameCompany, string ocuppation)
           : base(idUser, email, nameUser, phoneNumber, password, ubication)
        {
            this.NameCompany = nameCompany;
            this.Ocuppation = ocuppation;
        }

        public string NameCompany { get; private set; }
        public string Ocuppation { get; private set; }
    }
} 
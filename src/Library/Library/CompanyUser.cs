namespace Library
{
    public class CompanyUser : User
    {
        public CompanyUser(string idUser, string email, string nameUser, string phoneNumber, string nameCompany, string ocuppation)
           : base(idUser, email, nameUser, phoneNumber)
        {
            this.NameCompany = nameCompany;
            this.Ocuppation = ocuppation;
        }

        public string NameCompany { get; private set; }
        public string Ocuppation { get; private set; }
    }
} 
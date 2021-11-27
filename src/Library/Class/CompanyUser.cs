using FINAL_WORK_PII_2021.src.Library.Class.Commands;

namespace Library
{
    public class CompanyUser : User
    {
        public CompanyUser(string idUser, string email, string nameUser, string phoneNumber, Company nameCompany, string ocuppation)
           : base(idUser, email, nameUser, phoneNumber)
        {
            this.NameCompany = nameCompany;
            this.Ocuppation = ocuppation;
        }

        public Company NameCompany { get; private set; }
        public string Ocuppation { get; private set; }
        public PublicationState publicationState { get;  set;}

    }
} 
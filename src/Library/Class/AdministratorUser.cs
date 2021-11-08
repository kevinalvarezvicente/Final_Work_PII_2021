namespace Library
{
    public class AdministratorUser : GUser
    {
        public AdministratorUser(string idUser, string email, string nameUser, string phoneNumber, string password, string ubication, string nameCompany, string ocuppation)
           : base(idUser, email, nameUser, phoneNumber, password, ubication)
        {
            this.NameCompany = nameCompany;
            this.Ocuppation = ocuppation;
        }

        public string NameCompany { get; private set; }
        public string Ocuppation { get; private set; }

        public void Invite(int id)
        {
            Invitation inv = new Invitation();
            inv.createInvitation(id);
        }
    }
}

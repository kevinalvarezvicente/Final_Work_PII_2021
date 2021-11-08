namespace Library
{
    public class Entrepreneur: GUser
    {
        Specialty[] specialtyList;
        Entrepreneur_Qual[] qualificationList;

        public Entrepreneur(string idUser, string email, string nameUser, string phoneNumber, string password, string ubication)
           : base(idUser, email, nameUser, phoneNumber, password, ubication)
        {
        }

    }
}
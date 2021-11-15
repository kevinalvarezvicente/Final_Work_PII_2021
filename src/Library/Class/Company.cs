namespace Library
{
    public class Company
    {
        public string rut { get; private set; }
        public string focus { get; private set; }

        public Company(string rut, string focus){
            this.rut = rut;
            this.focus = focus;
        }

        
    }
}
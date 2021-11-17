namespace Library
{
    public class Company
    {
        public string rut { get; private set; }
        public string CompanySector { get; private set; }
        public string Department { get; private set; }


        public Company(string rut, string CompanySector, string Department){
            this.rut = rut;
            this.CompanySector = CompanySector;
            this.Department = Department;
        }

        
    }
}
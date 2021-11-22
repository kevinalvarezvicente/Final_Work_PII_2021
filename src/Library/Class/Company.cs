namespace Library
{
    public class Company
    {
        public string CompanyName { get; private set; }
        public string rut { get; private set; }
        public string CompanySector { get; private set; }
        public string Department { get; private set; }


        public Company(string CompanyName, string rut, string CompanySector, string Department){
            this.CompanyName = CompanyName;
            this.rut = rut;
            this.CompanySector = CompanySector;
            this.Department = Department;
        }

        
    }
}
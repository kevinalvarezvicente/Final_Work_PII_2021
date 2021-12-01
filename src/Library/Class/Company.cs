namespace src.Library.Class
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string rut { get; set; }
        public string CompanySector { get; set; }
        public string Department { get; set; }


        public Company(string CompanyName, string rut, string CompanySector, string Department){
            this.CompanyName = CompanyName;
            this.rut = rut;
            this.CompanySector = CompanySector;
            this.Department = Department;
        }

        public string ToString(){
            return "{ Nombre: "+ this.CompanyName + ", Rut: " + this.rut + ", Rubro: " + this.CompanySector + ", Localidad: " + this.Department + " }";
        }
        
    }
}
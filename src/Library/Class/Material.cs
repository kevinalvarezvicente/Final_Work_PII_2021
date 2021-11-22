using Library;

namespace Library
{
    public abstract class Material
    {
        int idMaterial;
        int stock;
        string unit;
        double cost;
        public Material (int idMaterial, int stock, string unit, double cost)
        { 
            this.idMaterial = idMaterial;
            this.stock = stock;
            this.unit = unit;
            this.cost = cost;
        }

        void getLocation(){
            
        }
    }
}
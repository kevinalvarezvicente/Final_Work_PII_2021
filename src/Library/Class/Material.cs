using Library;
using System;
using Ucu.Poo.Locations.Client;
namespace Library
{
    public class Material
    {
        public Material(int idMaterial, int stock, string unit, double cost, Location ubication, bool usual, Material_Qual[]materialList) 
        {
            this.idMaterial = idMaterial;
            this.stock = stock;
            this.unit = unit;
            this.cost = cost;
            this.ubication = ubication;
            this.usual = usual;
            this.materialList = materialList;
        }

        public int idMaterial { get; private set; }
        public int stock { get; private set; }
        public string unit { get; private set; }
        public double cost { get; private set; }
        public Location ubication { get; private set; }
        public bool usual { get; private set; }
        public Material_Qual[] materialList { get; private set; }

        public Location getUbication()
        {
            return this.ubication;
        }
    }
}
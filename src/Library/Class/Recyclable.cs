using System;

namespace Library
{
    public class Recyclable : Material
    {
        public Recyclable (int idMaterial, int stock, string unit, double cost) : base(idMaterial, stock, unit, cost)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;

namespace Library
{
    public class UsualStock
    {
        Material[] PunctualMaterial;
        Material[] NonPunctualMaterial;

        public void sortByStock(Material[] List)
        {
            Array.Sort(List);
        }
    }
}
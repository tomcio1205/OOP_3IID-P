using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            
        }

        public Construction(string buildMaterial, float width, float height, int entrances, int humanCapacity)
        {
            BuildMaterial = buildMaterial;
            Width = width;
            Height = height;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
        }

        public string BuildMaterial { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
    }
}

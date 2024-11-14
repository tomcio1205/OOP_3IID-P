using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.Constructions.models.DTO
{
    internal class CreateConstructionDto
    {
        public BuildMaterialEnum BuildMaterial { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
    }
}

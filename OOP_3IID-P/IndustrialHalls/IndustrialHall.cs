using OOP_3IID_P.Constructions;
using OOP_3IID_P.Constructions.models;
using OOP_3IID_P.Constructions.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.IndustrialHalls
{
    internal class IndustrialHall: Construction
    {
        public IndustrialHall(CreateConstructionDto data): base(data)
        {
            Console.WriteLine("");
        }
    }
}

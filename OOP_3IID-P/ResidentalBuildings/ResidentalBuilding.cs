using OOP_3IID_P.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.ResidentalBuildings
{
    internal class ResidentalBuilding: Construction
    {

        public ResidentalBuilding(int numberOfFloors)
        {
                NumberOfFloors = numberOfFloors;
        }

        public int NumberOfFloors { get; set; }
    }
}

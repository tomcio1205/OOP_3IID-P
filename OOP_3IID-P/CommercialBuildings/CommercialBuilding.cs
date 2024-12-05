using OOP_3IID_P.AbstractCommercialBuildings;
using OOP_3IID_P.Constructions.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.CommercialBuildings
{
    internal class CommercialBuilding : AbstractCommercialBuilding
    {
        public CommercialBuilding(CreateConstructionDto construction, string businessType) : base(construction, businessType)
        {
        }

        public override void OpenBusiness()
        {
            Console.WriteLine($"The {BusinessType} business is now open in the commercial building!");
        }
    }
}

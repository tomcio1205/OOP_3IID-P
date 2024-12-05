using OOP_3IID_P.Constructions;
using OOP_3IID_P.Constructions.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.AbstractCommercialBuildings
{
    internal abstract class AbstractCommercialBuilding: Construction
    {
        protected AbstractCommercialBuilding(CreateConstructionDto construction, string businessType): base(construction)
        {
            BusinessType = businessType;
        }

        public string BusinessType { get; set; }

        public abstract void OpenBusiness();

    }
}

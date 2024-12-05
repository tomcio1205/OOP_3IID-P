using OOP_3IID_P.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.Wrappers
{
    internal class BuildingWrapper
    {
        public BuildingWrapper(Construction construction)
        {
            _construction = construction;
        }

        private Construction _construction { get; set; }

        public double GetWrappedSquareCost()
        {
            return _construction.CalculateSquareCost();
        }

    }
}

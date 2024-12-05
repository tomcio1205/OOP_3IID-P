using OOP_3IID_P.Constructions.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3IID_P.Interfaces
{
    internal interface IConstructionInfo
    {
        float Height { get; }
        float Width { get; }
        int Entrances { get; }
        int HumanCapacity { get; }
        BuildMaterialEnum BuildMaterial { get; }

        void DisplayConstructionInfo();
    }
}

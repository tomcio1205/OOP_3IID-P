using OOP_3IID_P.Constructions.models;
using OOP_3IID_P.Constructions.models.DTO;
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
            BuildMaterial = BuildMaterialEnum.Concrete;
            Width = 20;
            Height = 44;
            Entrances = 1;
            HumanCapacity = 1;
        }

        public Construction(CreateConstructionDto data)
        {
            BuildMaterial = data.BuildMaterial;
            Width = data.Width;
            Height = data.Height;
            Entrances = data.Entrances;
            HumanCapacity = data.HumanCapacity;
        }

        public Construction(BuildMaterialEnum buildMaterial, float width, float height, int entrances, int humanCapacity)
        {
            BuildMaterial = buildMaterial;
            Width = width;
            Height = height;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
        }

        public BuildMaterialEnum BuildMaterial {
            get
            {
                return _buildMaterial;
            }
            set
            {
                _buildMaterial = value;
            }
        }
        private BuildMaterialEnum _buildMaterial { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        public float getSquareCost()
        {
            if (_buildMaterial == BuildMaterialEnum.Concrete)
                return Width * Height * 0.9f * 0.87f;
            if (_buildMaterial == BuildMaterialEnum.Brik)
                return Width * Height * 0.9f * 0.8f;
            return Width * Height * 0.9f * 0.78f; //Wood
        }
    }
}

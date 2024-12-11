using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Models.Dinghy.Motorized
{
    public class MDinghy : Dinghy
    {
        private FuelType _fuelType;
        private int _maxRange;
        private double _fuelCapacity;
        private double _topSpeed;
        public MDinghy(string components, FuelType fuelType, int maxRange, double fuelCapacity, double topSpeed ) : base(DinghyModel.Motorized , components)
        {
        }
    }
}

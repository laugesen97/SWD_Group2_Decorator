using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator
{
    class AddTireType : Decorator
    {
        private double _multiplier;
        public AddTireType(Car car, string TireType) : base(car)
        {
            if (TireType.ToLower() == "soft")
            {
                _multiplier = 1.1;
            }
            if (TireType.ToLower() == "medium")
            {
                _multiplier = 1;
            }
            if (TireType.ToLower() == "hard")
            {
                _multiplier = 0.9;
            }
        }

        public override double calculateTopSpeed()
        {
            return base.calculateTopSpeed() * _multiplier;
        }

        public override string getCarModel()
        {
            return base.getCarModel() + " med ekstra hestekræfter";
        }
        public override double getCost()
        {
            return base.getCost();
        }
    }
}

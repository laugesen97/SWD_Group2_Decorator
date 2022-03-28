using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator
{
    class AddTireType : Decorator
    {
        double Multiplier;
        public AddTireType(Car car, string TireType) : base(car)
        {
            if (TireType.ToLower() == "soft")
            {
                Multiplier = 1.1;
            }
            if (TireType.ToLower() == "medium")
            {
                Multiplier = 1;
            }
            if (TireType.ToLower() == "hard")
            {
                Multiplier = 0.9;
            }
        }

        public override double calculateTopSpeed()
        {
            return base.calculateTopSpeed() * Multiplier;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator.Decorators
{
    class PremiumArmrestDecorator : Decorator
    {
        private double _addedPrice;
        public PremiumArmrestDecorator(Car car, double addedPrice) : base(car)
        {
            this._addedPrice = addedPrice;
        }

        public override double calculateTopSpeed()
        {
            return base.calculateTopSpeed();
        }

        public override string getCarModel()
        {
            return base.getCarModel() + " med premium armlæn";
        }
        public override double getCost()
        {
            return base.getCost() + _addedPrice;
        }
    }
}

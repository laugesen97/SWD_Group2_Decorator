using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator.Decorators
{
    class ImprovedStereoDecorator : Decorator
    {
        double _addedPrice;
        public ImprovedStereoDecorator(Car car, double AddedPrice) : base(car)
        {
            _addedPrice = AddedPrice;
        }
        public override double calculateTopSpeed()
        {
            return base.calculateTopSpeed();
        }

        public override string getCarModel()
        {
            return base.getCarModel() + " med forbedret stereoanlæg og subwoofer i bagagerummet";
        }
        public override double getCost()
        {
            return base.getCost() + _addedPrice;
        }
    }
}

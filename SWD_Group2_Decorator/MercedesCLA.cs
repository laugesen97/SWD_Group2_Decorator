using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator
{
    public class MercedesCLA : Car
    {
        public string Model { get; set; }
        public double HorsePower { get; set; }
        public double Cost { get; set; }
        public override double calculateTopSpeed()
        {
            return HorsePower * 12;
        }

        public override string getCarModel()
        {
            return Model;
        }
        public override double getCost()
        {
            return Cost;
        }
    }
}

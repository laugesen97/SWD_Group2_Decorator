using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator
{
    public abstract class Car
    {
        public abstract string getCarModel();
        public abstract double calculateTopSpeed();
        public abstract double getCost();
    }
}

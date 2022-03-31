using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Group2_Decorator
{
    abstract class Decorator : Car
    {
        protected Car _car;
        public Decorator(Car car)
        {
            this._car = car;
        }
        public void SetComponent(Car car)
        {
            this._car = car;
        }

        public virtual string getCarModel()
        {
            if (this._car != null) return this._car.getCarModel();   
            else return String.Empty;
           
        }
        public virtual double calculateTopSpeed()
        {
            if (this._car != null) return this._car.calculateTopSpeed();
            else return 0;
           
        }
        public virtual double getCost()
        {
            if (this._car != null) return this._car.getCost();
            else return 0;
        }
    }
}

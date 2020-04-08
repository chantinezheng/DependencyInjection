using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIByNinject
{
    public interface IVehicle
    {
        void Owns();
    }
    class Car:IVehicle
    {
        public void Owns()
        {
            Console.WriteLine("I Owns a Car.");
        }
    }

    public class Kate
    {
        IVehicle objVehicle = null;
        public Kate(IVehicle tmpVehicle)
        {
            this.objVehicle = tmpVehicle;
        }
        public void Drive()
        {
            this.objVehicle.Owns();
        }
    }
}

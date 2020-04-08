using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DIByNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninject.IKernel kernal = new StandardKernel();
            kernal.Bind<IVehicle>().To<Car>();
            var instance = kernal.Get<Kate>();
            instance.Drive();
            Console.ReadLine();           
        }
    }
}

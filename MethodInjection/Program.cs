using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            c.Run(new Service());
            Console.ReadKey();
        }
    }

    public interface ISet
    {
        void Print();
    }
    public class Service:ISet
    {
        public void Print()
        {
            Console.WriteLine("Print by Service Method");
        }
    }

    public class Client
    {
        private ISet _set;
        public void Run(ISet service)
        {
            this._set = service;
            Console.WriteLine("Start");
            this._set.Print();
        }
    }
}

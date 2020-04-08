using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            ICaller ic = new Service();

            //Set property of client class
            //This is the main trick. It will define which function need to call
            c.CallService = ic;

            c.Start();
            Console.ReadLine();
        }
    }

    public interface ICaller
    {
        void Serve();
    }

    public class Service : ICaller
    {
        public void Serve()
        {
            Console.WriteLine("Service Started");
        }
    }
    public class Client
    {
        private ICaller s;
        public ICaller CallService
        {
            set
            {
                this.s = value;
            }
        }
        public void Start()
        {
            Console.WriteLine("Service is called by client");
            this.s.Serve();
        }
    }


}

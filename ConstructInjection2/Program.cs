using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructInjection2
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonPerson c = new CommonPerson(new Minister());
            c.Start();
            Console.ReadLine();
        }
    }
    public interface ISecrutary
    {
        void Service();
    }
    public class Minister:ISecrutary
    {
        public void Service()
        {
            Console.WriteLine("Service by Minister");
        }
    }

    /*
     * You can see that when an object of the CommonPerson class 
     * calls the minister class, it uses the ISectuary interface, 
     * now even if we change something in the Minister Class, it will\
     * not effect the CommonPerson class.
     */
    public class CommonPerson
    {
        private ISecrutary _service;
        public CommonPerson(ISecrutary service)
        {
            this._service = service;
        }
        public void Start()
        {
            this._service.Service();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DIByUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<IUniversity, University>();

            Student stu = unitycontainer.Resolve<Student>();
            stu.DisplayResult();


            Console.ReadLine();
        }
    }
}

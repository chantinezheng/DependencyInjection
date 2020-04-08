using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructInjection
{

    public interface IText
    {
        void Print();
    }
    class MyFormat : IText
    {
        public void Print()
        {
            Console.WriteLine("Here is my text format");
        }
    }

    //Construct Injection
    public class ConstructorInjection
    {
        private IText _text;
        public ConstructorInjection(IText text)
        {
            this._text = text; 
        }
        public void Print()
        {
            _text.Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstructorInjection cs = new ConstructorInjection(new MyFormat());
            cs.Print();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIByAutofac
{
    public class OracleDatabase : IDatabase
    {
        public string Name => "oracle";

        public void Delete(string cmdText)
        {
            Console.WriteLine(string.Format("'{0}' is a delete sql in {1}!", cmdText, Name));
        }

        public void Insert(string cmdText)
        {
            Console.WriteLine(string.Format("'{0}' is a insert sql in {1}!", cmdText, Name));
        }

        public void Select(string cmdText)
        {
            Console.WriteLine(string.Format("'{0}' is a query sql in {1}!", cmdText, Name));
        }

        public void Update(string cmdText)
        {
            Console.WriteLine(string.Format("'{0}' is a update sql in {1}!", cmdText, Name));
        }
    }
}

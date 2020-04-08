using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIByAutofac
{
    public interface IDatabase
    {
        string Name { get; }
        void Select(string cmdText);
        void Insert(string cmdText);
        void Update(string cmdText);
        void Delete(string cmdText);
    }
}

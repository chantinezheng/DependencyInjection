using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIByAutofac
{
    //现在我想通过一个用户类来控制操作权限，比如增删改的权限，创建一个用户类
    public interface IMyIdentity
    {
       int Id { get; set; }
    }
    public class User:IMyIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DIByAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*这里通过ContainerBuilder方法RegisterType对DatabaseManager进行注册，
            // * 当注册的类型在相应得到的容器中可以Resolve你的DatabaseManager实例。
            // */
            //var builder = new ContainerBuilder();
            //builder.RegisterType<DatabaseManager>();

            ////法一：
            ////通过AS可以让DatabaseManager类中通过构造函数依赖注入类型相应的接口。
            ////SqlDatabase
            //builder.RegisterType<SqlDatabase>().As<IDatabase>();
            ////修改数据库类型注册为:OracleDatabase
            //// builder.RegisterType<OracleDatabase>().As<IDatabase>();

            ////法二：这边会有问题？？？如何解决？
            ////builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            ////Build()方法生成一个对应的Container实例，这样，就可以通过Resolve解析到注册的类型实例。
            //using (var container=builder.Build())
            //{
            //    var manager = container.Resolve<DatabaseManager>();
            //    manager.Search("SELECT * FORM USER");
            //}

            UsingAuthorize();
            Console.ReadKey();

        }

        static void UsingAuthorize()
        {
            //在构造函数中增加了一个参数User,而Add,Save，Remove增加了权限判断
            //User user = new User { Id = 1, Name = "kate" };
            User user = new User { Id = 1, Name = "hanna" };//为什么这边不会出现"not authorized"的提醒呢？问题出在哪？
            var builder = new ContainerBuilder();
            builder.RegisterType<DatabaseManager2>();
            builder.RegisterType<SqlDatabase>().As<IDatabase>();
            //注册User实例。
            builder.RegisterInstance(user).As<User>();
            //通过Lampda表达式注册
            builder.Register(c => new DatabaseManager2(c.Resolve<IDatabase>(), c.Resolve<User>()));
            using(var container=builder.Build())
            {
                var manager = container.Resolve<DatabaseManager2>();
                manager.Add("Insert into User...");
            }
        }
    }
}

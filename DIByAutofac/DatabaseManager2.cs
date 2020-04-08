using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIByAutofac
{
    class DatabaseManager2
    {
        IDatabase _database;
        User _user;

        public DatabaseManager2(IDatabase database):this(database,null)
        {
            //_database = database;
        }

        public DatabaseManager2(IDatabase database,User user)
        {
            _database = database;
            _user = user;
        }

        public bool IsAuthority()
        {
            bool result = _user != null && _user.Id == 1 && _user.Name == "kate" ? true : false;
            if (!result)
                Console.WriteLine("Not Authority!");
            return result;
        }

        public void Search(string commandText)
        {
            _database.Select(commandText);
        }

        public void Add(string commandText)
        {
            _database.Insert(commandText);
        }

        public void Save(string commandText)
        {
            _database.Update(commandText);
        }

        public void Remove(string commandText)
        {
            _database.Delete(commandText);
        }
    }
}

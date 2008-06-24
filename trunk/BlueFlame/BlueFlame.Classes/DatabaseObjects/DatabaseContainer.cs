using System;
using System.Collections.Generic;
using System.Text;

namespace BlueFlame.Classes.DatabaseObjects
{
    public abstract class DatabaseContainer
    {
        private static MySql.MySqlWrapper _mysql;

        public static MySql.MySqlWrapper MySql
        {
            get 
            {
                if (_mysql == null) throw new Exception("The database has not been initialized yet.");
                return _mysql; 
            }
            set { _mysql = value; }
        }
    }
}

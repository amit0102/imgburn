using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using BlueFlame.Classes.MySql;

namespace BlueFlame.Classes.DatabaseObjects
{
    public class License
    {
        private string _key;
        private bool _multi;
        private bool _distributed;
        private string _instertdate;
        private User _user;
        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public string Key
        {
            get { return _key; }
        }
  
        public bool Multi
        {
            get { return _multi; }
            set { _multi = value; }
        }
  
        public bool Distributed
        {
            get { return _distributed; }
            set { _distributed = value; }
        }  

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Date
        {
            get { return _instertdate; }
            set { _instertdate = value; }
        }

        public License(string key, bool multi, bool distributed, string insertdate,User user, Product product)
        {
            _user = user;
            _distributed = distributed;
            _multi = multi;
            _product = product;
            _key = key;
            _instertdate = insertdate;
        }

        #region IDatabaseObject<License> Member
        public bool Save()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.License_Save,
                    new MySqlDataParameter("distributed", (_distributed) ? 1 : 0),
                    new MySqlDataParameter("multi", (_multi) ? 1 : 0),
                    new MySqlDataParameter("insertdate", _instertdate),
                    new MySqlDataParameter("file", _product.FileId),
                    new MySqlDataParameter("productid", _product.ProductId),
                    new MySqlDataParameter("licensekey", _key));

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false; 
            }
        }

        public bool Remove()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.License_Remove,
                    new MySqlDataParameter("file", _product.FileId),
                    new MySqlDataParameter("productid", _product.ProductId),
                    new MySqlDataParameter("licensekey", _key));

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Create()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.License_Create,
                    new MySqlDataParameter("distributed", (_distributed) ? 1 : 0),
                    new MySqlDataParameter("multi", (_multi) ? 1 : 0),
                    new MySqlDataParameter("insertdate", _instertdate),
                    new MySqlDataParameter("file", _product.FileId),
                    new MySqlDataParameter("productid", _product.ProductId),
                    new MySqlDataParameter("licensekey", _key));

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
        }

        #endregion
    }
}

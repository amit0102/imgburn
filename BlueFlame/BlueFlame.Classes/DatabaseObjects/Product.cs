using System;
using System.Collections.Generic;
using System.Text;
using BlueFlame.Classes.DatabaseObjects;
using BlueFlame.Classes.MySql;

namespace BlueFlame.Classes.DatabaseObjects
{
    public class Product
    {
        private string _name;
        private string _description;
        private string _fileId;
        private string _productId;
        private string _licenseFromFile;
        private string _licenseFromProductId;

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }      

        public string ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string LicenseFromFile
        {
            get { return _licenseFromFile; }
            set { _licenseFromFile = value; }
        }
        
        public string LicenseFromProductId
        {
            get { return _licenseFromProductId; }
            set { _licenseFromProductId = value; }
        }
        #endregion

        public Product()
        {
            _name = "";
            _description = "";
            _fileId = "";
            _productId = "";
            _licenseFromFile = null;
            _licenseFromProductId = null;
        }

        public Product(string name, string description, string fileid, string productid)
        {
            _name = name;
            _description = description;
            _fileId = fileid;
            _productId = productid;
            _licenseFromFile = null;
            _licenseFromProductId = null;
        }

        public Product(string name, string description, string fileid, string productid, string licnsefromfile, string licensefromproductid)
        {
            _name = name;
            _description = description;
            _fileId = fileid;
            _productId = productid;
            _licenseFromFile = licnsefromfile;
            _licenseFromProductId = licensefromproductid;
        }


        #region IDatabaseObject<Product> Member

        public bool Save()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.Product_Save,
                    new MySqlDataParameter("productname", _name),
                    new MySqlDataParameter("productdescription", _description),
                    new MySqlDataParameter("licensefromfile", _licenseFromFile),
                    new MySqlDataParameter("licensefromproductid", _licenseFromProductId),
                    new MySqlDataParameter("file", _fileId),
                    new MySqlDataParameter("productid", _productId));
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
                    SqlStatements.Product_Remove,
                    new MySqlDataParameter("file", _fileId),
                    new MySqlDataParameter("productid", _productId));
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
                    SqlStatements.Product_Create,
                    new MySqlDataParameter("productname", _name),
                    new MySqlDataParameter("productdescription", _description),
                    new MySqlDataParameter("licensefromfile", _licenseFromFile),
                    new MySqlDataParameter("licensefromproductid", _licenseFromProductId),
                    new MySqlDataParameter("file", _fileId),
                    new MySqlDataParameter("productid", _productId));
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

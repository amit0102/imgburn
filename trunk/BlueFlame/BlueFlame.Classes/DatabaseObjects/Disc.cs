using MySql.Data.MySqlClient;
using BlueFlame.Classes.MySql;
using System.Collections.Generic;
namespace BlueFlame.Classes.DatabaseObjects
{
    public class Disc
    {
        private MediaType _type;
        /// <summary>
        /// Returns the media type of the image file
        /// </summary>
        public MediaType MediaType
        {
            get { return _type; }
        }
	
        private string _productId;
        /// <summary>
        /// Returns the database product id for this product 
        /// </summary>
        public string ProductId
        {
            get { return _productId; }
        }

        private string _fileId;
        /// <summary>
        /// Returns the database image file id for this product
        /// </summary>
        public string FileId
        {
            get { return _fileId; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
        }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
	

        /// <summary>
        /// Creates a new wrapper for a primary key of an image file in the database,
        /// containing a product id, file id and media type
        /// </summary>
        /// <param name="fileid">The file id from the database, eg. 2132.3</param>
        /// <param name="productid">The product id from the database, eg. 1</param>
        /// <param name="type">The media type of the disc. This can either be a DVD or a CD</param>
        public Disc(string fileid, string productid, MediaType type)
        {
            _fileId = fileid;
            _productId = productid;
            _type = type;
        }

        public Disc(string fileid, string productid, string fullname, MediaType type)
        {
            _fileId = fileid;
            _productId = productid;
            _type = type;
            _fullName = fullname;
        }

        public bool Remove()
        {
            List<Product> products = new List<Product>();
            using(MySqlDataReader reader = DatabaseContainer.MySql.Query(
                SqlStatements.Disc_GetAllProducts,
                new MySqlDataParameter("file", _fileId)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.FileId = _fileId;
                        product.ProductId = reader["productid"].ToString();
                        products.Add(product);
                    }
                }
            }

            foreach (Product product in products) product.Remove();

            Image image = new Image();
            image.FileName = _fileId;
            return image.Remove();
        }
    }
}

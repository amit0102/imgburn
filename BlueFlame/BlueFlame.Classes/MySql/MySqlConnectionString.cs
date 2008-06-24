using System.Diagnostics;
namespace BlueFlame.Classes.MySql
{
    public class MySqlConnectionString
    {
        private string _internalString;
        public MySqlConnectionString(string user, string pass, string server, int port, string database)
        {
            _internalString = string.Concat(new object[] { "Database=", database, ";Password=", pass, ";User ID=", user, ";Server=", server, ";Port=", port, ";" });
        }

        public MySqlConnectionString(string connectionString)
        {
            _internalString = connectionString;
        }

        public override string ToString()
        {
            return _internalString;
        }

        public string Server{   get { return ExtractByKeyWord("server");    }}
        public string Port {    get { return ExtractByKeyWord("port");      }}
        public string Database{ get { return ExtractByKeyWord("database");  }}
        public string User {    get { return ExtractByKeyWord("user id");   }}
        public string Password{ get { return ExtractByKeyWord("password");  }}

        private string ExtractByKeyWord(string keyWord)
        {
            string keyword = keyWord.ToLower();
            int indexKeyWord = _internalString.ToLower().IndexOf(keyword);
            if (indexKeyWord == -1) return "";

            indexKeyWord = _internalString.IndexOf('=', indexKeyWord) + 1;

            int indexValue = _internalString.IndexOf(';', indexKeyWord);
            if (indexValue == -1) return _internalString.Substring(indexKeyWord);
            return _internalString.Substring(indexKeyWord, indexValue - indexKeyWord);
        }
    }
}

 
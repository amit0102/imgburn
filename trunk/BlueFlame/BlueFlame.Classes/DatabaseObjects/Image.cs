using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BlueFlame.Classes.DatabaseObjects.Enums;
using MySql.Data.MySqlClient;
using BlueFlame.Classes.MySql;

namespace BlueFlame.Classes.DatabaseObjects
{
    public class Image
    {
        private string _filename;
        private string _path;
        private string _ext;
        private string _language;
        private string _date;
        private bool _isdvd;

        #region Properties
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }
        
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Extension
        {
            get { return _ext; }
            set { _ext = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        } 

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public bool IsDvd
        {
            get { return _isdvd; }
            set { _isdvd = value; }
        }
        #endregion

        public Image()
        {
            _filename = "";
            _path = "";
            _ext = "";
            _language = "";
            _date = "";
            _isdvd = false;
        }

        public Image(string filename, string path, string ext, string lang, string date, bool isdvd)
        {
            _filename = filename;
            _path = path;
            _ext = ext;
            _language = lang;
            _date = date;
            _isdvd = isdvd;
        }

        #region IDatabaseObject<Image> Member
        public bool Create()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.Image_Create,
                    new MySqlDataParameter("file", _filename),
                    new MySqlDataParameter("lang", _language),
                    new MySqlDataParameter("date", _date),
                    new MySqlDataParameter("path", _path),
                    new MySqlDataParameter("ext", _ext),
                    new MySqlDataParameter("dvdmedia", ((_isdvd) ? 1 : 0)));
                return true;
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                DatabaseContainer.MySql.Statement(
                    SqlStatements.Image_Save,
                    new MySqlDataParameter("file", _filename),
                    new MySqlDataParameter("lang", _language),
                    new MySqlDataParameter("date", _date),
                    new MySqlDataParameter("path", _path),
                    new MySqlDataParameter("ext", _ext),
                    new MySqlDataParameter("dvdmedia", ((_isdvd) ? 1 : 0)));
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
                    SqlStatements.Image_Remove,
                    new MySqlDataParameter("file", _filename));
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

using System;
namespace BlueFlame.Classes.DatabaseObjects
{
    public class User
    {
        private string _userId;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private string _domain;

        public string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }

        private string _displayName;

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public User(string userid, string domain, string displayname)
        {
            _userId = userid;
            _domain = domain;
            _displayName = displayname;
        }

        #region IDatabaseObject<User> Member



        #endregion
    }
}

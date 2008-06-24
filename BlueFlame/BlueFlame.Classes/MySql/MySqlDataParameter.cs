namespace BlueFlame.Classes.MySql
{
    /// <summary>
    /// Specifies a named parameter
    /// </summary>
    public class MySqlDataParameter
    {
        private string _key;
        /// <summary>
        /// The key of the named parameter
        /// </summary>
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private object _value;
        /// <summary>
        /// The Value of the named mysql parameter
        /// </summary>
        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Constructor. Sets the parameter identifier '?' for a specified parameter key
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public MySqlDataParameter(string Key, object Value)
        {
            if (!Key[0].Equals("?")) _key = "?" + Key;
            else _key = Key;
            _value = Value;
        }
    }
}
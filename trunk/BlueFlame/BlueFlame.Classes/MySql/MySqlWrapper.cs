using System;
using System.Collections.Generic;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;


namespace BlueFlame.Classes.MySql
{
    public class MySqlWrapper
    {
        private MySqlConnectionString _connectionString;
        private MySqlConnection _connection;
        private MySqlCommand _command;

        /// <summary>
        /// Constructor, establishes the Database Connection using a provided connection string
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        public MySqlWrapper(string connectionString)
        {
            _connectionString = new MySqlConnectionString(connectionString);
            _connection = new MySqlConnection(_connectionString.ToString());
            _connection.Open();
        }


        /// <summary>
        /// Constructor, accepts the Parameters for the database connection
        /// </summary>
        /// <param name="user">The username for the database</param>
        /// <param name="pass">The password for the database</param>
        /// <param name="server">The database server</param>
        /// <param name="port">The port for the connection</param>
        /// <param name="database">The name of the database</param>
        public MySqlWrapper(string user, string pass, string server, int port, string database)
        {
            _connectionString = new MySqlConnectionString(user, pass, server, port, database);
            _connection = new MySqlConnection(_connectionString.ToString());
            _connection.Open();
        }
        
        //http://dev.mysql.com/doc/refman/5.0/en/connector-net-using-prepared.html        
        /// <summary>
        /// Executes a database query
        /// </summary>
        /// <param name="command">The MySQL Statement to execute</param>
        /// <param name="parameters">A list of MySqlDataParameter Objects to inject in the statement, making it a prepared statement. This can be left empty. Parameters have to be marked with '?parameter' in the statement. See the mysql reference manual for further detail.</param>
        /// <returns>A MySqlDataReader als a resultset that can be iterated.</returns>
        public MySqlDataReader Query(string command, params MySqlDataParameter[] parameters)
        {
            if (command == null || _connection == null) return null;
            _command = new MySqlCommand(command, _connection);
            _command.Prepare();

            foreach (MySqlDataParameter param in parameters)
                _command.Parameters.AddWithValue(param.Key, param.Value);

            return _command.ExecuteReader();
        }

        /// <summary>
        /// Executes a statement. It desn't return anything, so it can be used for INSERT, UPDATE, etc. statements.
        /// </summary>
        /// <param name="command">The MySQL Statement to execute</param>
        /// <param name="parameters">A list of MySqlDataParameter Objects to inject in the statement, making it a prepared statement. This can be left empty. Parameters have to be marked with '?parameter' in the statement. See the mysql reference manual for further detail.</param>
        public void Statement(string command, params MySqlDataParameter[] parameters)
        {
            if (command == null || _connection == null) return;
            _command = new MySqlCommand(command, _connection);
            _command.Prepare();

            foreach (MySqlDataParameter param in parameters)
                _command.Parameters.AddWithValue(param.Key, param.Value);

            _command.ExecuteNonQuery();
        }
    }
}

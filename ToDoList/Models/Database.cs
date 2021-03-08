using System;
using MySql.Data.MySqlClient; //imported namespace by MySqlConnector
using ToDoList;

namespace ToDoList.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn; // object uses connection string from Startup.cs
    }
  }
}

//MySqlConnection class tells our app how to connect to our database
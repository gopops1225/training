using MonsterApp.Data_Access.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access
{
  public partial class AdoData
  {
    public bool InsertGender(Gender gender)
    {
      var name = new SqlParameter("name", gender.Name);
      var query = "insert into Monster.Gender(GenderName, Active) values(@name, 1)";

      /* SqlCommand cmd;
       int result;

       using (var connection = new SqlConnection(connectionString))
       {
         connection.Open();
         cmd = new SqlCommand(query, connection);
         cmd.Parameters.Add(name);
         result = cmd.ExecuteNonQuery();
       }*/
      return InsertData(query, name) == 1;
    }
    //---------------------------------------------------------------------

    public bool InsertTitle(Title title)
    {
      var name = new SqlParameter("name", title.TitleName);
      var query = "insert into Monster.Title(TitleName, Active) values(@name, 1)";


      return InsertData(query, name) == 1;
    }

    //------------------------------------------------------------
    public bool InsertType(MonsterType type)
    {
      var name = new SqlParameter("name", type.Name);
      var query = "insert into Monster.Gender(TypeName, Active) values(@name, 1)";

      return InsertData(query, name) ==1;
    }
    //--------------------------------------------------------------------------------------

    private int InsertData(string query, params SqlParameter[] parameters)
    {
      SqlCommand cmd;
      int result;

      using (var connection = new SqlConnection(connectionString))
      {
        connection.Open();
        cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddRange(parameters);
        result = cmd.ExecuteNonQuery();
      }
      return result;
    }
  }

  }


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
    public bool UpdateGender(Gender gender)
    {
      SqlCommand cmd;
      int result;

      var query = "update Monster.Gender set GenderName =@name, Active = @active where GenderId = @id";
      var name = new SqlParameter("name", gender.GenderName);
      var active = new SqlParameter("active", gender.Active ? 1 : 0);
      var id = new SqlParameter("id", gender.GenderId);

      using (var connection = new SqlConnection(connectionString))
      {
        connection.Open();
        cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddRange(new SqlParameter[] { name, active, id });
        result = cmd.ExecuteNonQuery();
      }
      return result > 0;
    }

    public int UpdateData(string query, params SqlParameter[] parameters)
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

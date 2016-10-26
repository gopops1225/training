using MonsterApp.Data_Access.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access
{
  public class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;;


    
    public List<models.Gender> GetGender()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Gender;");
        var genders = new List<Gender>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          genders.Add(new Gender
          { GenderID = int.Parse(row[0].ToString()),
            GenderName = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }
      }
      catch (Exception)
      {
        return null;
      }
      

      return new List<Gender>();
    }
 
    public List<MonsterType> GetMonsterTypes()
    {
      throw new NotImplementedException("todo");
    }

    public List<Title> GetTitle()
    {
      throw new NotImplementedException("todo");
    }

    
    private DataSet GetDataDisconnected(string query)
    {
      SqlDataAdapter da;
      DataSet ds;
      SqlCommand cmd;

      using (var connection = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, connection);
        da = new SqlDataAdapter();
        ds = new DataSet();

        da.Fill(ds);

      }

      return ds;
    }


  }

  internal class sqlDataAdapter
  {
    private SqlCommand cmd;

    public sqlDataAdapter(SqlCommand cmd)
    {
      this.cmd = cmd;
    }
  }
}

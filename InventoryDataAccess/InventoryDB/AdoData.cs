using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using InventoryDB.models;

namespace InventoryDB
{
  public partial class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;

    private int ControlData(string query, params SqlParameter[] parameters)
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


    public bool InsertItem(Inventory good)
    {
      var item = new SqlParameter("item", good.Item);
      var query = "insert into Storage.Inventory(Item, Complete) values(@item, 1)";


      return ControlData(query, item) == 1;
    }

    public bool UpdateItem(Inventory good)
    {

      var query = "update Storage.Inventory set Item =@item, complete = @comp where Id = @id";
      var item = new SqlParameter("name", good.Item);
      var comp = new SqlParameter("comp", good.complete ? 1 : 0);
      var id = new SqlParameter("id", good.Id);

      return ControlData(query, item, comp, id) == 1;
    }


    public bool UpdateStatus(Inventory good)
    {

      var query = "update Storage.Inventory set complete = @comp where Id = @id";
      var comp = new SqlParameter("comp", good.complete ? 1 : 0);
      var id = new SqlParameter("id", good.Id);

      return ControlData(query, comp, id) == 1;
    }





  }
}

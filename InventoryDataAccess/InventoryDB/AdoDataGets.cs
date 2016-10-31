using InventoryDB.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDB
{
  public partial class AdoData
  {

    private DataSet GetDataDisconnected(string query)
    {
      SqlDataAdapter da;
      DataSet ds;
      SqlCommand cmd;

      using (var connection = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, connection);
        connection.Open();
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        da.Fill(ds);

      }

      return ds;
    }

    public List<Inventory> GetItem()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Storage.Inventory;");
        var items = new List<Inventory>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          items.Add(new Inventory
          {
            Id = int.Parse(row[0].ToString()),
            Item = row[1].ToString(),
            complete = bool.Parse(row[2].ToString())
          });
        }
      }
      catch (Exception)
      {
        return null;
      }
      return new List<Inventory>();
    }

    public List<Inventory> GetInComplete()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Storage.Inventory where complete = 1;");
        var items = new List<Inventory>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          items.Add(new Inventory
          {
            Id = int.Parse(row[0].ToString()),
            Item = row[1].ToString(),
            complete = bool.Parse(row[2].ToString())
          });
        }
      }
      catch (Exception)
      {
        return null;
      }
      return new List<Inventory>();
    }

    public List<Inventory> GetIncomplete()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Storage.Inventory where complete = 0;");
        var items = new List<Inventory>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          items.Add(new Inventory
          {
            Id = int.Parse(row[0].ToString()),
            Item = row[1].ToString(),
            complete = bool.Parse(row[2].ToString())
          });
        }
      }
      catch (Exception)
      {
        return null;
      }
      return new List<Inventory>();
    }




  }
}

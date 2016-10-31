using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDB.models
{
  public class Inventory
  {
    public int Id { get; set; }
    public string Item { get; set; }
    public bool complete { get; set; }

  }
}

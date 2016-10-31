using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access.models
{
  /// <summary>
  /// The gender of the monster
  /// </summary>

  public class Gender
  {
    public int  GenderId { get; set; }
    public string Name { get; set; }
    public bool Active { get; set;  }
  }
}

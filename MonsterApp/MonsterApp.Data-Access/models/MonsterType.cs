using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access.models
{
  /// <summary>
  /// The type of Monsters you can have in movies.
  /// </summary>

  public class MonsterType
  {
    public int MonsterTypeId { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
  }
}

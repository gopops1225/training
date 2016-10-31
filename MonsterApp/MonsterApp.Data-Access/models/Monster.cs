using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access.models
{
  public class Monster
  {
    /// <summary>
    /// The monster
    /// </summary>
    /// 
      public int MonsterId { get; set; }
      public int TitleId { get; set; }
      public string Name { get; set; }
      public int TypeId { get; set; }
      public int GenderId { get; set; }
      public string PicturePath { get; set; }
      public bool Active { get; set; }
    
  }
}

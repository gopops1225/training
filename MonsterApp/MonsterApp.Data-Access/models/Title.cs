﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.Data_Access.models
{
  /// <summary>
  /// The title of the monster
  /// </summary>

  public class Title
  {
    public int TitleId { get; set; }
    public string TitleName { get; set; }
    public bool Active { get; set; }
  }
}

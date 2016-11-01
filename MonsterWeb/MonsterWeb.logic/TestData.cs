using MonsterApp.DataClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.logic
{
  public class TestData
  {
    private MonsterService data = new MonsterService();

    public void Getenders()
    {
      data.GetGenders();
    }


  }
}

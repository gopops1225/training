using MonsterWeb.logic.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterWeb.Client
{
  
  public class DataService
  {
    private MonsterServiceClient msc = new MonsterServiceClient();

    public async void GetGenders()
    {
      await msc.GetGendersAsync();
    }

  }
}
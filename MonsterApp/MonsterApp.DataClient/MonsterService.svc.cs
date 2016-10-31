using  m= MonsterApp.Data_Access;
using MonsterApp.DataClient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MonsterApp.DataClient
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonsterService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select MonsterService.svc or MonsterService.svc.cs at the Solution Explorer and start debugging.
  public class MonsterService : IMonsterService
  {
    private m.AdoData data = new m.AdoData();

    public List<GenderDAO> GetGenders()
    {

      var g = new List<GenderDAO>();
      foreach(var gender in data.GetGender())
      {
        g.Add(GenderMap.MapToGenderDAO(gender));
      }
      return g;
    }

    public List<MonsterTypeDAO> GetMonsterTypes()
    {
      throw new NotImplementedException();
    }

    public List<TitleDAO> GetTitles()
    {
      throw new NotImplementedException();
    }

  }
}

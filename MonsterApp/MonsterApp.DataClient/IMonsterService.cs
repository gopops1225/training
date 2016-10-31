using MonsterApp.DataClient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DataClient
{
  /// <summary>
  /// 
  /// </summary>
  [ServiceContract]
  public interface IMonsterService
  {
    [OperationContract()]
    List<GenderDAO> GetGenders();

    [OperationContract]
    List<MonsterTypeDAO> GetMonsterTypes();

    [OperationContract]
    List<TitleDAO> GetTitles();
  }
}

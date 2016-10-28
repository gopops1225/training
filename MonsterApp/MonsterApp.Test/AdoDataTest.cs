using MonsterApp.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Test
{
  public partial class AdoDataTest
  {
    [Fact]
    public void Test_GetGenders()
    {
      AdoData data = new AdoData();

      var actual = data.GetGender();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_TopGenders()
    {
      AdoData data = new AdoData();

      Console.WriteLine(data.GetTopGender());
    }
  }
}

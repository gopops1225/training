using MonsterApp.Data_Access;
using MonsterApp.Data_Access.models;
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
    private Gender gender;
    public AdoDataTest()
    {
      gender = new Gender() { Name = "TestGender" };
    }
    [Fact]
    public void Test_InsertGender()
    {
      var data = new AdoData();
      var actual = data.InsertGender(gender);

      Assert.True(actual);
    }
  }
}

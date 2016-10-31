using MonsterApp.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Test
{
 public  class EfDataTest
  {/*
    [Fact]
    public void Test_GetGender()
    {
      var data = new EfData();

      var actual = data.GetGender();

      Assert.NotNull(actual);
    }
    [Fact]
    public void Test_InsertGender()
    {
      var data = new EfData();
      var expected = new Gender() { GenderName = "Martian", Active = true };

      //var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);
      var actual = data.InsertGender(expected);
      Assert.True(actual);

    }
    */
    [Fact]
    public void Test_InsertMonster()
    {
     
      var data = new EfData();
      var bad = new Monster() {  GenderId = 2, TitleId = 1, TypeId = 2, Name = "Big Ugly",  PicturePath = "", Actve = true };

      var actual = data.ChangeMonster(bad, System.Data.Entity.EntityState.Added);

      Assert.NotNull(actual);
    }

  }
}

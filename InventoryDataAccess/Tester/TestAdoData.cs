using InventoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tester
{
  public class TestAdoData
  {
    [Fact]
    public void Test_GetItems()
    {
      AdoData data = new AdoData();

      var actual = data.GetItem();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_Complete()
    {
      AdoData data = new AdoData();

      Console.WriteLine(data.GetInComplete());
    }

    [Fact]
    public void Test_incomplete()
    {
      AdoData data = new AdoData();

      Console.WriteLine(data.GetInComplete());
    }
  }
}

using MonsterApp.Data_Access;
using MonsterApp.DataClient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
  public class GenderMap
  {
    public static GenderDAO MapToGenderDAO(Gender gender)
    {
      var g = new GenderDAO();
      g.Id = gender.GenderId;
      g.Name = gender.GenderName;

      return g;
    }

    public static Gender MapToGender(GenderDAO gender)
    {
      var g = new Gender();
      g.GenderId = gender.Id;
      g.GenderName = gender.Name;

      return g;
    }

    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach(var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }
      return ob;
    }
  }
}
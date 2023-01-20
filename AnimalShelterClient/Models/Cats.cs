using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    public static List<Cat> GetCats()
    {
      var apiCallTask = ApiHelper.GetAllCats();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(jsonResponse.ToString());

      return catList;
    }

    public static Cat GetCatDetails(int id)
    {
      var apiCallTask = ApiHelper.GetCats(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Cat cat = JsonConvert.DeserializeObject<Cat>(jsonResponse.ToString());

      return cat;
    }

    public static void PostCats(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(cat);
      ApiHelper.PostCats(jsonCat);
    }

    public static void PutCats(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(cat);
      ApiHelper.PutCats(cat.CatId, jsonCat);
    }

    
  }
}
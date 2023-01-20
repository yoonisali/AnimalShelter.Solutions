using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    public static List<Dog> GetDogs()
    {
      var apiCallTask = ApiHelper.GetAllDogs();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Dog> dogList = JsonConvert.DeserializeObject<List<Dog>>(jsonResponse.ToString());

      return dogList;
    }

    public static Dog GetDogDetails(int id)
    {
      var apiCallTask = ApiHelper.GetDogs(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Dog dog = JsonConvert.DeserializeObject<Dog>(jsonResponse.ToString());

      return dog;
    }
  }
}
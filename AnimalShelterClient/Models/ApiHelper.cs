using System.Threading.Tasks;
using RestSharp;

namespace AnimalShelterClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAllDogs()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/dogs", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllCats()
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/cats", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> GetDogs(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/dogs/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> GetCats(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/cats/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

  }
}
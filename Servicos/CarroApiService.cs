using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using aec_mvc_entity_framework.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace aec_mvc_entity_framework.Servicos
{
  public class CarroApiService
  {
    public static async Task<List<Carro>> GetCarros()
    {
      HttpClient http = new HttpClient();
      var response = await http.GetAsync($"{Program.ApiHost}/carros");
      if(response.IsSuccessStatusCode)
      {
        var resultado = response.Content.ReadAsStringAsync().Result;
        var carros = JsonConvert.DeserializeObject<List<Carro>>(resultado);
        return carros;
      }

      return new List<Carro>();
    }
  }
}
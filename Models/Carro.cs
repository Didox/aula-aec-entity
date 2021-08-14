using System;

namespace aec_mvc_entity_framework.Models
{
    public record Carro
    {
      public int Id { get;set; }
      public string Nome { get;set; }
      public string Modelo { get;set; }
      public int marca_id { get; set; }
      public int Ano { get;set; }
    }
}

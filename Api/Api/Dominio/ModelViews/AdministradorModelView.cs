using System.Text.Json.Serialization;
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews
{
   public record AdministradorModelView
   {
      public int Id { get; set; } = default!;
      public string Email { get; set; } = default!;
      public string Perfil { get; set; } = default!;
     
     [JsonIgnore]
      public string Senha { get; set; } = default!;
   }
}
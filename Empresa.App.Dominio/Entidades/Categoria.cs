using Dominio;
using Directivo;

namespace Empresa.App.Dominio
{
     public class Categoria:Directivo
     {
         public int Id {get;set;}
         public string NombreCat {get;set;}
         public string Ciudad {get;set;}
     }
}
using Dominio;
using Empleado;

namespace Empresa.App.Dominio
{
     public class Directivo:Empleado
     {
         public string Id {get;set;}
         public int Categoria {get;set;}
     }
}
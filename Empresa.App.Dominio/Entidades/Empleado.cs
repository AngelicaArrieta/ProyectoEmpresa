using Dominio;
using Persona;

namespace Empresa.App.Dominio
{
     public class Empleado:Persona
     {
         public string IdEmpleado {get;set;}
         public int SueldoBruto {get;set;}
     }
}
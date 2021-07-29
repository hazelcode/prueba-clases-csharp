using System;

namespace Prueba_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos DatosPersona = new Datos();
            DatosPersona.Nombre = "Beto";
            DatosPersona.Edad = 21;
            DatosPersona.Pais = "Mexico";
            DatosPersona.MostrarDatos();
            Console.Read();
        }
    }
}

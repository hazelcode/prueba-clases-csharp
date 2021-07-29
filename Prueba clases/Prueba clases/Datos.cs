using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_clases
{
    class Datos
    {
        public string Nombre;
        public int Edad;
        public string Pais;

        public void MostrarDatos()
        {
            string output = "El nombre es {0}, tiene {1} años y vive en {2}";
            output = string.Format(output, Nombre, Edad, Pais);
            Console.WriteLine(output);
        }
        }
    }

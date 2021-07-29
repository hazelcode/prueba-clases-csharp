using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_clases
{
    class versionService
    {
        public string tipoDeVersion = "Release";
        public string version = "v1.1";
        public string descargasDeVersion = "https://github.com/tacozyt/prueba-clases-csharp/releases";

        public void mostrar()
        {
            string output = "Versión del programa: {0} {1}. Descargas: {2}";
            output = string.Format(output, tipoDeVersion, version, descargasDeVersion);
            Console.WriteLine(output);
        }
    }
}

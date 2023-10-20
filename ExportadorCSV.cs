using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ExportadorCSV
    {
        public void Exportar(List<Libro> libros, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo, false, Encoding.UTF8))
            {
                sw.WriteLine("Autor,Genero");

                foreach (var libro in libros)
                {
                    sw.WriteLine($"{libro.Autor},{libro.Genero}");
                }
            }
        }
    }
}

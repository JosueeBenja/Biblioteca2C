﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        public string Titulo { get; set;}
        public string Autor { get; set; }
        public string Genero { get; set; }

        public Libro (string Titulo, string Autor, string Genero) 
        { 
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Genero = Genero;
        } 
    }
}

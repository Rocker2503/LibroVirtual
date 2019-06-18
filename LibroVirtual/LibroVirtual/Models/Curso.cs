using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibroVirtual.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string Tipo { get; set; }
        public char Letra { get; set; }
        [Display(Name = "Año")]
        public int Ano { get; set; }

        public Curso(int id, int nivel, string tipo, char letra, int ano)
        {
            Id = id;
            Nivel = nivel;
            Tipo = tipo;
            Letra = letra;
            Ano = ano;
        }

        public Curso()
        {

        }
    }
}

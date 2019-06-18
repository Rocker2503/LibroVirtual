using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibroVirtual.Models
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Horas Semanales")]
        public int HorasSemanales { get; set; }
        public int IdCurso { get; set; }

        public Asignatura(int id, string nombre, int horasSemanales, int idCurso)
        {
            Id = id;
            Nombre = nombre;
            HorasSemanales = horasSemanales;
            IdCurso = idCurso;
        }

        public Asignatura()
        {

        }
    }
}

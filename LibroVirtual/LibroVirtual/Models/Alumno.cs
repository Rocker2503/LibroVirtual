using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibroVirtual.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Rut { get; set; }
        public string Sexo { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public string Procedencia { get; set; }
        [Display(Name = "En Observacion")]
        public string EnObservacion { get; set; }

        public Alumno(int id, string apellidoPaterno, string apellidoMaterno, string nombres, string rut, string sexo, DateTime fechaNacimiento, string direccion, string comuna, string procedencia, string enObservacion)
        {
            Id = id;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Nombres = nombres;
            Rut = rut;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Comuna = comuna;
            Procedencia = procedencia;
            EnObservacion = enObservacion;
        }

        public Alumno()
        {

        }
    }
}

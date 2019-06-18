using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibroVirtual.Models
{
    public class Apoderado
    {
        public int Id { get; set; }
        [Display(Name = "Nivel Educacional Padre")]
        public string NEPadre { get; set; }
        [Display(Name = "Nivel Educacional Madre")]
        public string NEMadre { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        [Display(Name = "N° de Emergencia")]
        public string Emergencia { get; set; }

        public Apoderado(int id, string nEPadre, string nEMadre, string nombre, string rut, string direccion, string telefono, string email, string emergencia)
        {
            Id = id;
            NEPadre = nEPadre;
            NEMadre = nEMadre;
            Nombre = nombre;
            Rut = rut;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Emergencia = emergencia;
        }

        public Apoderado()
        {

        }
    }
}

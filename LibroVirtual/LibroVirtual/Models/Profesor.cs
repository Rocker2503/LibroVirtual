using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibroVirtual.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        public Profesor(int id, string rut, string nombre, string especialidad, string telefono, string email, string nombreUsuario, string contrasena)
        {
            Id = id;
            Rut = rut;
            Nombre = nombre;
            Especialidad = especialidad;
            Telefono = telefono;
            Email = email;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }

        public Profesor()
        {

        }
    }
}

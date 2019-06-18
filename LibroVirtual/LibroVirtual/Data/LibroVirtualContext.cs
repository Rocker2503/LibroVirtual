using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibroVirtual.Models;

namespace LibroVirtual.Models
{
    public class LibroVirtualContext : DbContext
    {
        public LibroVirtualContext(DbContextOptions<LibroVirtualContext> options)
            : base(options)
        {
        }

        //Agregar Entidades al Contexto para manipular la Base de Datos desde los Controladores
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Apoderado> Apoderados { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}

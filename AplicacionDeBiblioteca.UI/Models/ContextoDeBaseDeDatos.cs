using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDeBiblioteca.UI.Models
{
    public class ContextoDeBaseDeDatos : DbContext
    {

        public DbSet<Libro> Libros { get; set; }

        public ContextoDeBaseDeDatos(DbContextOptions<ContextoDeBaseDeDatos> opciones) : base(opciones)
        {

        }
    }
}

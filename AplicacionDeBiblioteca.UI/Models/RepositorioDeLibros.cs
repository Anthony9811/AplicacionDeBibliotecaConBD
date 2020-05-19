using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDeBiblioteca.UI.Models
{
    public class RepositorioDeLibros : IRepositorioDeLibros
    {
        private ContextoDeBaseDeDatos ElContextoDeBaseDeDatos;

        public RepositorioDeLibros(ContextoDeBaseDeDatos contexto)
        {
            ElContextoDeBaseDeDatos = contexto;
        }

        public void Agregar(Libro libro)
        {
            ElContextoDeBaseDeDatos.Libros.Add(libro);
            ElContextoDeBaseDeDatos.SaveChanges();
        }

        public List<Libro> ObtenerTodos()
        {
            return ElContextoDeBaseDeDatos.Libros.ToList();
        }
    }
}

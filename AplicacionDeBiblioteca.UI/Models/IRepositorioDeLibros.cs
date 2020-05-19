using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDeBiblioteca.UI.Models
{
    public interface IRepositorioDeLibros
    {
        List<Libro> ObtenerTodos();

        void Agregar(Models.Libro libro);
    }
}

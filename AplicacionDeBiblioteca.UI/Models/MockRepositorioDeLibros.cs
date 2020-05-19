using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDeBiblioteca.UI.Models
{
    public class MockRepositorioDeLibros : IRepositorioDeLibros
    {
        public void Agregar(Libro libro)
        {
            throw new NotImplementedException();
        }

        public List<Libro> ObtenerTodos()
        {
            List<Libro> laListaDeLibros = new List<Libro>();
            /*
            laListaDeLibros.Add(new Libro { Nombre = "Trafalgar", Autor = "Benito Perez Galdos", FechaDePublicacion = "1873", Estado = "Disponible"});
            laListaDeLibros.Add(new Libro { Nombre = "Historia general de los robos y asesinatos de los más famosos piratas", Autor = "Capitán Charles Johnson", FechaDePublicacion = "14/05/1724", Estado = "Prestado" });
            laListaDeLibros.Add(new Libro { Nombre = "Bajo bandera negra: La vida entre piratas", Autor = "David Cordingly", FechaDePublicacion = "1995", Estado = "Prestado"});
            laListaDeLibros.Add(new Libro { Nombre = "La república de los piratas", Autor = "Colin Woodard", FechaDePublicacion = 01 / 05 / 2007, Estado = "Disponible" });
            laListaDeLibros.Add(new Libro { Nombre = "Kama-Sutra", Autor = "Vatsiaiana", FechaDePublicacion = "550 d.C", Estado = "Disponible"});
            */
            return laListaDeLibros;
        }
    }
}

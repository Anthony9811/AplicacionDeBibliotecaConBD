using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDeBiblioteca.UI.Models
{
    public class Libro
    {
        public String Nombre { get; set; }
        public String Autor { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime FechaDePublicacion { get; set; }

        public int Estado { get; set; }
        public int ID { get; set; }    
    }
}

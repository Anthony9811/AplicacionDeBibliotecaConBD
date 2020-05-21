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

        [Display(Name = "Fecha De Publicación")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime FechaDePublicacion { get; set; }
        
        [Range(0,1,ErrorMessage ="El libro debe tener estado disponible (1)")]
        public int Estado { get; set; }
        public int ID { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concessionaria.Models
{
    public class Noticia
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Subtítulo")]
        public string Subitulo { get; set; }

        [Display(Name = "Corpo")]
        public string Corpo { get; set; }

        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Display(Name = "Data de Publicação")]
        public string DataDePublicacao { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concessionaria.Models
{
    public class Veiculo
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        [Display(Name = "Combustível")]
        public string Combustivel { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concessionaria.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        public string Nascimento { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
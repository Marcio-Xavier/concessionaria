using Concessionaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Concessionaria.DAL
{
    public class ConcessionariaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ConcessionariaContext>
    {
        /*protected override void Seed(ConcessionariaContext context)
        {
            var clientes = new List<Cliente>
            {
                new Cliente{Nome="Carlinhos",Cpf="999.999.999-99",Nascimento="01/08/2001", Telefone="91111-1111", Endereco="Sao Paulo"},
                new Cliente{Nome="Celso",Cpf="111.111.111-11",Nascimento="17/01/1995", Telefone="92222-2222", Endereco="Pouso Alegre"},
                new Cliente { Nome = "Sanchez", Cpf = "555.555.555-55", Nascimento = "24/12/1982" , Telefone = "93333-3333", Endereco = "Londrina"}
            };

            clientes.ForEach(s => context.clientes.Add(s));
            context.SaveChanges();

            var veiculos = new List<Veiculo>
            {
                new Veiculo{Nome="Onyx",Marca="Chevrolet",Ano="2015", Placa="AAA-1111", Cor="Branco", Combustivel="Flex"},
                new Veiculo{Nome="CG Titan 125",Marca="Honda",Ano="2003",Placa="BBB-2222", Cor="Verde", Combustivel="Gasolina"},
                new Veiculo{Nome="CBX 300",Marca="Honda",Ano="2019",Placa="CCC-3333", Cor="Vermelha", Combustivel="Flex"}
            };
            veiculos.ForEach(s => context.veiculos.Add(s));
            context.SaveChanges();

            var noticias = new List<Noticia>
            {
                new Noticia{Titulo="Titulo da Notícia",Subitulo="Subtítulo da Notícia",Autor="Autor da Notícia", DataDePublicacao="Data de Publicação da Notícia", Corpo="Corpo da Notícia"}
            };
            veiculos.ForEach(s => context.veiculos.Add(s));
            context.SaveChanges();
        }*/
    }
}
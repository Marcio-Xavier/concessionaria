using Concessionaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Concessionaria.DAL
{
    public class ConcessionariaContext : DbContext
    {
        public ConcessionariaContext() : base("ConcessionariaContext") { }

        public DbSet<Veiculo> veiculos{ get; set; }
        public DbSet<Cliente> clientes { get; set; }

    }
}
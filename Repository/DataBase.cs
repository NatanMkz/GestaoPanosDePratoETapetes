using GestaoPanosDePratoETapetes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Repository
{
        public class DataBase : DbContext
        {
            private static bool _created = false;
            public DataBase()
            {
                if (!_created)
                {
                    _created = true;
                    Database.EnsureDeleted();
                    Database.EnsureCreated();
                }
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
            {
                optionbuilder.UseSqlite(@"Data Source=GestaoDePessoasDataBase.sqlite");
            }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<TipoPessoa> TipoPessoa { get; set; }
        public DbSet<Costureira> Costureira { get; set; }

    }
}

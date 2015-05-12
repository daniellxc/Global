using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Concepti.Factoring.Data.Entidades;

namespace Concepti.Factoring.Data
{
    public class Contexto : DbContext
    {

       



        #region DBSets

        public DbSet<Area> Areas { get; set; }
        public DbSet<Boleto > Boletos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Contratante> Contratantes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Dia> Dias { get; set; }
        public DbSet<Escolaridade> Escolaridades { get; set; }
        public DbSet<Feriado> Feriados { get; set; }
        public DbSet<ItemDespesa> ItensDespesa { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<MovimentoRota> MovimentosRotas { get; set; }
        public DbSet<Periodicidade> Periodicidades { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<SituacaoBoleto> SituacaoBoletos { get; set; }
        public DbSet<TipoDespesa> TiposDespesa { get; set; }
        public DbSet<TipoMovimento> TiposMovimento { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
       

        #endregion
        public Contexto() : base("Contexto") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

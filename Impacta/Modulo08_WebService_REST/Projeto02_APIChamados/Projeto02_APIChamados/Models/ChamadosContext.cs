using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto02_APIChamados.Models
{
    public class ChamadosContext:DbContext
    {
        //Estabelecendo a conexao com o Banco enviando a string de conexao
        public ChamadosContext():base("name=ChamadosConnection")
        {           
        }
        //definimos a coleção de objetos(DbSet)
        public DbSet<Chamado> Chamados  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Definindo o nome da tabela a ser gerada
            modelBuilder.Entity<Chamado>().ToTable("TBChamados");
            //Definindo os parametros dos campos
            modelBuilder.Entity<Chamado>().Property(p => p.Data).IsRequired();
            //Definindo o tamanho maximo do campo documento
            modelBuilder.Entity<Chamado>().Property(p => p.Documento).HasMaxLength(14).IsRequired();
            //Definindo o tamanho maximo do campo assunto
             modelBuilder.Entity<Chamado>().Property(p => p.Assunto).HasMaxLength(20).IsRequired();
            //Definindo o tamanho maximo do campo descricao 
            modelBuilder.Entity<Chamado>().Property(p => p.Descricao).HasMaxLength(300).IsRequired();
            //Definindo o tamanho maximo do campo resposta
            modelBuilder.Entity<Chamado>().Property(p => p.Resposta).HasMaxLength(300);
            //Definindo o campo resolvido
            modelBuilder.Entity<Chamado>().Property(p => p.Resolvido).IsRequired();
        }
    }
}
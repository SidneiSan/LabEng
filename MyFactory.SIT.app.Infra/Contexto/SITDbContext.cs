using MyFactory.SIT.app.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactory.SIT.app.Infra.Contexto
{
    public class SITDbContext : DbContext
    {
        public SITDbContext() : base("ConexaoDbContext")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //modelBuilder.Entity<Usuario>()
            //    .HasOptional(p => p.)
            //modelBuilder.Entity<Member>()
            //.HasOptional(x => x.ApplicationUser)
            //.WithMany()
            //.HasForeignKey(x => x.ApplicationUserID);

        }

        //public System.Data.Entity.DbSet<UsuarioViewModel> UsuarioViewModels { get; set; }
    }
}

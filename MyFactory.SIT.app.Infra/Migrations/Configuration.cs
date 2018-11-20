namespace MyFactory.SIT.app.Infra.Migrations
{
    using MyFactory.SIT.app.Dominio.Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.SITDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Contexto.SITDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Usuarios.AddOrUpdate(
              new Usuario { Nome = "Admin", Ativo=true ,  Email= "admin@admin.com", Senha="123" }
            );
        }
    }
}

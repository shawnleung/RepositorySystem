using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using RepositorySystem.Core.Entities;

namespace RepositorySystem.WinClient.DomainServices
{
    public static class PersistenceService
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("Repository.db"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Item>())
                .BuildSessionFactory();
        }

        public static void UpdateRepository()
        {
            Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("Repository.db"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Item>())
                .ExposeConfiguration(UpdateSchema)
                .BuildConfiguration();
        }

        private static void UpdateSchema(Configuration cfg)
        {
            var schemaUpdate = new SchemaUpdate(cfg);
            schemaUpdate.Execute(true, true);
        }

        public static void CreateRepository()
        {
            Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("Repository.db"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Item>())
                .ExposeConfiguration(CreateSchema)
                .BuildConfiguration();
        }

        private static void CreateSchema(Configuration cfg)
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Execute(true, true, false);
        }
    }
}

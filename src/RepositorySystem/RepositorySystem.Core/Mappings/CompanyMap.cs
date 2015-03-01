using FluentNHibernate.Mapping;
using RepositorySystem.Core.Entities;

namespace RepositorySystem.Core.Mappings
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(x => x.Id);
            Map(x => x.Name).Default(string.Empty);
            Map(x => x.Phone).Default(string.Empty);
            Map(x => x.Cellphone).Default(string.Empty);
            Map(x => x.Address).Default(string.Empty);
            Map(x => x.QQ).Default(string.Empty);
            Map(x => x.Website).Default(string.Empty);
        }
    }
}

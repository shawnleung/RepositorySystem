using FluentNHibernate.Mapping;
using RepositorySystem.Core.Entities;

namespace RepositorySystem.Core.Mappings
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(x => x.Id);
            Map(x => x.Name).Default(string.Empty);
            Map(x => x.BarCode).Default(string.Empty);
            Map(x => x.Model).Default(string.Empty);
            Map(x => x.RetailPrice).Default("0.0");
            Map(x => x.WholesalePrice).Default("0.0");
            Map(x => x.Xprice).Default("0.0");
            Map(x => x.Inventory).Default("0");
            References(x => x.Company).Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositorySystem.Core.Entities;
using NHibernate;
using NHibernate.Linq;

namespace RepositorySystem.Persistence
{
    public interface IItemRepository
    {
        int Save(Item item);
        List<Item> Query();
    }

    public class ItemRepository : IItemRepository
    {
        private ISessionFactory _sessionFactory;

        public ItemRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public int Save(Item item)
        {
            int id;
            using (var session = _sessionFactory.OpenSession())
            {
                id = (int)session.Save(item);
                session.Flush();
            }
            return id;
        }

        public List<Item> Query()
        {
            List<Item> list = null;
            using (var session = _sessionFactory.OpenSession())
            {
                list = session.Query<Item>().ToList();
            }
            return list;
        }
    }
}

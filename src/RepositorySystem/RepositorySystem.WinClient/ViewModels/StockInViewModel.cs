using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using RepositorySystem.Core.Entities;
using RepositorySystem.Persistence;
using RepositorySystem.WinClient.DomainServices;

namespace RepositorySystem.WinClient.ViewModels
{
    public class StockInViewModel : Screen
    {
        public StockInViewModel()
        {
            DisplayName = "Stock In";

            _itemRepository = new ItemRepository(PersistenceService.CreateSessionFactory());
        }

        #region 属性
        public string Model
        {
            get { return _item.Model; }
            set
            {
                if (_item.Model == value)
                    return;

                _item.Model = value;
                NotifyOfPropertyChange(() => Model);
            }
        }

        public string Name
        {
            get { return _item.Name; }
            set
            {
                if (_item.Name == value)
                    return;

                _item.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }
        #endregion

        #region 成员
        Item _item = new Item();
        IItemRepository _itemRepository;
        #endregion

        #region 方法
        public void OK()
        {
            _itemRepository.Save(_item);
        }

        public void Cancel()
        {
            this.TryClose();
        }
        #endregion
    }
}

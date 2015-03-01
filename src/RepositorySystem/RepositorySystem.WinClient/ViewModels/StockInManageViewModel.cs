using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using RepositorySystem.Persistence;
using RepositorySystem.WinClient.DomainServices;
using RepositorySystem.Core.Entities;
using System.Collections.ObjectModel;


namespace RepositorySystem.WinClient.ViewModels
{
    public class StockInManageViewModel : Screen
    {
        public StockInManageViewModel()
        {
            DisplayName = "Stock In Manage";

            _itemRepository = new ItemRepository(PersistenceService.CreateSessionFactory());

            Query();
        }

        #region 属性
        private ObservableCollection<ItemViewModel> _itemCollection;
        public ObservableCollection<ItemViewModel> ItemCollection
        {
            get
            {
                if (_itemCollection == null)
                    _itemCollection = new ObservableCollection<ItemViewModel>();
                return _itemCollection;
            }
            set
            {
                if (_itemCollection == value)
                    return;

                _itemCollection = value;
                NotifyOfPropertyChange(() => ItemCollection);
            }
        }

        ItemViewModel _item = new ItemViewModel(new Item());
        public ItemViewModel Item
        {
            get { return _item; }
            set
            {
                if (_item == value)
                    return;

                _item = value;
                NotifyOfPropertyChange(() => Item);
            }
        }

        string _queryCondition;
        public string QueryCondition
        {
            get { return _queryCondition; }
            set
            {
                if (_queryCondition == value)
                    return;

                _queryCondition = value;
                NotifyOfPropertyChange(() => QueryCondition);
            }
        }

        #endregion

        #region 成员
        IItemRepository _itemRepository;
        #endregion

        #region 方法
        public void Add()
        {
            _itemRepository.Save(_item.GetItem());
            ItemCollection.Add(_item);

            _item = new ItemViewModel(new Item());
        }

        public void Delete()
        {

        }

        public void Query()
        {
            //ObservableCollection<Item> itemCollection = new ObservableCollection<Item>();
            ItemCollection.Clear();

            var items = _itemRepository.Query();

            if (!string.IsNullOrEmpty(_queryCondition))
                items = items.Where(x => x.Model.Contains(_queryCondition) || x.Name.Contains(_queryCondition)).ToList();

            foreach (var item in items)
            {
                ItemCollection.Add(new ItemViewModel(item));
            }

            //ItemCollection = itemCollection;
        }

        public void QueryCancel()
        {

        }
        #endregion
    }
}

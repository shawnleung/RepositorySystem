using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositorySystem.Core.Entities;
using Caliburn.Micro;

namespace RepositorySystem.WinClient.ViewModels
{
    public class ItemViewModel : PropertyChangedBase
    {
        public ItemViewModel(Item item)
        {
            _item = item;
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

        public string BarCode
        {
            get { return _item.BarCode; }
            set
            {
                if (_item.BarCode == value)
                    return;

                _item.BarCode = value;
                NotifyOfPropertyChange(() => BarCode);
            }
        }

        public double RetailPrice
        {
            get { return _item.RetailPrice; }
            set
            {
                if (_item.RetailPrice == value)
                    return;

                _item.RetailPrice = value;
                NotifyOfPropertyChange(() => RetailPrice);
            }
        }

        public double WholesalePrice
        {
            get { return _item.WholesalePrice; }
            set
            {
                if (_item.WholesalePrice == value)
                    return;

                _item.WholesalePrice = value;
                NotifyOfPropertyChange(() => WholesalePrice);
            }
        }

        public double Xprice
        {
            get { return _item.Xprice; }
            set
            {
                if (_item.Xprice == value)
                    return;

                _item.Xprice = value;
                NotifyOfPropertyChange(() => Xprice);
            }
        }

        public Company Company
        {
            get { return _item.Company; }
            set
            {
                if (_item.Company == value)
                    return;

                _item.Company = value;
                NotifyOfPropertyChange(() => Company);
            }
        }

        public int Inventory
        {
            get { return _item.Inventory; }
            set
            {
                if (_item.Inventory == value)
                    return;

                _item.Inventory = value;
                NotifyOfPropertyChange(() => Inventory);
            }
        }
        #endregion

        #region 成员
        Item _item;
        #endregion

        #region 方法
        public Item GetItem()
        {
            return _item;
        }
        #endregion
    }
}

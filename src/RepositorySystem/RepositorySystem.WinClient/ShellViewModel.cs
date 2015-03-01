using System.ComponentModel.Composition;
using Caliburn.Micro;
using RepositorySystem.WinClient.ViewModels;
using RepositorySystem.WinClient.DomainServices;

namespace RepositorySystem.WinClient
{
    public interface IShell { }

    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        readonly IWindowManager windowManager;

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
            DisplayName = "Repository System";

            //PersistenceService.CreateRepository();
        }
        #region 成员

        #endregion

        #region 属性

        #endregion

        #region 方法
        public void StockIn()
        {
            windowManager.ShowDialog(new StockInViewModel());
        }

        public void OpenStockInList()
        {
            windowManager.ShowDialog(new StockInManageViewModel());
        }
        #endregion
    }
}

using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DialogIssue.ViewModels
{
    public class ShellViewModel
    {
        IWindowManager _manager;
        public ShellViewModel()
        {
            _manager = new WindowManager();
        }
        public async Task OpenUserControl()
        {
            var viewModel = new AddNewCustomerViewModel();
            UIElement uiElement = ViewLocator.LocateForModel(viewModel, null, null);
            ViewModelBinder.Bind(viewModel, uiElement, null);
            await DialogHost.Show(uiElement);
        }
        public async Task OpenWindow()
        {
            var viewModel = new CustomersViewModel();
            UIElement uiElement = ViewLocator.LocateForModel(viewModel, null, null);
            ViewModelBinder.Bind(viewModel, uiElement, null);
            await DialogHost.Show(uiElement);
        }
        public void OpenCustomerWindowWithManager()
        {
            _manager.ShowDialog(new CustomersViewModel(), null, null);
        }
    }
}

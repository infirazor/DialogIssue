using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DialogIssue.ViewModels
{
    public class CustomersViewModel
    {
        public async Task AddNewCustomer()
        {
            var viewModel = new AddNewCustomerViewModel();
            UIElement uiElement = ViewLocator.LocateForModel(viewModel, null, null);
            ViewModelBinder.Bind(viewModel, uiElement, null);
            await DialogHost.Show(uiElement);
        }
        public void Exit()
        {
            //Does not work
            //(GetView() as Window).Close();

            MessageBox.Show("Dont know how to close this windown other then Click Away of the Dialog");
        }
    }
}

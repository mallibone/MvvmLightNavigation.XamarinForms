using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace MvvmLightNavigation.XamarinForms.ViewModel
{
    public class FirstViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public FirstViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigationCommand = new RelayCommand(() => { _navigationService.NavigateTo(Locator.SecondPage); });
        }

        public ICommand NavigationCommand { get; set; }
    }
}

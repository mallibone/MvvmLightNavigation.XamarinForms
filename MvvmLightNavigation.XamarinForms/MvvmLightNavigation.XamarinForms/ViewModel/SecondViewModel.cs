using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace MvvmLightNavigation.XamarinForms.ViewModel
{
    public class SecondViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public SecondViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigationCommand =
                new RelayCommand(() => { _navigationService.NavigateTo(Locator.ThirdPage, Parameter ?? string.Empty); });
        }

        public ICommand NavigationCommand { get; set; }
        public string Parameter { get; set; }
    }
}

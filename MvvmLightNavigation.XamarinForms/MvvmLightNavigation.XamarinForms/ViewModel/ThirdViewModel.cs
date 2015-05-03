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
    public class ThirdViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _parameterText;

        public ThirdViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigateCommand = new RelayCommand(() => { _navigationService.GoBack(); });
        }

        public string ParameterText
        {
            get { return _parameterText; }
            set
            {
                if (_parameterText == value) return;
                _parameterText = value;
                RaisePropertyChanged(() => ParameterText);
            }
        }

        public ICommand NavigateCommand { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MvvmLightNavigation.XamarinForms.Helpers;
using MvvmLightNavigation.XamarinForms.Views;
using Xamarin.Forms;

namespace MvvmLightNavigation.XamarinForms
{
    public class App : Application
    {
        private static Locator _locator;
        public static Locator Locator { get { return _locator ?? (_locator = new Locator()); } }

        public App()
        {
            var nav = new NavigationService();
            nav.Configure(Locator.FirstPage, typeof(FirstPage));
            nav.Configure(Locator.SecondPage, typeof(SecondPage));
            nav.Configure(Locator.ThirdPage, typeof(ThirdPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var firstPage = new NavigationPage(new FirstPage());

            nav.Initialize(firstPage);

            //SimpleIoc.Default.Register<INavigationService>(() => nav);

            MainPage = firstPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

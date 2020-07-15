using System;
using ReproProjectBindingIssue.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Page = ReproProjectBindingIssue.Views.Page;

namespace ReproProjectBindingIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page();
        }

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }
    }
}
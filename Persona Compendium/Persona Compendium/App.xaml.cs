using Persona_Compendium.Services;
using Persona_Compendium.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Persona_Compendium
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

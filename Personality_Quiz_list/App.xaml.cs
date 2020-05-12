using System;
using Personality_Quiz_list.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Personality_Quiz_list
{
    public partial class App : Application
    {
        public static StarWarsManager SWManager { get; private set; }
        public App()
        {
            InitializeComponent();

            SWManager = new StarWarsManager(new RestService());
            MainPage = new MainPage();
            
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

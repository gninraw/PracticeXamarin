using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lesson2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MasterDetailPage p = new MasterDetailPage();
            p.Master = new Master() { Title = "Master" };
            p.Detail = new NavigationPage(new Lesson2.MainPage()) { Title = "Detail" }; ;

            MainPage = p;
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

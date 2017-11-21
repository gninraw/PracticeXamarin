using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinStudy.View;

namespace XamarinStudy.ViewModel
{
    public class StartPageViewModel
    {
        public String Title { get; set; }
        public ICommand Clicked { get; set; }
        public INavigation Navigation { get; set; }

        public StartPageViewModel(StartPage startPage)
        {
            Title = "StartPage !!!!!!";
            Clicked = new Command(Sample1Clicked);
            Navigation = startPage.Navigation;
        }

        private void Sample1Clicked(object obj)
        {
            Navigation.PushAsync(new Sample1());
        }
    }
}

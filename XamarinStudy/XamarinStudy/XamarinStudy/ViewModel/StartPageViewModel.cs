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

        public ICommand SampleClickCommand { get; set; }
        
        public INavigation Navigation { get; set; }

        public StartPageViewModel(StartPage startPage)
        {
            Title = "StartPage !!!!!!";
            SampleClickCommand = new Command(SampleClicked);
            Navigation = startPage.Navigation;
        }

        private void SampleClicked(object obj)
        {
            switch (obj)
            {
                case "sample1":
                    Navigation.PushAsync(new Sample1());
                    break;

                case "sample2":
                    Navigation.PushAsync(new Sample2());
                    break;

                case "sample3":
                    Navigation.PushAsync(new Sample3());
                    break;

                case "sample4":
                    Navigation.PushAsync(new Sample4());
                    break;

                default:
                    break;
            }

            

            //string name = obj as string;
            //if(name == "sample1")
            //{
            //    Navigation.PushAsync(new Sample1());
            //}
            //else if (name == "sample2")
            //{
            //    Navigation.PushAsync(new Sample2());
            //}
            //else
            //{

            //}
        }
    }
}

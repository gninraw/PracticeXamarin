using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Lesson2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private int i;
        private PageViewModel viewmodel;

        public Page1()
        {
            InitializeComponent();

            viewmodel =  new PageViewModel();
            this.BindingContext = viewmodel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewmodel.Lab1Text = i + " Click";
            i++;
            //this.lab1.Text = i + " Click";
            //i++;
        }
    }
}
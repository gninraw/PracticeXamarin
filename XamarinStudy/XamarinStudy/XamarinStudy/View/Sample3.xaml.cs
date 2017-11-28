﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStudy.ViewModel;

namespace XamarinStudy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sample3 : ContentPage
    {
        public Sample3()
        {
            InitializeComponent();
            BindingContext = new Sample3ViewModel();
        }
    }
}
﻿using XamarinFApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails()
        {
            InitializeComponent();
            BindingContext = Startup.Resolve<ProductDetailsViewModel>();
        }
    }
}
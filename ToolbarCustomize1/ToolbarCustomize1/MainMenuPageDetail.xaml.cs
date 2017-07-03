﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolbarCustomize1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPageDetail : ContentPage
    {
        public MainMenuPageDetail()
        {
            InitializeComponent();

            NavigationButton.Clicked += (sender, e) => {
                Navigation.PushModalAsync(new NavigationPage(new ModalPage()));
            };
        }
    }
}
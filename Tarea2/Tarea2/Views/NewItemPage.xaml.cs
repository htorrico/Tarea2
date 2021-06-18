using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tarea2.Models;
using Tarea2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
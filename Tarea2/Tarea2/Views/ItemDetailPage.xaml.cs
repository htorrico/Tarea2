using System.ComponentModel;
using Tarea2.ViewModels;
using Xamarin.Forms;

namespace Tarea2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
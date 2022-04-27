using DotReactorTestApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DotReactorTestApp.Views
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
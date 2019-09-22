using DrinkGalleryApp.ViewModels;
using Xamarin.Forms;

namespace DrinkGalleryApp.Views
{
    public partial class DrinksView : ContentPage
    {
        public DrinksView()
        {
            InitializeComponent();
            BindingContext = new DrinksViewModel();
        }
    }
}
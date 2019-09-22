using DrinkGalleryApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DrinkGalleryApp.ViewModels
{
    public class DrinksViewModel : BindableObject
    {
        private ObservableCollection<CarouselItem> _drinks;

        public DrinksViewModel()
        {
            LoadDrinks();
        }

        public ObservableCollection<CarouselItem> Drinks
        {
            get { return _drinks; }
            set
            {
                _drinks = value;
                OnPropertyChanged();
            }
        }

        void LoadDrinks()
        {
            Drinks = new ObservableCollection<CarouselItem>() {
                 new CarouselItem { Image="coffee.png", Title = "BRAZILIAN COFFEE", Color= Color.Maroon, Price =3.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="marshmallows.png", Title = "HOT CHOCOLATE WITH MARSHMALLOWS", Color= Color.Wheat, Price = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="plant.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="strawberry.png", Title = "STRAWBERRY MILK", Color= Color.Red, Price = 6.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." }
            };
        }
    }
}
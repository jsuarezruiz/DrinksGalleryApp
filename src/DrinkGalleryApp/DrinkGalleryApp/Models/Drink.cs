using System.Drawing;

namespace DrinkGalleryApp.Models
{
    public class Drink
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Color Color { get; set; }
    }
}
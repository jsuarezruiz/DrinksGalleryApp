namespace DrinkGalleryApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new DrinkGalleryApp.App());
        }
    }
}

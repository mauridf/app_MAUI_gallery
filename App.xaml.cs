namespace app_MAUI_gallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppFlyout();
        }
    }
}
using Xamarin.Forms;

namespace MobileImageClassifierApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CustomVisionView());
        }
    }
}

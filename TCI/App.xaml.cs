using TCI.MVVM.Views;

namespace TCI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TCIView();
        }
    }
}

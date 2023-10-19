
using EjerciciosTema7.Views;

namespace EjerciciosTema7;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}
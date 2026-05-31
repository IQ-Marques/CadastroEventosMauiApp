using CadastroEventosMauiApp.Views;

namespace CadastroEventosMauiApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(
            new CadastroEvento());
    }
}
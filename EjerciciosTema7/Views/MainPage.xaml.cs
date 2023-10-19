using Biblioteca;
using Microsoft.Maui.ApplicationModel.Communication;

namespace EjerciciosTema7.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnTabbed_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaTabbed());
    }

    private async void btnPage4_Clicked(object sender, EventArgs e)
    {
        clsPersona persona = new clsPersona
        {
            Nombre = entryNombre.Text,
            Apellidos = entryApellidos.Text
        };
        await Navigation.PushModalAsync(new pagina4(persona));
    }

    private async void btnPage5_Clicked(object sender, EventArgs e)
    {
        clsPersona persona = new clsPersona();
        persona.Nombre = entryNombre.Text;
        persona.Apellidos = entryApellidos.Text;
        await Navigation.PushAsync(new pagina5(persona)
        {
            BindingContext = persona
        });
    }

}
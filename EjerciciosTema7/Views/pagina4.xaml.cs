using Biblioteca;
namespace EjerciciosTema7.Views;

public partial class pagina4 : ContentPage
{
	public pagina4(clsPersona persona)
	{
		InitializeComponent();

		lblNombre.Text = persona.Nombre;
		lblApellidos.Text = persona.Apellidos;
	}
}
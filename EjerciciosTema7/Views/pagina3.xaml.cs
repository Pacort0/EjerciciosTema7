namespace EjerciciosTema7.Views;

public partial class pagina3 : ContentPage
{
	public pagina3()
	{
		InitializeComponent();
	}

    private async void btnPage3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}
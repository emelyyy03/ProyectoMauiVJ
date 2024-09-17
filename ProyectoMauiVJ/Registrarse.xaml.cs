namespace ProyectoMauiVJ;

public partial class Registrarse : ContentPage
{
	public Registrarse()
	{
		InitializeComponent();
	}

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new InicioSesion();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
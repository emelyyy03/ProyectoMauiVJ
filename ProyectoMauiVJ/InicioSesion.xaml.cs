namespace ProyectoMauiVJ;

public partial class InicioSesion : ContentPage
{
	public InicioSesion()
	{
		InitializeComponent();
	}

    private void BtnRegistrarse_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Registrarse();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void btnVisitantes_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Registro();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
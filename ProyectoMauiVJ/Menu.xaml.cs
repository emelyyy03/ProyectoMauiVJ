namespace ProyectoMauiVJ;

public partial class Menu : ContentPage
{
    LocalDbService _localDbService;
	public Menu(LocalDbService localDbService)
	{
		InitializeComponent();
        _localDbService = localDbService;
	}

    private void BtnFamosas_Clicked(System.Object sender, System.EventArgs e)
    {
        var nextPage = new Famosas();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void BtnEscultoricas_Clicked(System.Object sender, System.EventArgs e)
    {
        var nextPage = new Esculturas();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void BtnPictoricas_Clicked(System.Object sender, System.EventArgs e)
    {
        var nextPage = new Pictoricas();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void BtnSalvadore_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Nacionales();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    { 
        var nextPage = new InicioSesion(_localDbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
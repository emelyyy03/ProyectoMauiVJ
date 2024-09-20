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

    }

    private void BtnEscultoricas_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    private void BtnPictoricas_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    private void BtnSalvadore_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    { 
        var nextPage = new InicioSesion(_localDbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
namespace ProyectoMauiVJ;

public partial class InicioSesion : ContentPage
{
    private LocalDbService _dbService;
    public InicioSesion(LocalDbService dbService)
    {
        InitializeComponent();

        _dbService = dbService;

    }

    private void BtnRegistrarse_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Registrarse(_dbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void btnVisitantes_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Registro(_dbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
    {

        string nombreUsuario = NombreUsuario.Text;
        string contraseña = Pass.Text;

        if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
        {
            await DisplayAlert("Error", "Por favor llenar todos los campos.", "OK");
            return;
        }

        var usuario = await _dbService.ObtenerUsuarioAsync(nombreUsuario, contraseña);

        if (usuario != null && usuario.Contraseña == contraseña)
        {
            // Navegar a la siguiente página
            await Navigation.PushAsync(new Menu(_dbService));
        }
        else
        {
            await DisplayAlert("Error", "Datos no encontrados", "OK");
        }
    }
}
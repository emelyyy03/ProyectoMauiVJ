
namespace ProyectoMauiVJ;

public partial class Registrarse : ContentPage
{
    private LocalDbService _dbService;
    public Registrarse()
	{
		InitializeComponent();
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "items.db3");
        _dbService = new LocalDbService(dbPath);
    }

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new InicioSesion();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private async void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        string name = Usuario.Text;
        string pass = Pass.Text;

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
        {
            await DisplayAlert("Error", "Por favor ingrese todos los datos.", "OK");
            return;
        }

        var item = new Cuentas { Nombre = name, Contraseña = pass };
        await _dbService.Create(item);

        await Navigation.PushAsync(new Registro(_dbService));
    }
}
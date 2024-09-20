
namespace ProyectoMauiVJ;

public partial class Registrarse : ContentPage
{
    private LocalDbService _dbService;
    public Registrarse(LocalDbService localDbService)
	{
		InitializeComponent();
        _dbService = localDbService;
    }

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new InicioSesion(_dbService);
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

        await DisplayAlert("Éxito", "El usuario ha sido registrado", "OK");

        await Navigation.PushAsync(new Registro(_dbService));
    }
}
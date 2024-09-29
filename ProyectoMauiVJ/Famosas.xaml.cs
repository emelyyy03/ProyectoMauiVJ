
namespace ProyectoMauiVJ;

public partial class Famosas : ContentPage
{
    private LocalDbService _dbService;
    public Famosas(LocalDbService localDbService)
	{
		InitializeComponent();
        _dbService = localDbService;
	}

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Menu(_dbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
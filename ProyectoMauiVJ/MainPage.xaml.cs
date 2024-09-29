namespace ProyectoMauiVJ
{
    public partial class MainPage : ContentPage
    {
        LocalDbService _localDbService;
        public MainPage(LocalDbService localDbService)
        {
            InitializeComponent();
            _localDbService = localDbService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var nextPage = new InicioSesion(_localDbService);
            NavigationPage navigationPage = new NavigationPage(nextPage);
            Application.Current.MainPage = navigationPage;
        }

        

    }

}

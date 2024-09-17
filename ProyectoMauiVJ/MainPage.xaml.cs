namespace ProyectoMauiVJ
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var nextPage = new InicioSesion();
            NavigationPage navigationPage = new NavigationPage(nextPage);
            Application.Current.MainPage = navigationPage;
        }
    }

}



namespace ProyectoMauiVJ
{
    public partial class App : Application
    {
        LocalDbService _localDbService;
        public App()
        {
            InitializeComponent();

            
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "demo_suma.db3");
            _localDbService = new LocalDbService(dbPath);
           

            MainPage = new NavigationPage(new MainPage(_localDbService));
           
        }
    }
}

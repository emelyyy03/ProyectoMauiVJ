
using ProyectoMauiVJ;

namespace ProyectoMauiVJ;

public partial class Registro : ContentPage
{
    private LocalDbService _dbService;
    public Registro(LocalDbService dbService)
    {
        InitializeComponent();
        _dbService = dbService;
        LoadData();
    }
    private async void LoadData()
    {
        var cuentas = await _dbService.GetCuentas();
        listview.ItemsSource = cuentas;
    }

    private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        //var cuentas = (Cuentas)e.Item;
        //var action = await DisplayActionSheet("Seleccionar Acci�n", "Cancelar", null, "Editar", "Eliminar");

        //switch (action)
        //{
        //    case "Editar":
        //        _editCuentasId = cuentas.Id;
        //        entryNombre.Text = cuentas.Nombre;
        //        entryContra.Text = cuentas.Contrase�a;
        //        ;
        //        break;

        //    case "Eliminar":

        //        bool confirmDelete = await DisplayAlert("Confirmar Eliminaci�n", "�Est�s seguro de que deseas eliminar esta cuenta?", "S�", "No");
        //        if (confirmDelete)
        //        {
        //            await _dbService.Delete(cuentas);
        //            listview.ItemsSource = await _dbService.GetCuentas();
        //        }
        //        break;
        //}
    }
    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new InicioSesion();
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }
}
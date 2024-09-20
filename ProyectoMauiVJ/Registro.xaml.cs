
using ProyectoMauiVJ;

namespace ProyectoMauiVJ;

public partial class Registro : ContentPage
{
    private LocalDbService _dbService;
    private int _editCuentasId;
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

    private async void listview_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var cuentas = (Cuentas)e.Item;
        var action = await DisplayActionSheet("Seleccionar Acci�n", "Cancelar", null, "Editar", "Eliminar");

        switch (action)
        {
            case "Editar":
                _editCuentasId = cuentas.Id;
                entryNombre.Text = cuentas.Nombre;
                entryContra.Text = cuentas.Contrase�a;
                break;

            case "Eliminar":

                bool confirmDelete = await DisplayAlert("Confirmar Eliminaci�n", "�Est�s seguro de que deseas eliminar esta cuenta?", "S�", "No");
                if (confirmDelete)
                {
                    await _dbService.Delete(cuentas);
                    listview.ItemsSource = await _dbService.GetCuentas();
                }
                else
                {
                    await DisplayAlert("Cancelado", "La eliminaci�n ha sido cancelada.", "OK");
                }
                break;
        }
    }
    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        var nextPage = new InicioSesion(_dbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
        var nextPage = new Menu(_dbService);
        NavigationPage navigationPage = new NavigationPage(nextPage);
        Application.Current.MainPage = navigationPage;
    }

    private async void btnGuardar_Clicked(object sender, EventArgs e)
    {
        // Edita cliente
        await _dbService.Update(new Cuentas
        {
            Id = _editCuentasId,
            Nombre = entryNombre.Text,
            Contrase�a = entryContra.Text,
        });

        await DisplayAlert("�xito", "El registro ha sido actualizado.", "OK");

        // Limpiar los campos
        entryNombre.Text = string.Empty;
        entryContra.Text = string.Empty;

        // Actualizar los resultados
        listview.ItemsSource = await _dbService.GetCuentas();
    }
}


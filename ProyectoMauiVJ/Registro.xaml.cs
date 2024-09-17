

namespace ProyectoMauiVJ;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        //var distancia = (Distancia)e.Item;
        //var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

        //switch (action)
        //{
        //    case "Edit":
        //        _editDistanciaId = distancia.Id;
        //        EntrX1.Text = distancia.X1;
        //        EntrX2.Text = distancia.X2;
        //        EntrY1.Text = distancia.Y1;
        //        EntrY2.Text = distancia.Y2;
        //        labelDistancia.Text = distancia.Distanciaa;
        //        break;

        //    case "Delete":
        //        await _dbService.Delete(distancia);
        //        listview.ItemsSource = await _dbService.GetDistancia();
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
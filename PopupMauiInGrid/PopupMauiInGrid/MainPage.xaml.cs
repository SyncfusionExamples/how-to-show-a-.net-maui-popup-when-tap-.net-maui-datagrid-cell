namespace PopupMauiInGrid;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void DataGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
	{
		sfPopup.Show();
	}
}


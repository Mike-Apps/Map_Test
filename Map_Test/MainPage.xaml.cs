namespace Map_Test;


public partial class MainPage : ContentPage
{
	int count = 0;
    public MainPage()
	{
		InitializeComponent();
  
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{

        var mapControl = new Mapsui.UI.Maui.MapControl();
        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        Content = mapControl;

        //await Map.Default.OpenAsync(47.645160, -122.1306032);
       
	}
}


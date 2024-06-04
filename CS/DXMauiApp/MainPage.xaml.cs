using DevExpress.Maui.CollectionView;

namespace DXMauiApp;

public partial class MainPage : ContentPage
{
    public DXCollectionView DXCollectionView => this.dxCollectionView;

    public MainPage()
	{
		BindingContext = new MainViewModel();
		InitializeComponent();
	}
}


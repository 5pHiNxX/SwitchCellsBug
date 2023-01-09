using SwitchCells.ViewModels;

namespace SwitchCells;

public partial class MainPage : ContentPage
{

	public MainPage()
    {
        this.BindingContext = new SwitchCellViewModel();
        InitializeComponent();
	}
}


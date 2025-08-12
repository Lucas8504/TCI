using TCI.MVVM.ViewModels;

namespace TCI.MVVM.Views;

public partial class TCIView : ContentPage
{
	public TCIView()
	{
		InitializeComponent();
        BindingContext = new TCIViewModel();
    }
}
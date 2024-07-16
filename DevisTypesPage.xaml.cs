namespace MauiApp2;

public partial class DevisTypesPage : ContentPage
{
	public DevisTypesPage(DevisViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
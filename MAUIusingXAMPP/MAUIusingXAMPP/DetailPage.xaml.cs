using MAUIusingXAMPP.ViewModel;

namespace MAUIusingXAMPP;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
using MAUIusingXAMPP.ViewModel;

namespace MAUIusingXAMPP
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}

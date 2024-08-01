using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUIusingXAMPP.ViewModel
{
    [QueryProperty("Text", "id")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBack()
        {
            //navigating to the previous page
            await Shell.Current.GoToAsync("..");
        }
    }
}

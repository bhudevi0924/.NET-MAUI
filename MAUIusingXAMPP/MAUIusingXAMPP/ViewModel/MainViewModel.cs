using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIusingXAMPP.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;

        public MainViewModel(IConnectivity connectivity) 
        {
            Items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                //(title, message, button)
                await Shell.Current.DisplayAlert("No Internet available!", "","OK");
                return;
            }
            Items.Add(Text);
            // add a new task
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string task) {
            if (Items.Contains(task))
            {
                Items.Remove(task);
            }      
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            //On tapping the task it navigates to the DetailPage
            // await Shell.Current.GoToAsync(nameof(DetailPage));

            //passing data property
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?id={s}");
        }
    }
}

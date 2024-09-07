
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_CL.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string strCount = "No haz hecho clicks";

        private int count;

        [RelayCommand]
        private void Incrementar()
        {
            count++;
            strCount = $"Haz hecho {count} clicks";
        }
    }
}

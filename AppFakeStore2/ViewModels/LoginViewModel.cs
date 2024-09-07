using AppFakeStore2.Models;
using AppFakeStore2.Services;
using AppFakeStore2.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace AppFakeStore2.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        private readonly ILoginService loginService;

        public LoginViewModel()
        {
            Title = "Login";
            loginService = new LoginService();
        }

        [RelayCommand]
        private async Task Login()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "POR FAVOR, INGRESE NOMBRE DE USUARIO.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "POR FAVOR, INGRESE CONTRASEÑA.", "OK");
                return;
            }

            var loginModel = new Login
            {
                Username = Username,
                Password = Password
            };

            var token = await loginService.AuthenticateAsync(loginModel);

            if (!string.IsNullOrEmpty(token))
            {
                // Guardar el token y navegar a la página principal
                ResetFields();
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Login fallido", "OK");
            }
        }

        private void ResetFields()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}

﻿using AppFakeStore2.Models;
using AppFakeStore2.Services;
using AppFakeStore2.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore2.ViewModels
{
    public partial class UserDetalleViewModel : BaseViewModel
    {
        private readonly IUserService _userService;

        [ObservableProperty]
        User user;

        public UserDetalleViewModel(IUserService userService)
        {
            _userService = userService;
            Title = "Detalle de Usuario";
        }

        public async Task LoadUserDetailsAsync(int userId)
        {
            User = await _userService.GetUserByIdAsync(userId);
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
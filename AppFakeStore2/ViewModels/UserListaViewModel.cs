﻿using AppFakeStore2.Models;
using AppFakeStore2.Services;
using AppFakeStore2.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore2.ViewModels
{
    public partial class UserListaViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; } = new();

        [ObservableProperty]
        bool isRefreshing;

        [ObservableProperty]
        User userSeleccionado;

        IUserService _userService;


        public UserListaViewModel(IUserService userService)
        {
            Title = "LISTA DE USUARIOS";
            _userService = userService;
        }

        [RelayCommand]
        private async Task GetUsersAsync()
        {
            if (!IsBusy)
            {
                try
                {
                    IsBusy = true;
                    var users = await _userService.GetUsersAsync();

                    if (users != null)
                    {
                        if (Users.Count != 0)
                            Users.Clear();

                        foreach (var user in users)
                            Users.Add(user);
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Error!", ex.Message, "Ok");
                }
                finally
                {
                    IsBusy = false;
                }

            }
        }
        [RelayCommand]
        private async Task GoToDetail()
        {
            if (userSeleccionado == null)
            {
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new UserDetallePage(userSeleccionado.Id), true);
        }
    }
}

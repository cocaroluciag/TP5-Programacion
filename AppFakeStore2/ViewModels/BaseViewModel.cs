using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace AppFakeStore2.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private string title;
}
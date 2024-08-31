namespace IRC_Client.ViewModels;

using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _CurrentViewModel = new LoginPageViewModel();

    [RelayCommand]
    private void ActiveView(string desiredViewModel)
    {
        CurrentViewModel = desiredViewModel switch
        {
            "Login" => new LoginPageViewModel(),
            "Chat" => new ServerChatViewModel(),
            _ => throw new ArgumentException($"Given View Model: {desiredViewModel}, does not exist!")
        };
    }
}

namespace IRC_Client.ViewModels;
public partial class LoginPageViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string AppTitle => "WormChat";
    public string Server => "Server";
    public string Port => "Port";
    public string Channel => "Channel";
    public string Nickname => "Nickname";
    public string Password => "Password (optional)";
#pragma warning restore CA1822 // Mark members as static 
}

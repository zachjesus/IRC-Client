namespace IRC_Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string AppTitle => "WormChat";
    public string Server => "Blank";
    public string Port => "Blank";
    public string Channel => "Blank";
    public string Nickname => "Blank";
    public string Password => "Blank";
#pragma warning restore CA1822 // Mark members as static
}

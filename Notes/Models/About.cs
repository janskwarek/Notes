namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app i written in xaml and in c# .NET MAUI.";
    public string MoreInfoText => "Learn more ...";
    public string LogoSource => "dotnet_bot.png";
    public string LogoDescription => "Bot dontnetowy";
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        
    }
    if(BindingContect is Models.About about){
        await Launcher.Deafult.OpenAsync(about.MoreInfoUrl);
    }
    private async void LernMore_Clicks(object? sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}
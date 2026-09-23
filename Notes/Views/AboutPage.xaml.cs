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
   
    private async void LernMore_Clicks(object? sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
        if(BindingContext is Models.About about){
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}
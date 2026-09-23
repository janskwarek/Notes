using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Models;

namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
        
        BindingContext = new Models.AllNotes();
    }

    protected override void OnAppearing()
    {
        ((Models:AllNotes))BindingContext).LoadNotes();
    }
    private async void Add_Clicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(NotePage)}");
    }

    private async void NotesCollection_CollectionChanged(object sender,
        System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var note = (Models.Note)e.CurrentSelection[0];
            await Shell.Current.GoToAsync($"//{nameof(NotePage)}?{nameof(NotePage.ItemId)}={Note.fileName}");
        }
    }
}
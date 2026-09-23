using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace Notes;

public partial class NotePage : ContentPage
{
    private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage()
    {
        InitializeComponent();
        string appDataPath = FIleSystem.AppDataDictionary;
        string randomFIle = $"{Path.GetRandomFileName()}.notes.txt";
        
        LoadNote(Path.Combine(appDataPath, randomFIle));
        
    }

    private void LoadNote(string fileName)
    {
        Models.Note noteModel = new Models.Note();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }
        BindingContext = noteModel;
    }
    private void SaveButton_Clicked(object? sender, EventArgs e)
    {
        File.WriteAllText(_fileName, TextEditor.Text);
    }

    private void DeleteButton_Clicked(object? sender, EventArgs e)
    {
        if(File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        TextEditor.Text = string .Empty;
    }
}
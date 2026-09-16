namespace Notes.Models;

    internal class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DataTime Date { get; set; }
        public string EditerPlaceHolder => "Enter your note.";
        public string SaveButtonText => "Save";
        public string DeleteButtonText => "Delete";
    }

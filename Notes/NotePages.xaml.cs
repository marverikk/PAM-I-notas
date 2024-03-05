namespace Notes;

public partial class NotePages : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    //Método Construtor 
    public NotePages()
    {
        InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);

    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, TextEditor.Text);
        await DisplayAlert(nameof(NotePages) , "Arquivo criado com sucesso!", "Acabou");
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
            File.Delete(_fileName);
        await DisplayAlert(nameof(NotePages), "Arquivo deletado com sucesso!", "Acabou");
        TextEditor.Text = string.Empty;
    }
}
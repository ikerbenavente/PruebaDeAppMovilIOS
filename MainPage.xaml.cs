namespace pruebaMaui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterBtn.Text = $"Haz hecho clic {count} veces";
    }
}
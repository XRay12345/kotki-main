namespace kotki;

public partial class Dkotkiu : ContentPage
{
	public Dkotkiu()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

}
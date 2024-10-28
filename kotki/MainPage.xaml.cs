namespace kotki
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Dkot_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Dkotkiu)}");
        }

        private async void kalendarz_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Kalendarz)}");

        }
    }

}

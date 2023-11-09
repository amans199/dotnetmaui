namespace MauiApp1;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnGoToCountry1Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CountryPage1());
    }

    private async void OnGoToCountry2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CountryPage2());
    }

    private async void OnGoToCountry3Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CountryPage3());
    }

    private async void OnGoToCountry4Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CountryPage4());
    }
}


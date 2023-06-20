namespace MauiApp2;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{

        InitializeComponent();
    }

    private async void OnOpenVideoPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VideoPage());
    }
}


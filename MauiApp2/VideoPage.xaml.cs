

namespace MauiApp2;

public partial class VideoPage : ContentPage
{

    public VideoPage()
    {
        InitializeComponent();
        LoadVideo();
    }

    private void LoadVideo()
    {
        string youtubeVideoUrl = "https://www.youtube.com/embed/Hh279ES_FNQ";
        myWebView.Source = new UrlWebViewSource { Url = youtubeVideoUrl };
    }
      private async void OnEnterUserDataClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserDataPage());
        }
}

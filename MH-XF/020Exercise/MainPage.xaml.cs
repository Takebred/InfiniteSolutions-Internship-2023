using Microsoft.Maui.Controls.PlatformConfiguration;

namespace _020Exercise;

public partial class MainPage : ContentPage
{
    string[] quoteArray = new string[4] {
    "Welcome, You !",
    "Do you know what I am learning now ?",
    "Guess...",
	"I'm learning .NET MAUI ! Hihihi !"
    };
    int showedQuote = 0;

    public MainPage()
	{
		InitializeComponent();
        if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			Padding = new Thickness(20, 30, 20, 20);
		}
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
		{
            Padding = new Thickness(20, 40, 20, 20);
        }
        quote.Text = quoteArray[showedQuote];
    }

    private void ShowNextQuote(object sender, EventArgs e)
    {
        if (showedQuote<3) {
            showedQuote++;
        }
        else
        {
            showedQuote = 0;
        }
        quote.Text = quoteArray[showedQuote];
    }
}


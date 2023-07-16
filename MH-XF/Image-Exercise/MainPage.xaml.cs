namespace Image_Exercise;

public partial class MainPage : ContentPage
{
    string[] sources =
	{
        "https://cdn.pixabay.com/photo/2017/02/25/17/38/george-washington-bridge-2098351_1280.jpg",
        "https://cdn.pixabay.com/photo/2014/02/17/10/20/statue-of-liberty-267949_1280.jpg",
        "https://cdn.pixabay.com/photo/2013/04/16/14/22/brooklyn-bridge-105079_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/03/11/12/31/buildings-668616_1280.jpg",
        "https://cdn.pixabay.com/photo/2014/01/04/13/34/taxi-238478_1280.jpg"
	};
    int showedImage = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    public void NavigateNext(object sender, EventArgs e)
	{
        if (showedImage<4)
        {
            showedImage++;
        }else 
        { 
            showedImage = 0; 
        }
        image.Source = sources[showedImage];
    }

    public void NavigatePrevious(object sender, EventArgs e)
    {
        if (showedImage > 0)
        {
            showedImage--;
        }
        else
        {
            showedImage = 4;
        }
        image.Source = sources[showedImage];
    }
}


namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void OnCounterClickedAstackLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage3());
    }
}

namespace NgajiLagi.View;

public partial class LupaPassword : ContentPage
{
	public LupaPassword()
	{
		InitializeComponent();
	}

	private async void BackLogin(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Login());
	}

	void OnScrollView(Object sender, ScrolledEventArgs e)
	{
		ScrollView scroll = new ScrollView();
		scroll.Scrolled += OnScrollView;
	}

	void Password_TextChange(object sender, TextChangedEventArgs e)
	{
		if(Password.Text == "")
		{
			button.IsEnabled = false;
			button.BackgroundColor = Color.FromHex("#C0C0C0");
        }
		else
		{
			button.IsEnabled = true;
			button.BackgroundColor = Color.FromHex("#88984A");
		}
    }
}
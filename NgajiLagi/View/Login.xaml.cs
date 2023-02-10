using Microsoft.Maui.Controls;

namespace NgajiLagi.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void LupaPassword(object sender, EventArgs e)
	{
        await Navigation.PushModalAsync(new LupaPassword());
    }

	void OnScrollViewLogin(object sender, ScrolledEventArgs e)
	{
		ScrollView Scroll = new ScrollView();
		Scroll.Scrolled += OnScrollViewLogin;
	}

}
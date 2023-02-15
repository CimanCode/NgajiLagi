namespace NgajiLagi.View;

public partial class UserProfile : ContentPage
{
	public UserProfile()
	{
		InitializeComponent();
	}

	private async void EditProfile(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new EditProfile());
	}

	private async void GantiPassword(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new GantiPassword());
	}
}
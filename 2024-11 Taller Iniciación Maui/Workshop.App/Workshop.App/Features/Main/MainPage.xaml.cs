namespace Workshop.App.Features.Main;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = ViewModel = new MainViewModel();
	}

	public MainViewModel ViewModel { get; }

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		try
		{
			await ViewModel.OnAppearingAsync();
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}


namespace Workshop.App.Features.PostDetail;

public partial class PostDetailPage : ContentPage
{
	public PostDetailPage()
	{
		InitializeComponent();
		BindingContext = ViewModel = new PostDetailViewModel();
	}


	public PostDetailViewModel ViewModel { get; }


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
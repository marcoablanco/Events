namespace Workshop.App.Features.Main;

using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Windows.Input;

public partial class MainViewModel : ObservableObject
{
	private const string url = "https://notodoesprogramacion.net/";
	//private const string url = "https://geekstorming.wordpress.com/";
	private const string getPost = "wp-json/wp/v2/posts";
	private List<PostModel>? allPosts;

	public MainViewModel()
	{
		TapCommand = new Command(async post => await Shell.Current.GoToAsync("PostDetail", true, new Dictionary<string, object> { { "Post", post } }));
	}


	[ObservableProperty]
	private List<PostModel>? posts;

	[ObservableProperty]
	private string? userSearch;

	public ICommand TapCommand { get; }



	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		base.OnPropertyChanged(e);
		if (e.PropertyName == nameof(UserSearch))
		{
			Posts = allPosts.Where(p => p.Title.Rendered.Contains(UserSearch)).ToList();
		}
	}


	public async Task OnAppearingAsync()
	{
		try
		{
			HttpClientHandler handler = new HttpClientHandler();

			HttpClient client = new HttpClient(handler, true);
			client.BaseAddress = new Uri(url);

			HttpResponseMessage response = await client.GetAsync(getPost);
			response.EnsureSuccessStatusCode();

			string resultString = await response.Content.ReadAsStringAsync();

			var posts = System.Text.Json.JsonSerializer.Deserialize<List<PostModel>>(resultString);
			allPosts = posts;
			Posts = allPosts;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
			throw;
		}


		//WordPressClient client = new WordPressClient(url, "wp/v2/");
		//var posts = await client.Posts.GetAllAsync();
		//Posts = posts;
	}
}
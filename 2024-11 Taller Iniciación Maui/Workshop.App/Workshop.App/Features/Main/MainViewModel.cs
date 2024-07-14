namespace Workshop.App.Features.Main;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainViewModel : ObservableObject
{
	private const string url = "https://notodoesprogramacion.net/";
	//private const string url = "https://geekstorming.wordpress.com/";
	private const string getPost = "wp-json/wp/v2/posts";


	[ObservableProperty]
	private List<PostModel> posts;


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
			Posts = posts;
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
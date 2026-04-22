namespace Workshop.App.Features.PostDetail;

using CommunityToolkit.Mvvm.ComponentModel;
using System.Net;
using Workshop.App.Features.Main;

public partial class PostDetailViewModel : ObservableObject, IQueryAttributable
{
	[ObservableProperty]
	public PostModel? post;

	[ObservableProperty]
	public string title;


	[ObservableProperty]
	public string content;

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (query.ContainsKey("Post"))
		{
			Post = query["Post"] as PostModel;
			Title = WebUtility.HtmlDecode(Post.Title.Rendered);
			Content = Post.Content.Rendered;
		}
	}

	public async Task OnAppearingAsync()
	{
	}

}

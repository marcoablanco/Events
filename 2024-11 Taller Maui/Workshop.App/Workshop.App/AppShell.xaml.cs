namespace Workshop.App;

using Workshop.App.Features.PostDetail;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("PostDetail", typeof(PostDetailPage));
	}
}

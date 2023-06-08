namespace SampleApp2;

using SampleApp2.Feature.Login;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		MainPage = new LoginPage { ViewModel = new LoginViewModel(serviceProvider) } ;
	}
}

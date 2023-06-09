namespace SampleApp2;

using SampleApp2.Feature.Login;
using SampleApp2.Feature.Main;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		//MainPage = new Feature.Main.MainPage { ViewModel = new MainViewModel() };
        MainPage = new LoginPage { ViewModel = new LoginViewModel(serviceProvider) } ;
    }
}

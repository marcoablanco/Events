namespace SampleApp2.Feature.Login;

using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;

public class LoginViewModel : ReactiveObject
{
	private readonly ILoginService loginService;
	private string userName;
	private string password;

	public LoginViewModel(IServiceProvider serviceProvider)
	{
		loginService = serviceProvider.GetRequiredService<ILoginService>();

		LoginCommand = ReactiveCommand.CreateFromTask(LoginCommandExecuteAsync, CanLoginCommand);
	}

	public string UserName
	{
		get => userName;
		set => this.RaiseAndSetIfChanged(ref userName, value);
	}

	public string Password
	{
		get => password;
		set => this.RaiseAndSetIfChanged(ref password, value);
	}

	public IObservable<bool> CanLoginCommand => this.WhenAnyValue(vm => vm.UserName, vm => vm.Password)
													.Select(x => !string.IsNullOrEmpty(x.Item1) && !string.IsNullOrEmpty(x.Item2));

	public ReactiveCommand<Unit, Unit> LoginCommand { get; }



	private async Task LoginCommandExecuteAsync()
	{
		try
		{
			await loginService.AuthenticateAsync(UserName, Password);

			await Application.Current.MainPage.DisplayAlert("Weeee!", "Te has logueado!", "OK");
		}
		catch (Exception ex)
		{
			await Application.Current.MainPage.DisplayAlert("Vaya!", "Ha fallao el login", "OK");
			throw;
		}
	}
}

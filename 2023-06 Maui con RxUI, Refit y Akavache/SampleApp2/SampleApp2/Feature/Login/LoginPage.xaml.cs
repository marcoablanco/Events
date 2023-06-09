namespace SampleApp2.Feature.Login;

using ReactiveUI;
using System.Reactive.Disposables;

public partial class LoginPage
{
	public LoginPage()
	{
		InitializeComponent();

		this.WhenActivated(d => WhenActivated(d));
	}

	private CompositeDisposable WhenActivated(CompositeDisposable disposables)
	{
		ViewModel.OnActivated(disposables); 

		disposables.Add(this.OneWayBind(ViewModel, vm => vm.IsLoading, v => v.ControlLoading.IsVisible));

		disposables.Add(this.Bind(ViewModel, vm => vm.UserName, v => v.TxtUser.Text));
		disposables.Add(this.Bind(ViewModel, vm => vm.Password, v => v.TxtPassword.Text));

		disposables.Add(this.BindCommand(ViewModel, vm => vm.LoginCommand, v => v.BtnLogin));

		return disposables;
	}
}
namespace SampleApp2.Feature.Login;

using EnsureThat;
using System;
using System.Threading.Tasks;

internal class LoginService : ILoginService
{
	public async Task AuthenticateAsync(string username, string password)
	{
		Ensure.String.IsNotEmptyOrWhiteSpace(username);
		Ensure.String.IsNotEmptyOrWhiteSpace(password);

		await Task.Delay(TimeSpan.FromSeconds(2));
	}
}

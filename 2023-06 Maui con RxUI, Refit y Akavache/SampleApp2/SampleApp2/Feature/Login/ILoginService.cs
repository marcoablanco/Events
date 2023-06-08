namespace SampleApp2.Feature.Login;

using System.Threading.Tasks;

public interface ILoginService
{
	Task AuthenticateAsync(string username, string password);
}
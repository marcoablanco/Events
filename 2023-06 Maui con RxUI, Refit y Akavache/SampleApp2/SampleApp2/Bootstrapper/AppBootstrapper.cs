namespace SampleApp2.Bootstrapper;

using SampleApp2.Feature.Login;

public static class AppBootstrapper
{
	public static MauiAppBuilder InitApp(this MauiAppBuilder builder)
	{
		return builder.AddServices();
	}

	private static MauiAppBuilder AddServices(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<ILoginService, LoginService>();

		return builder;
	}

}

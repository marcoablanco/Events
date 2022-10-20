namespace Monkeinjection.App;

using Monkeinjection.App.Services;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<AppShell>()
						.AddSingleton<MainPage>();


		builder.Services.AddTransient<ITransientService>(_ => new TransientService())
						.AddScoped<IScopeService>(_ => new ScopeService())
						.AddSingleton<ISingletonService>(_ => new SingletonService());

		return builder.Build();
	}
}

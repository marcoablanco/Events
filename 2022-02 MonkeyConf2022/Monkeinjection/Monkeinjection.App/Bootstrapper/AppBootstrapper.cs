namespace Monkeinjection.App.Bootstrapper;

using Monkeinjection.App.Features.GenericRepositorySample;
using Monkeinjection.App.Features.GenericRepositorySample.Services;
using Monkeinjection.App.Features.LogSample;
using Monkeinjection.App.Features.ScopesSample;
using Monkeinjection.App.Features.ScopesSample.Services;

public static class AppBootstrapper
{
	public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
	{


		builder.Services.AddSingleton<AppShell>()
						.AddSingleton<MainPage>()
						.AddSingleton<LogSamplePage>()
						.AddSingleton<GenericRepositorySamplePage>();

		// Repository sample
		builder.Services.AddTransient(_ => Preferences.Default);
		builder.Services.AddSingleton(typeof(IRepositoryService<>), typeof(RepositoryService<>));

		// Scopes sample
		builder.Services.AddTransient<ITransientService>(_ => new TransientService())
						.AddScoped<IScopeService>(_ => new ScopeService())
						.AddSingleton<ISingletonService>(_ => new SingletonService());


		return builder;
	}
}

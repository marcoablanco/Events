namespace Monkeinjection.App.Services;
using System;

internal class TransientService : ITransientService
{
	private string name;

	public TransientService()
	{
		name = $"Transient: {Guid.NewGuid()}.";
	}

	public string GetName()
	{
		return name;
	}
}

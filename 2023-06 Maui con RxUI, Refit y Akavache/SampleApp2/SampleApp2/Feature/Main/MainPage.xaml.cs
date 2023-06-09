namespace SampleApp2.Feature.Main;

using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();
		this.WhenActivated(d => OnActivated(d));
	}

	private CompositeDisposable OnActivated(CompositeDisposable disposables)
	{
		ViewModel.OnActivated(disposables);

		disposables.Add(this.OneWayBind(ViewModel, vm => vm.ColorNames, v => v.ListMain.ItemsSource));
		disposables.Add(this.Bind(ViewModel, vm => vm.SearchText, v => v.TxtSearch.Text));
		return disposables;
	}
}
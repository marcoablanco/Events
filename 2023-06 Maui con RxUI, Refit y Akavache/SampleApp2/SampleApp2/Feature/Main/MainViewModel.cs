namespace SampleApp2.Feature.Main;

using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reflection;

public class MainViewModel : ReactiveObject
{
	private List<string> colors;
	private ObservableCollection<string> colorNames;
	private string searchText;

	public MainViewModel()
	{
		colors = new List<string>();
		List<FieldInfo> properties = typeof(Colors).GetFields().ToList();
		colors.AddRange(properties.Select(p => p.Name).ToList());

		ColorNames = new ObservableCollection<string>(colors);

	}

	public string SearchText
	{
		get => searchText;
		set => this.RaiseAndSetIfChanged(ref searchText, value);
	}

	public ObservableCollection<string> ColorNames
	{
		get => colorNames;
		set => this.RaiseAndSetIfChanged(ref colorNames, value);
	}
	internal void OnActivated(CompositeDisposable disposables)
	{
		disposables.Add(this.WhenAnyValue(vm => vm.SearchText)
							.WhereNotNull()
							.Select(s => colors.Where(c => c.ToLower().Contains(searchText.ToLower())))
							.ObserveOn(RxApp.MainThreadScheduler)
							.Subscribe(r => ColorNames = new ObservableCollection<string>(r)));
	}
}

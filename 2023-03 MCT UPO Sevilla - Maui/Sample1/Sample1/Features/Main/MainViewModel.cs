namespace Sample1.Features.Main;
public class MainViewModel : BindableObject
{
	private string text;
	private string result;

	public MainViewModel()
	{
		ToUpperCommand = new Command(() => Result = Text.ToUpper());
	}


	public string Text
	{
		get => text;
		set { text = value; OnPropertyChanged(); }
	}


	public string Result
	{
		get => result;
		set { result = value; OnPropertyChanged(); }
	}

	public Command ToUpperCommand { get; }
}

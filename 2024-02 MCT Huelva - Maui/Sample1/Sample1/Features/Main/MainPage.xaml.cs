namespace Sample1.Features.Main;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
		ModifyEntry();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		Animation animation = new Animation();
		animation.Add(0, 0.5, new Animation(x => RectBall.TranslationY = x, 0, -100, Easing.CubicOut));
		animation.Add(0.5, 1, new Animation(x => RectBall.TranslationY = x, -100, 0, Easing.BounceOut));
		animation.Commit(this, "BallAnimation", 16, 1000, null, null, () => true);
	}

	private void ModifyEntry()
	{
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
		{
#if ANDROID
			handler.PlatformView.SetSelectAllOnFocus(true);
#elif IOS || MACCATALYST
            handler.PlatformView.EditingDidBegin += (s, e) =>
            {
                handler.PlatformView.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
            };
#elif WINDOWS
            handler.PlatformView.GotFocus += (s, e) =>
            {
                handler.PlatformView.SelectAll();
            };
#endif
		});
	}
}
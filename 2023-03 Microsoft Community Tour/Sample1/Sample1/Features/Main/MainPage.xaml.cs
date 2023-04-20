namespace Sample1.Features.Main;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
		ModifyEntry();
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
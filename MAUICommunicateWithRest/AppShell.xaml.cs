using MAUICommunicateWithRest.Views;

namespace MAUICommunicateWithRest;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();
        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}

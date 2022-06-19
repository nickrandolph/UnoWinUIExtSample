
namespace UnoWinUIExtSample.Views;

public sealed partial class MainPage : Page
{
	public MainViewModel? ViewModel => DataContext as MainViewModel;
	public MainPage()
	{
		this.InitializeComponent();
	}
}

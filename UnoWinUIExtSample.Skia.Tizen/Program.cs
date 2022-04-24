using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoWinUIExtSample.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new UnoWinUIExtSample.App(), args);
		host.Run();
	}
}
}

using Avalonia;
using Avalonia.Headless;
using BullCommander.Tests;

[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]
namespace BullCommander.Tests
{
    public class TestAppBuilder
    {
        public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>()
            .UseHeadless(new AvaloniaHeadlessPlatformOptions());
    }
}
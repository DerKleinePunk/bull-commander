using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Headless.XUnit;
using Xunit;

namespace BullCommander.Tests
{
    public class MainWindowTests
    {
        [AvaloniaFact]
        public void Should_Type_Text_Into_TextBox()
        {
            // Setup controls:
            var textBox = new TextBox();
            var window = new Window { Content = textBox };

            // Open window:
            window.Show();

            // Focus text box:
            textBox.Focus();

            // Simulate text input:
            window.KeyTextInput("Hello World");

            // Assert:
            Assert.Equal("Hello World", textBox.Text);
        }
    }
}

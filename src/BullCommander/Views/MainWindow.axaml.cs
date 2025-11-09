using Avalonia;
using Avalonia.Controls;

namespace BullCommander.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif

    }
}
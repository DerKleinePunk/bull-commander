using Avalonia.Controls;
using BullCommander.Services;
using System;

namespace BullCommander.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly IMainService _mainService;

    public MainWindowViewModel(IMainService mainService)
    {
        ArgumentNullException.ThrowIfNull(mainService);

        _mainService = mainService;
    }

    public MainWindowViewModel()
    {
        if (!Design.IsDesignMode)
        {
            throw new AccessViolationException("do not use this");
        }

        //Todo ?
        _mainService = new MainService();
    }

    public string Greeting { get; } = "Welcome to Avalonia!";
}

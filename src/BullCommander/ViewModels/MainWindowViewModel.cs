using Avalonia.Controls;
using BullCommander.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

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

    //Be Careful with Names
    //https://github.com/CommunityToolkit/dotnet/issues/804
    [RelayCommand]
    private async Task AddServerAsync()
    {

        var serverList = await _mainService.GetServerList();
        /*var album = await WeakReferenceMessenger.Default.Send(new PurchaseAlbumMessage());
        if (album is not null)
        {
            Albums.Add(album);
            await album.SaveToDiskAsync();
        }*/
    }
}

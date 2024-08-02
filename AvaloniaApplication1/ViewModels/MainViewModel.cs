using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel( )
    {
    }


    public string Greeting => "Welcome to Avalonia!";

    [ObservableProperty] private UserControl? _contentView;
}

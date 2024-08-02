using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;

namespace AvaloniaApplication1;

public partial class TestView : UserControl
{
    private readonly ViewModel _viewModel;

    public TestView( )
    {
        InitializeComponent( );

        var find = new string[0].Single( );


        _viewModel = new ViewModel( );
        this.DataContext = _viewModel;
    }
}


partial class TestView
{
    internal partial class ViewModel : ObservableObject
    {
        public ViewModel( )
        {
            //var find = new string[0].Single( );
        }
    }
}
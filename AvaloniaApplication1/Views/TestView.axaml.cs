using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;

namespace AvaloniaApplication1;

public partial class TestView : UserControl
{
    public TestView( )
    {
        InitializeComponent( );

        // �����쳣
        var find = new string[0].Single( );
    }
}

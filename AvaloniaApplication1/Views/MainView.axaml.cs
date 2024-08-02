using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{
    public MainView( )
    {
        InitializeComponent( );

      

    }

    protected override void OnLoaded( RoutedEventArgs e )
    {
        base.OnLoaded( e );

        if ( App.ServiceProvider != null )
        {
            var view = App.ServiceProvider.GetRequiredService<TestView>( );
        }

        {
            var insetsManager = TopLevel.GetTopLevel( this )?.InsetsManager;

            if ( insetsManager != null )
            {
                insetsManager.IsSystemBarVisible = false;
                insetsManager.DisplayEdgeToEdge = true;
            }
        }
    }
}

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;

using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApplication1;

public partial class App : Application
{
    public static ServiceProvider? ServiceProvider;

    public override void Initialize( )
    {
        AvaloniaXamlLoader.Load( this );

        // UI线程
        AppDomain.CurrentDomain.UnhandledException += ( s, e ) =>
        {
            System.Diagnostics.Debug.WriteLine( $"发生未处理异常: {e}" );
        };

        TaskScheduler.UnobservedTaskException += ( s, e ) =>
        {
            e.SetObserved( );   // 防止异常终止程序

            foreach ( var ex in e.Exception.InnerExceptions )
            {
                System.Diagnostics.Debug.WriteLine( $"发生未处理的Task异常: {e}" );
            }
        };
    }

    public override void OnFrameworkInitializationCompleted( )
    {
        var services = new ServiceCollection( );

        services.AddTransient<TestView>( );

        ServiceProvider = services.BuildServiceProvider( );



        // Line below is needed to remove Avalonia data validation.
        // Without this line you will get duplicate validations from both Avalonia and CT
        BindingPlugins.DataValidators.RemoveAt( 0 );


        if ( ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop )
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if ( ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform )
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel( )
            };
        }

        base.OnFrameworkInitializationCompleted( );
    }
}

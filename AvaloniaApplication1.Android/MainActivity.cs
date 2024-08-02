using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Avalonia;
using Avalonia.Android;

namespace AvaloniaApplication1.Android;

[Activity(
    Label = "AvaloniaApplication1.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode )]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder( AppBuilder builder )
    {
        return base.CustomizeAppBuilder( builder )
            .WithInterFont( );
    }

    protected override void OnCreate( Bundle? savedInstanceState )
    {
        base.OnCreate( savedInstanceState );

        Java.Lang.Thread.DefaultUncaughtExceptionHandler = new MyUncaughtExceptionHandler( this );
    }
}



class MyUncaughtExceptionHandler : Java.Lang.Object, Java.Lang.Thread.IUncaughtExceptionHandler
{
    private readonly Context _context;

    public MyUncaughtExceptionHandler( Context context )
    {
        _context = context;
    }

    public void UncaughtException( Java.Lang.Thread t, Java.Lang.Throwable e )
    {
        System.Diagnostics.Debug.WriteLine( $"An error occurred: {e}" );

        System.Environment.Exit( 1 );
    }
}

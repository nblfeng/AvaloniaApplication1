﻿using Android.App;
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
}



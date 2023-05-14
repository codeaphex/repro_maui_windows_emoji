using System.Reflection;

namespace Emoji_Issue_Windows;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        versionLabel.Text = Version;

    }

    public string Version =>
    $"VERSION:{Environment.NewLine}{typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}";
}


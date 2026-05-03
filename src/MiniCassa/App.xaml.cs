using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace MiniCassa;

/// <summary>
/// Classe principale dell'applicazione WPF.
/// </summary>
/// <remarks>
/// Qui configuriamo le impostazioni globali dell'applicazione
/// e decidiamo quale finestra mostrare all'avvio.
/// </remarks>
public partial class App : Application
{
    /// <summary>
    /// Metodo chiamato all'avvio dell'applicazione.
    /// </summary>
    /// <param name="e">Argomenti dell'evento di avvio.</param>
    protected override void OnStartup(StartupEventArgs e)
    {
        ConfiguraCulturaItaliana();

        base.OnStartup(e);

        // Evita che l'applicazione si chiuda quando viene chiuso lo splash screen.
        ShutdownMode = ShutdownMode.OnExplicitShutdown;

        SplashWindow splashWindow = new();
        splashWindow.ShowDialog();

        MainWindow mainWindow = new();
        MainWindow = mainWindow;

        // Da questo momento l'applicazione si chiude quando si chiude MainWindow.
        ShutdownMode = ShutdownMode.OnMainWindowClose;

        mainWindow.Show();
    }

    /// <summary>
    /// Imposta la cultura italiana per numeri, date, valute e binding XAML.
    /// </summary>
    private static void ConfiguraCulturaItaliana()
    {
        CultureInfo culturaItaliana = new("it-IT");

        Thread.CurrentThread.CurrentCulture = culturaItaliana;
        Thread.CurrentThread.CurrentUICulture = culturaItaliana;

        CultureInfo.DefaultThreadCurrentCulture = culturaItaliana;
        CultureInfo.DefaultThreadCurrentUICulture = culturaItaliana;

        FrameworkElement.LanguageProperty.OverrideMetadata(
            typeof(FrameworkElement),
            new FrameworkPropertyMetadata(
                XmlLanguage.GetLanguage(culturaItaliana.IetfLanguageTag)));
    }
}
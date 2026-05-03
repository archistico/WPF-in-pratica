using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace MiniCassa;

/// <summary>
/// Classe principale dell'applicazione WPF.
/// </summary>
/// <remarks>
/// Qui configuriamo le impostazioni globali dell'applicazione,
/// tra cui la cultura italiana usata per formattare numeri, date e valute.
/// </remarks>
public partial class App : Application
{
    /// <summary>
    /// Metodo chiamato all'avvio dell'applicazione.
    /// </summary>
    /// <param name="e">Argomenti dell'evento di avvio.</param>
    protected override void OnStartup(StartupEventArgs e)
    {
        CultureInfo culturaItaliana = new("it-IT");

        // Imposta la cultura dei thread.
        Thread.CurrentThread.CurrentCulture = culturaItaliana;
        Thread.CurrentThread.CurrentUICulture = culturaItaliana;

        CultureInfo.DefaultThreadCurrentCulture = culturaItaliana;
        CultureInfo.DefaultThreadCurrentUICulture = culturaItaliana;

        // Imposta anche la Language predefinita degli elementi WPF.
        // Questa è la parte importante per i binding con StringFormat={}{0:C}.
        FrameworkElement.LanguageProperty.OverrideMetadata(
            typeof(FrameworkElement),
            new FrameworkPropertyMetadata(
                XmlLanguage.GetLanguage(culturaItaliana.IetfLanguageTag)));

        base.OnStartup(e);
    }
}
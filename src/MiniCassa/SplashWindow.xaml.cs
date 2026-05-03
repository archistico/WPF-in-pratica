using System.Windows;
using System.Windows.Threading;

namespace MiniCassa;

/// <summary>
/// Finestra di splash screen mostrata all'avvio dell'applicazione.
/// </summary>
/// <remarks>
/// Questa finestra viene visualizzata per pochi secondi prima della finestra principale.
/// L'animazione delle icone è definita nello XAML tramite Storyboard.
/// </remarks>
public partial class SplashWindow : Window
{
    private readonly DispatcherTimer _timer = new();

    /// <summary>
    /// Costruttore dello splash screen.
    /// </summary>
    public SplashWindow()
    {
        InitializeComponent();

        _timer.Interval = TimeSpan.FromSeconds(3);
        _timer.Tick += Timer_Tick;
    }

    /// <summary>
    /// Avvia il timer quando la finestra è stata caricata.
    /// </summary>
    /// <param name="sender">Oggetto che ha generato l'evento.</param>
    /// <param name="e">Argomenti dell'evento.</param>
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        _timer.Start();
    }

    /// <summary>
    /// Chiude lo splash screen allo scadere del timer.
    /// </summary>
    /// <param name="sender">Oggetto che ha generato l'evento.</param>
    /// <param name="e">Argomenti dell'evento.</param>
    private void Timer_Tick(object? sender, EventArgs e)
    {
        _timer.Stop();
        Close();
    }
}
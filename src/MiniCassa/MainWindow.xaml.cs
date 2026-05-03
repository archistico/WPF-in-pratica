using System.Windows;
using MiniCassa.ViewModels;

namespace MiniCassa;

/// <summary>
/// Finestra principale dell'applicazione MiniCassa.
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Costruttore della finestra principale.
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        // In questa versione semplice assegniamo il ViewModel direttamente
        // dal code-behind. È una scelta accettabile per un esempio didattico.
        DataContext = new CassaViewModel();
    }
}
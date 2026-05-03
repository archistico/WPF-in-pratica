using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiniCassa.Models;

/// <summary>
/// Rappresenta una singola riga del conto di un tavolo.
/// </summary>
/// <remarks>
/// Una riga del conto collega un piatto a una quantità.
/// 
/// Esempio:
/// - Piatto: "Pizza Margherita"
/// - Quantità: 2
/// - Totale: 15,00 euro
/// </remarks>
public class RigaConto : INotifyPropertyChanged
{
    private Piatto _piatto = new();
    private int _quantita = 1;

    /// <summary>
    /// Evento notificato quando cambia il valore di una proprietà.
    /// Serve al binding WPF per aggiornare automaticamente l'interfaccia.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Piatto associato alla riga del conto.
    /// </summary>
    public Piatto Piatto
    {
        get => _piatto;
        set
        {
            if (SetProperty(ref _piatto, value))
            {
                // Se cambia il piatto, cambia anche il totale della riga.
                OnPropertyChanged(nameof(Totale));
            }
        }
    }

    /// <summary>
    /// Quantità ordinata del piatto.
    /// </summary>
    public int Quantita
    {
        get => _quantita;
        set
        {
            // Evitiamo quantità inferiori a 1.
            // La rimozione della riga sarà gestita da un comando separato.
            if (value < 1)
                value = 1;

            if (SetProperty(ref _quantita, value))
            {
                // Se cambia la quantità, cambia anche il totale della riga.
                OnPropertyChanged(nameof(Totale));
            }
        }
    }

    /// <summary>
    /// Totale della riga, calcolato moltiplicando prezzo unitario per quantità.
    /// </summary>
    public decimal Totale => Piatto.Prezzo * Quantita;

    /// <summary>
    /// Aggiorna una proprietà e notifica l'interfaccia solo se il valore è cambiato.
    /// </summary>
    /// <typeparam name="T">Tipo della proprietà da aggiornare.</typeparam>
    /// <param name="field">Campo privato associato alla proprietà.</param>
    /// <param name="value">Nuovo valore da assegnare.</param>
    /// <param name="propertyName">Nome della proprietà chiamante, compilato automaticamente.</param>
    /// <returns>
    /// True se il valore è stato modificato, false se il valore era già uguale.
    /// </returns>
    protected bool SetProperty<T>(
        ref T field,
        T value,
        [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    /// <summary>
    /// Notifica a WPF che una proprietà è cambiata.
    /// </summary>
    /// <param name="propertyName">Nome della proprietà modificata.</param>
    protected void OnPropertyChanged(string? propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
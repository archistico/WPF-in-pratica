using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiniCassa.Models;

/// <summary>
/// Rappresenta un piatto o un prodotto disponibile nel menu del ristorante.
/// </summary>
/// <remarks>
/// In questa versione didattica il piatto contiene solo le informazioni essenziali:
/// nome, categoria e prezzo.
/// 
/// In una versione più evoluta, questa classe potrebbe essere collegata a un database
/// e contenere anche ingredienti, allergeni, disponibilità, reparto di preparazione
/// o codice fiscale del prodotto.
/// </remarks>
public class Piatto : INotifyPropertyChanged
{
    private int _id;
    private string _nome = string.Empty;
    private string _categoria = string.Empty;
    private decimal _prezzo;

    /// <summary>
    /// Evento notificato quando cambia il valore di una proprietà.
    /// Serve al binding WPF per aggiornare automaticamente l'interfaccia.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Identificativo del piatto.
    /// </summary>
    public int Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    /// <summary>
    /// Nome visualizzato del piatto.
    /// Esempio: "Pizza Margherita", "Spaghetti alla carbonara", "Acqua naturale".
    /// </summary>
    public string Nome
    {
        get => _nome;
        set => SetProperty(ref _nome, value);
    }

    /// <summary>
    /// Categoria del piatto.
    /// Esempio: "Pizze", "Primi", "Bevande", "Dolci".
    /// </summary>
    public string Categoria
    {
        get => _categoria;
        set => SetProperty(ref _categoria, value);
    }

    /// <summary>
    /// Prezzo unitario del piatto.
    /// </summary>
    public decimal Prezzo
    {
        get => _prezzo;
        set => SetProperty(ref _prezzo, value);
    }

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
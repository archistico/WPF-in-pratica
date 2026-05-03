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
/// Abbiamo aggiunto anche una proprietà calcolata, <see cref="IconaCategoria"/>,
/// utile per mostrare rapidamente nel menu un'icona associata alla categoria.
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
    /// </summary>
    public string Nome
    {
        get => _nome;
        set => SetProperty(ref _nome, value);
    }

    /// <summary>
    /// Categoria del piatto.
    /// Esempi: "Pizze", "Primi", "Secondi", "Contorni", "Bevande", "Caffè".
    /// </summary>
    public string Categoria
    {
        get => _categoria;
        set
        {
            if (SetProperty(ref _categoria, value))
            {
                // Se cambia la categoria, può cambiare anche l'icona associata.
                OnPropertyChanged(nameof(IconaCategoria));
            }
        }
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
    /// Restituisce un'icona semplice associata alla categoria del piatto.
    /// </summary>
    /// <remarks>
    /// Usiamo emoji Unicode per evitare dipendenze esterne e mantenere
    /// l'esempio semplice e immediato.
    /// </remarks>
    public string IconaCategoria
    {
        get
        {
            string categoriaNormalizzata = Categoria.Trim().ToLowerInvariant();

            return categoriaNormalizzata switch
            {
                "pizze" => "🍕",
                "primi" => "🍝",
                "secondi" => "🍖",
                "contorni" => "🥗",
                "bevande" => "🥤",
                "caffè" => "☕",
                "caffe" => "☕",
                _ => "🍽"
            };
        }
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
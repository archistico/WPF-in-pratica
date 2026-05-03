using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiniCassa.Models;

/// <summary>
/// Rappresenta un tavolo del ristorante.
/// </summary>
/// <remarks>
/// Ogni tavolo possiede una lista di righe conto.
/// Il totale del tavolo viene calcolato sommando i totali delle singole righe.
/// 
/// In questa versione il tavolo non viene salvato su database.
/// Tutti i dati esistono solo in memoria durante l'esecuzione dell'applicazione.
/// </remarks>
public class Tavolo : INotifyPropertyChanged
{
    private int _id;
    private string _nome = string.Empty;
    private ObservableCollection<RigaConto> _righeConto = new();

    /// <summary>
    /// Evento notificato quando cambia il valore di una proprietà.
    /// Serve al binding WPF per aggiornare automaticamente l'interfaccia.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Identificativo del tavolo.
    /// </summary>
    public int Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    /// <summary>
    /// Nome visualizzato del tavolo.
    /// Esempio: "Tavolo 1", "Tavolo 2", "Sala esterna 1".
    /// </summary>
    public string Nome
    {
        get => _nome;
        set => SetProperty(ref _nome, value);
    }

    /// <summary>
    /// Righe del conto associate al tavolo.
    /// </summary>
    public ObservableCollection<RigaConto> RigheConto
    {
        get => _righeConto;
        set
        {
            if (_righeConto != null)
            {
                _righeConto.CollectionChanged -= RigheConto_CollectionChanged;
                ScollegaNotificheRighe(_righeConto);
            }

            if (SetProperty(ref _righeConto, value))
            {
                _righeConto.CollectionChanged += RigheConto_CollectionChanged;
                CollegaNotificheRighe(_righeConto);

                OnPropertyChanged(nameof(Totale));
                OnPropertyChanged(nameof(NumeroRighe));
                OnPropertyChanged(nameof(Occupato));
            }
        }
    }

    /// <summary>
    /// Totale corrente del tavolo.
    /// </summary>
    public decimal Totale => RigheConto.Sum(riga => riga.Totale);

    /// <summary>
    /// Numero di righe presenti nel conto.
    /// </summary>
    public int NumeroRighe => RigheConto.Count;

    /// <summary>
    /// Indica se il tavolo ha almeno una riga nel conto.
    /// </summary>
    public bool Occupato => RigheConto.Count > 0;

    /// <summary>
    /// Costruttore.
    /// Collega gli eventi necessari per aggiornare il totale quando cambia il conto.
    /// </summary>
    public Tavolo()
    {
        _righeConto.CollectionChanged += RigheConto_CollectionChanged;
    }

    /// <summary>
    /// Gestisce i cambiamenti nella collezione delle righe conto.
    /// </summary>
    /// <param name="sender">Oggetto che ha generato l'evento.</param>
    /// <param name="e">Informazioni sul cambiamento avvenuto nella collezione.</param>
    private void RigheConto_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.OldItems != null)
        {
            foreach (RigaConto riga in e.OldItems)
                riga.PropertyChanged -= RigaConto_PropertyChanged;
        }

        if (e.NewItems != null)
        {
            foreach (RigaConto riga in e.NewItems)
                riga.PropertyChanged += RigaConto_PropertyChanged;
        }

        OnPropertyChanged(nameof(Totale));
        OnPropertyChanged(nameof(NumeroRighe));
        OnPropertyChanged(nameof(Occupato));
    }

    /// <summary>
    /// Gestisce i cambiamenti di una singola riga del conto.
    /// </summary>
    /// <param name="sender">Riga del conto che ha generato l'evento.</param>
    /// <param name="e">Informazioni sulla proprietà modificata.</param>
    private void RigaConto_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(RigaConto.Totale) ||
            e.PropertyName == nameof(RigaConto.Quantita) ||
            e.PropertyName == nameof(RigaConto.Piatto))
        {
            OnPropertyChanged(nameof(Totale));
            OnPropertyChanged(nameof(Occupato));
        }
    }

    /// <summary>
    /// Collega la notifica di cambiamento proprietà a tutte le righe della collezione.
    /// </summary>
    /// <param name="righe">Collezione di righe da collegare.</param>
    private void CollegaNotificheRighe(IEnumerable<RigaConto> righe)
    {
        foreach (RigaConto riga in righe)
            riga.PropertyChanged += RigaConto_PropertyChanged;
    }

    /// <summary>
    /// Scollega la notifica di cambiamento proprietà da tutte le righe della collezione.
    /// </summary>
    /// <param name="righe">Collezione di righe da scollegare.</param>
    private void ScollegaNotificheRighe(IEnumerable<RigaConto> righe)
    {
        foreach (RigaConto riga in righe)
            riga.PropertyChanged -= RigaConto_PropertyChanged;
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
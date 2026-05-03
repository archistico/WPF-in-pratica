using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MiniCassa.Commands;
using MiniCassa.Models;

namespace MiniCassa.ViewModels;

/// <summary>
/// ViewModel principale dell'applicazione MiniCassa.
/// </summary>
/// <remarks>
/// Questo ViewModel contiene lo stato della cassa e le operazioni principali
/// che l'utente può eseguire dall'interfaccia grafica.
///
/// In questa prima versione i dati sono caricati in memoria.
/// Non usiamo ancora database, file JSON o servizi esterni, perché l'obiettivo
/// è concentrarsi sui concetti fondamentali di WPF, binding e MVVM.
/// </remarks>
public class CassaViewModel : INotifyPropertyChanged
{
    private Tavolo? _tavoloSelezionato;
    private Piatto? _piattoSelezionato;
    private RigaConto? _rigaSelezionata;

    /// <summary>
    /// Evento notificato quando cambia il valore di una proprietà.
    /// Serve al binding WPF per aggiornare automaticamente l'interfaccia.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Elenco dei tavoli disponibili.
    /// </summary>
    public ObservableCollection<Tavolo> Tavoli { get; } = new();

    /// <summary>
    /// Elenco dei piatti disponibili nel menu.
    /// </summary>
    public ObservableCollection<Piatto> Piatti { get; } = new();

    /// <summary>
    /// Tavolo attualmente selezionato dall'utente.
    /// </summary>
    public Tavolo? TavoloSelezionato
    {
        get => _tavoloSelezionato;
        set
        {
            if (_tavoloSelezionato == value)
                return;

            if (_tavoloSelezionato != null)
                _tavoloSelezionato.PropertyChanged -= TavoloSelezionato_PropertyChanged;

            _tavoloSelezionato = value;

            if (_tavoloSelezionato != null)
                _tavoloSelezionato.PropertyChanged += TavoloSelezionato_PropertyChanged;

            OnPropertyChanged();
            OnPropertyChanged(nameof(RigheContoCorrenti));
            OnPropertyChanged(nameof(TotaleCorrente));
            OnPropertyChanged(nameof(TitoloTavoloCorrente));

            AggiornaStatoComandi();
        }
    }

    /// <summary>
    /// Piatto attualmente selezionato dall'utente.
    /// </summary>
    public Piatto? PiattoSelezionato
    {
        get => _piattoSelezionato;
        set
        {
            if (SetProperty(ref _piattoSelezionato, value))
                AggiornaStatoComandi();
        }
    }

    /// <summary>
    /// Riga del conto attualmente selezionata.
    /// </summary>
    public RigaConto? RigaSelezionata
    {
        get => _rigaSelezionata;
        set
        {
            if (SetProperty(ref _rigaSelezionata, value))
                AggiornaStatoComandi();
        }
    }

    /// <summary>
    /// Righe del conto del tavolo selezionato.
    /// </summary>
    public ObservableCollection<RigaConto>? RigheContoCorrenti
    {
        get => TavoloSelezionato?.RigheConto;
    }

    /// <summary>
    /// Totale del conto del tavolo selezionato.
    /// </summary>
    public decimal TotaleCorrente
    {
        get => TavoloSelezionato?.Totale ?? 0m;
    }

    /// <summary>
    /// Titolo descrittivo del tavolo corrente.
    /// </summary>
    public string TitoloTavoloCorrente
    {
        get
        {
            if (TavoloSelezionato == null)
                return "Nessun tavolo selezionato";

            return $"Conto - {TavoloSelezionato.Nome}";
        }
    }

    /// <summary>
    /// Comando per aggiungere il piatto selezionato al conto del tavolo selezionato.
    /// </summary>
    public RelayCommand AggiungiPiattoCommand { get; }

    /// <summary>
    /// Comando per aumentare la quantità della riga selezionata.
    /// </summary>
    public RelayCommand AumentaQuantitaCommand { get; }

    /// <summary>
    /// Comando per diminuire la quantità della riga selezionata.
    /// </summary>
    public RelayCommand DiminuisciQuantitaCommand { get; }

    /// <summary>
    /// Comando per rimuovere la riga selezionata dal conto.
    /// </summary>
    public RelayCommand RimuoviRigaCommand { get; }

    /// <summary>
    /// Comando per svuotare completamente il conto del tavolo selezionato.
    /// </summary>
    public RelayCommand SvuotaContoCommand { get; }

    /// <summary>
    /// Costruttore del ViewModel principale.
    /// </summary>
    public CassaViewModel()
    {
        AggiungiPiattoCommand = new RelayCommand(
            execute: parametro => AggiungiPiatto(parametro),
            canExecute: parametro =>
                TavoloSelezionato != null &&
                (PiattoSelezionato != null || parametro is Piatto));

        AumentaQuantitaCommand = new RelayCommand(
            execute: parametro => AumentaQuantita(parametro),
            canExecute: parametro => OttieniRiga(parametro) != null);

        DiminuisciQuantitaCommand = new RelayCommand(
            execute: parametro => DiminuisciQuantita(parametro),
            canExecute: parametro => OttieniRiga(parametro) != null);

        RimuoviRigaCommand = new RelayCommand(
            execute: parametro => RimuoviRiga(parametro),
            canExecute: parametro => TavoloSelezionato != null && OttieniRiga(parametro) != null);

        SvuotaContoCommand = new RelayCommand(
            execute: _ => SvuotaConto(),
            canExecute: _ => TavoloSelezionato != null && TavoloSelezionato.RigheConto.Count > 0);

        CaricaDatiDimostrativi();

        TavoloSelezionato = Tavoli.FirstOrDefault();
    }

    /// <summary>
    /// Carica alcuni dati dimostrativi in memoria.
    /// </summary>
    /// <remarks>
    /// In questa versione non leggiamo i dati da database.
    /// I piatti e i tavoli vengono creati direttamente nel ViewModel
    /// per rendere l'esempio semplice e immediato.
    /// </remarks>
    private void CaricaDatiDimostrativi()
    {
        Tavoli.Add(new Tavolo { Id = 1, Nome = "Tavolo 1" });
        Tavoli.Add(new Tavolo { Id = 2, Nome = "Tavolo 2" });
        Tavoli.Add(new Tavolo { Id = 3, Nome = "Tavolo 3" });
        Tavoli.Add(new Tavolo { Id = 4, Nome = "Tavolo 4" });
        Tavoli.Add(new Tavolo { Id = 5, Nome = "Tavolo 5" });
        Tavoli.Add(new Tavolo { Id = 6, Nome = "Tavolo 6" });

        Piatti.Add(new Piatto
        {
            Id = 1,
            Nome = "Pizza Margherita",
            Categoria = "Pizze",
            Prezzo = 7.50m
        });

        Piatti.Add(new Piatto
        {
            Id = 2,
            Nome = "Pizza Diavola",
            Categoria = "Pizze",
            Prezzo = 8.50m
        });

        Piatti.Add(new Piatto
        {
            Id = 3,
            Nome = "Spaghetti al pomodoro",
            Categoria = "Primi",
            Prezzo = 9.00m
        });

        Piatti.Add(new Piatto
        {
            Id = 4,
            Nome = "Tagliatelle al ragù",
            Categoria = "Primi",
            Prezzo = 10.50m
        });

        Piatti.Add(new Piatto
        {
            Id = 5,
            Nome = "Cotoletta con patatine",
            Categoria = "Secondi",
            Prezzo = 13.00m
        });

        Piatti.Add(new Piatto
        {
            Id = 6,
            Nome = "Insalata mista",
            Categoria = "Contorni",
            Prezzo = 5.00m
        });

        Piatti.Add(new Piatto
        {
            Id = 7,
            Nome = "Tiramisù",
            Categoria = "Dolci",
            Prezzo = 5.50m
        });

        Piatti.Add(new Piatto
        {
            Id = 8,
            Nome = "Acqua naturale",
            Categoria = "Bevande",
            Prezzo = 2.00m
        });

        Piatti.Add(new Piatto
        {
            Id = 9,
            Nome = "Caffè",
            Categoria = "Bevande",
            Prezzo = 1.50m
        });
    }

    /// <summary>
    /// Aggiunge un piatto al conto del tavolo selezionato.
    /// </summary>
    /// <param name="parametro">
    /// Piatto ricevuto dal comando.
    /// Se il parametro è nullo, viene usato il piatto attualmente selezionato.
    /// </param>
    /// <remarks>
    /// Questo metodo viene usato sia dal pulsante "Aggiungi al conto",
    /// sia dal doppio click su un piatto del menu.
    /// 
    /// Se il piatto è già presente nel conto, non viene creata una nuova riga:
    /// viene semplicemente aumentata la quantità.
    /// </remarks>
    private void AggiungiPiatto(object? parametro)
    {
        if (TavoloSelezionato == null)
            return;

        Piatto? piattoDaAggiungere = parametro as Piatto ?? PiattoSelezionato;

        if (piattoDaAggiungere == null)
            return;

        // Se il piatto arriva dal doppio click, aggiorniamo anche la selezione.
        PiattoSelezionato = piattoDaAggiungere;

        RigaConto? rigaEsistente = TavoloSelezionato.RigheConto
            .FirstOrDefault(riga => riga.Piatto.Id == piattoDaAggiungere.Id);

        if (rigaEsistente != null)
        {
            rigaEsistente.Quantita++;
            RigaSelezionata = rigaEsistente;
        }
        else
        {
            RigaConto nuovaRiga = new()
            {
                Piatto = piattoDaAggiungere,
                Quantita = 1
            };

            TavoloSelezionato.RigheConto.Add(nuovaRiga);
            RigaSelezionata = nuovaRiga;
        }

        AggiornaProprietaContoCorrente();
        AggiornaStatoComandi();
    }

    /// <summary>
    /// Aumenta di uno la quantità della riga indicata.
    /// </summary>
    /// <param name="parametro">
    /// Riga ricevuta dal comando. Se il parametro è nullo,
    /// viene usata la riga attualmente selezionata.
    /// </param>
    private void AumentaQuantita(object? parametro)
    {
        RigaConto? riga = OttieniRiga(parametro);

        if (riga == null)
            return;

        riga.Quantita++;

        AggiornaProprietaContoCorrente();
        AggiornaStatoComandi();
    }

    /// <summary>
    /// Diminuisce di uno la quantità della riga indicata.
    /// </summary>
    /// <param name="parametro">
    /// Riga ricevuta dal comando. Se il parametro è nullo,
    /// viene usata la riga attualmente selezionata.
    /// </param>
    private void DiminuisciQuantita(object? parametro)
    {
        RigaConto? riga = OttieniRiga(parametro);

        if (riga == null)
            return;

        if (riga.Quantita > 1)
        {
            riga.Quantita--;
        }
        else
        {
            RimuoviRiga(riga);
            return;
        }

        AggiornaProprietaContoCorrente();
        AggiornaStatoComandi();
    }

    /// <summary>
    /// Rimuove una riga dal conto del tavolo selezionato.
    /// </summary>
    /// <param name="parametro">
    /// Riga ricevuta dal comando. Se il parametro è nullo,
    /// viene usata la riga attualmente selezionata.
    /// </param>
    private void RimuoviRiga(object? parametro)
    {
        if (TavoloSelezionato == null)
            return;

        RigaConto? riga = OttieniRiga(parametro);

        if (riga == null)
            return;

        TavoloSelezionato.RigheConto.Remove(riga);

        if (RigaSelezionata == riga)
            RigaSelezionata = null;

        AggiornaProprietaContoCorrente();
        AggiornaStatoComandi();
    }

    /// <summary>
    /// Svuota completamente il conto del tavolo selezionato.
    /// </summary>
    private void SvuotaConto()
    {
        if (TavoloSelezionato == null)
            return;

        TavoloSelezionato.RigheConto.Clear();
        RigaSelezionata = null;

        AggiornaProprietaContoCorrente();
        AggiornaStatoComandi();
    }

    /// <summary>
    /// Restituisce la riga su cui deve lavorare un comando.
    /// </summary>
    /// <param name="parametro">
    /// Parametro ricevuto dal comando.
    /// </param>
    /// <returns>
    /// La riga passata come parametro oppure la riga selezionata.
    /// </returns>
    private RigaConto? OttieniRiga(object? parametro)
    {
        if (parametro is RigaConto rigaDaParametro)
            return rigaDaParametro;

        return RigaSelezionata;
    }

    /// <summary>
    /// Gestisce i cambiamenti interni del tavolo selezionato.
    /// </summary>
    /// <param name="sender">Tavolo che ha generato l'evento.</param>
    /// <param name="e">Informazioni sulla proprietà modificata.</param>
    private void TavoloSelezionato_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Tavolo.Totale) ||
            e.PropertyName == nameof(Tavolo.NumeroRighe) ||
            e.PropertyName == nameof(Tavolo.Occupato))
        {
            AggiornaProprietaContoCorrente();
            AggiornaStatoComandi();
        }
    }

    /// <summary>
    /// Notifica all'interfaccia che le proprietà legate al conto corrente
    /// potrebbero essere cambiate.
    /// </summary>
    private void AggiornaProprietaContoCorrente()
    {
        OnPropertyChanged(nameof(RigheContoCorrenti));
        OnPropertyChanged(nameof(TotaleCorrente));
        OnPropertyChanged(nameof(TitoloTavoloCorrente));
    }

    /// <summary>
    /// Richiede a WPF di rivalutare se i comandi possono essere eseguiti.
    /// </summary>
    private void AggiornaStatoComandi()
    {
        AggiungiPiattoCommand.RaiseCanExecuteChanged();
        AumentaQuantitaCommand.RaiseCanExecuteChanged();
        DiminuisciQuantitaCommand.RaiseCanExecuteChanged();
        RimuoviRigaCommand.RaiseCanExecuteChanged();
        SvuotaContoCommand.RaiseCanExecuteChanged();
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
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
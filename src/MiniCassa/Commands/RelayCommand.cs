using System.Windows.Input;

namespace MiniCassa.Commands;

/// <summary>
/// Implementazione semplice e riutilizzabile di <see cref="ICommand"/>.
/// </summary>
/// <remarks>
/// In WPF i comandi permettono di collegare la UI alla logica del ViewModel
/// senza scrivere codice negli eventi dei pulsanti.
///
/// Questa classe viene chiamata "RelayCommand" perché riceve dall'esterno
/// le azioni da eseguire e le inoltra quando il comando viene invocato.
/// </remarks>
public class RelayCommand : ICommand
{
    private readonly Action<object?> _execute;
    private readonly Predicate<object?>? _canExecute;

    /// <summary>
    /// Evento usato da WPF per sapere quando deve rivalutare
    /// se il comando può essere eseguito oppure no.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Crea un nuovo comando.
    /// </summary>
    /// <param name="execute">
    /// Azione da eseguire quando il comando viene invocato.
    /// </param>
    /// <param name="canExecute">
    /// Funzione opzionale che stabilisce se il comando può essere eseguito.
    /// Se non viene fornita, il comando sarà sempre eseguibile.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// Generata se l'azione principale del comando è nulla.
    /// </exception>
    public RelayCommand(
        Action<object?> execute,
        Predicate<object?>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    /// <summary>
    /// Indica se il comando può essere eseguito nello stato corrente.
    /// </summary>
    /// <param name="parameter">
    /// Parametro passato dal binding, se presente.
    /// </param>
    /// <returns>
    /// True se il comando può essere eseguito, altrimenti false.
    /// </returns>
    public bool CanExecute(object? parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    /// <summary>
    /// Esegue l'azione associata al comando.
    /// </summary>
    /// <param name="parameter">
    /// Parametro passato dal binding, se presente.
    /// </param>
    public void Execute(object? parameter)
    {
        _execute(parameter);
    }

    /// <summary>
    /// Notifica a WPF che le condizioni di esecuzione del comando
    /// potrebbero essere cambiate.
    /// </summary>
    /// <remarks>
    /// Questo metodo è utile quando una proprietà del ViewModel cambia
    /// e un pulsante deve essere abilitato o disabilitato di conseguenza.
    /// </remarks>
    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
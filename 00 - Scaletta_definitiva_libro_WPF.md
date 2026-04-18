# Scaletta definitiva libro WPF

## PARTE 01 - Fondamenti di WPF

### 01.01.00 - Architettura di WPF
- 01.01.01 - L’idea base: una UI fatta di oggetti
- 01.01.02 - Albero logico e albero visuale
- 01.01.03 - La gerarchia delle classi: da `Object` a `Control`
- 01.01.04 - Il property system: uno dei cuori di WPF
- 01.01.05 - Layout: misura e disposizione
- 01.01.06 - Rendering: non solo controlli, ma anche grafica, testo e media
- 01.01.07 - Eventi instradati
- 01.01.08 - Dati, template e separazione delle responsabilità
- 01.01.09 - Il punto da portare a casa

### 01.02.00 - Ambiente di sviluppo
- 01.02.01 - WPF è Windows-only
- 01.02.02 - L’IDE di riferimento: Visual Studio
- 01.02.03 - Il workload da installare
- 01.02.04 - Creare un nuovo progetto WPF
- 01.02.05 - .NET moderno o .NET Framework?
- 01.02.06 - Cosa crea Visual Studio all’inizio
- 01.02.07 - Che ruolo hanno questi file
- 01.02.08 - L’editor XAML e il designer
- 01.02.09 - Build, esecuzione e debug
- 01.02.10 - NuGet e librerie esterne
- 01.02.11 - Publish e distribuzione
- 01.02.12 - Il punto da portare a casa

### 01.03.00 - Che cos’è WPF, che cos’è XAML
- 01.03.01 - WPF e XAML: da dove si parte davvero
- 01.03.02 - Che cos’è WPF
- 01.03.03 - Che cos’è XAML
- 01.03.04 - Il rapporto tra XAML e C#
- 01.03.05 - Un esempio minimo
- 01.03.06 - Leggere XAML senza paura
- 01.03.07 - Perché non si fa tutto direttamente in C#?
- 01.03.08 - Un primo confronto mentale: WPF non è WinForms
- 01.03.09 - Errori tipici all’inizio
- 01.03.10 - Primo esempio un po’ più realistico
- 01.03.11 - Cosa dobbiamo aver capito fin qui
- 01.03.12 - Come proseguire bene

### 01.04.00 - La sintassi di XAML spiegata bene
- 01.04.01 - Il ruolo del tag radice
- 01.04.02 - Gli attributi più comuni all’inizio
- 01.04.03 - Elementi annidati: la gerarchia della UI
- 01.04.04 - Tag aperto e chiuso, oppure elemento autochiuso
- 01.04.05 - Proprietà semplici e proprietà complesse
- 01.04.06 - Quando usare una forma o l’altra
- 01.04.07 - La content property: perché certi controlli sembrano magici
- 01.04.08 - `Name` e `x:Name`: quando servono davvero
- 01.04.09 - Eventi scritti direttamente in XAML
- 01.04.10 - Le markup extension: quelle espressioni tra parentesi graffe
- 01.04.11 - Proprietà scritte come testo ma convertite in oggetti
- 01.04.12 - Un esempio completo ma semplice da leggere
- 01.04.13 - Errori di sintassi molto comuni in XAML

### 01.05.00 - Namespace e Assembly
- 01.05.01 - I due namespace che vedi quasi sempre
- 01.05.02 - Che cos’è un namespace, in pratica
- 01.05.03 - Quando basta `clr-namespace`
- 01.05.04 - Quando serve anche `assembly=`
- 01.05.05 - Namespace CLR, namespace XAML e assembly: non sono la stessa cosa
- 01.05.06 - Il ruolo di `x:Class`
- 01.05.07 - Namespace e converter
- 01.05.08 - Namespace e `UserControl`
- 01.05.09 - Un accenno a `XmlnsDefinition`
- 01.05.10 - Errori tipici
- 01.05.11 - Regola pratica da ricordare
- 01.05.12 - Il punto da portare a casa

### 01.06.00 - A cosa serve `App.xaml`
- 01.06.01 - `Application.Resources`: risorse globali
- 01.06.02 - A cosa serve `App.xaml.cs`
- 01.06.03 - Differenza pratica tra `App` e `MainWindow`
- 01.06.04 - `StartupUri`: il caso più semplice
- 01.06.05 - Quando togliere `StartupUri` e usare codice
- 01.06.06 - Gli eventi importanti del livello applicazione
- 01.06.07 - `ShutdownMode`: quando finisce davvero l’applicazione
- 01.06.08 - Un esempio completo e realistico
- 01.06.09 - Il rapporto tra XAML, `App` e `MainWindow`

### 01.07.00 - XAML e code-behind
- 01.07.01 - `x:Class`: il primo ponte tra markup e codice
- 01.07.02 - `InitializeComponent()`: il punto in cui la finestra prende forma
- 01.07.03 - `x:Name`: come il codice C# vede i controlli
- 01.07.04 - Gli eventi dichiarati in XAML
- 01.07.05 - Un esempio completo di collaborazione tra XAML e C#
- 01.07.06 - Quando è lecito usare il code-behind
- 01.07.07 - Quando il code-behind inizia a diventare un problema
- 01.07.08 - Un buon criterio pratico
- 01.07.09 - Il ciclo di vita della finestra: quando il codice viene eseguito

## PARTE 02 - Layout, controlli e interfaccia

### 02.01.00 - Il layout in WPF
- 02.01.01 - Il layout in WPF: come organizzare davvero bene una finestra
- 02.01.02 - Il layout non è un dettaglio: è parte del modello WPF
- 02.01.03 - I pannelli principali da conoscere
- 02.01.04 - `Grid`
- 02.01.05 - `StackPanel`
- 02.01.06 - `DockPanel`
- 02.01.07 - `WrapPanel`
- 02.01.08 - `Canvas`
- 02.01.09 - `Margin`, `Padding` e `Alignment`
- 02.01.10 - Errori tipici di layout

### 02.02.00 - I controlli WPF più usati
- 02.02.01 - `TextBlock` e `Label`
- 02.02.02 - `TextBox`
- 02.02.03 - `Button`
- 02.02.04 - `CheckBox` e `RadioButton`
- 02.02.05 - `ComboBox`
- 02.02.06 - `ListBox`
- 02.02.07 - `ListView`
- 02.02.08 - `DataGrid`
- 02.02.09 - `ContentControl` e `ItemsControl`
- 02.02.10 - Errori tipici nella scelta dei controlli

### 02.03.00 - ComboBox avanzate
- 02.03.01 - La `ComboBox` base
- 02.03.02 - `ItemsSource`, `SelectedItem` e `DisplayMemberPath`
- 02.03.03 - Quando `DisplayMemberPath` basta
- 02.03.04 - Quando serve un `ItemTemplate`
- 02.03.05 - Il problema classico: quando chiusa mostra il nome della classe
- 02.03.06 - `IsEditable`: una `ComboBox` più simile a una casella con ricerca
- 02.03.07 - `IsTextSearchEnabled` e ricerca rapida
- 02.03.08 - `SelectedValuePath` e `SelectedValue`
- 02.03.09 - `ComboBox` con immagine, testo e ricerca
- 02.03.10 - `ComboBox` con filtro vero e proprio
- 02.03.11 - Personalizzazione visuale della `ComboBox`
- 02.03.12 - Errori tipici
- 02.03.13 - Regola pratica da ricordare
- 02.03.14 - Il punto da portare a casa

### 02.04.00 - Menu e ToolBar
- 02.04.01 - Il `Menu` classico
- 02.04.02 - Il significato dell’underscore
- 02.04.03 - La `ToolBar`
- 02.04.04 - `ToolBarTray`
- 02.04.05 - Il vero punto: non attaccare tutto a `Click`
- 02.04.06 - Collegare `MenuItem` e `Button` allo stesso comando
- 02.04.07 - `CanExecute`: abilitare e disabilitare bene i comandi
- 02.04.08 - `CommandTarget`
- 02.04.09 - Toolbar con icone, testo e tooltip
- 02.04.10 - Menu contestuali
- 02.04.11 - Menu, toolbar e MVVM
- 02.04.12 - Quando usare menu e toolbar
- 02.04.13 - Errori tipici
- 02.04.14 - Regola pratica da ricordare
- 02.04.15 - Il punto da portare a casa

### 02.05.00 - Controlli avanzati
- 02.05.01 - `DatePicker`
- 02.05.02 - `Calendar`
- 02.05.03 - `ProgressBar`
- 02.05.04 - `Slider`
- 02.05.05 - `ScrollViewer`
- 02.05.06 - Altri controlli utili
- 02.05.07 - Criteri pratici di scelta

### 02.06.00 - Personalizzazione
- 02.06.01 - Spaziature, dimensioni, allineamenti
- 02.06.02 - Colori, bordi e font
- 02.06.03 - Personalizzazione dei controlli più usati
- 02.06.04 - Focus, hover e stati visivi
- 02.06.05 - Quando basta uno stile e quando serve un template
- 02.06.06 - Risorse condivise e coerenza visiva

### 02.07.00 - Disegnare in WPF
- 02.07.01 - `Shape` e geometrie
- 02.07.02 - `Path`
- 02.07.03 - `Drawing`
- 02.07.04 - `Viewbox`
- 02.07.05 - Brush grafici
- 02.07.06 - Quando usare davvero il disegno vettoriale

### 02.08.00 - Animazioni
- 02.08.01 - Il sistema di animazione
- 02.08.02 - `Storyboard`
- 02.08.03 - `TargetName` e `TargetProperty`
- 02.08.04 - `RenderTransform`
- 02.08.05 - `DoubleAnimation`
- 02.08.06 - `From`, `To`, `By`
- 02.08.07 - Errori tipici nelle animazioni

### 02.09.00 - VisualStateManager
- 02.09.01 - Perché non bastano sempre i trigger
- 02.09.02 - `VisualState`
- 02.09.03 - `VisualStateGroup`
- 02.09.04 - `VisualStateManager.VisualStateGroups`
- 02.09.05 - Primo esempio: un `Button` con stati visivi
- 02.09.06 - `VisualTransition`
- 02.09.07 - Quando conviene usarlo davvero

## PARTE 03 - Dati, binding e presentazione

### 03.01.00 - Data binding in WPF
- 03.01.01 - Il passaggio che cambia davvero il modo di lavorare
- 03.01.02 - L’idea base: target, source e path
- 03.01.03 - Il primo esempio minimo: binding a un oggetto
- 03.01.04 - `DataContext`: il concetto da capire davvero bene
- 03.01.05 - Binding `OneWay` e `TwoWay`
- 03.01.06 - Primo esempio utile: form con `TwoWay` binding
- 03.01.07 - Perché a volte il binding funziona solo a metà
- 03.01.08 - `INotifyPropertyChanged`: la chiave per aggiornare la UI
- 03.01.09 - Esempio completo con aggiornamento reale della UI
- 03.01.10 - `UpdateSourceTrigger`
- 03.01.11 - La sintassi del binding in XAML
- 03.01.12 - Errori classici nel data binding

### 03.02.00 - DataContext
- 03.02.01 - Un solo oggetto nel `DataContext`
- 03.02.02 - Più oggetti diversi nella stessa finestra
- 03.02.03 - Sezioni con `DataContext` diversi
- 03.02.04 - Sorgente esplicita con `Source`, `ElementName` o `RelativeSource`
- 03.02.05 - Come nominarli correttamente in pratica
- 03.02.06 - Regola pratica da libro
- 03.02.07 - Errore tipico da evitare

### 03.03.00 - `INotifyPropertyChanged` e `ObservableCollection<T>`
- 03.03.01 - Perché una proprietà e un elenco non si aggiornano allo stesso modo
- 03.03.02 - `INotifyPropertyChanged`: a cosa serve davvero
- 03.03.03 - Esempio completo con proprietà singole
- 03.03.04 - Errore classico: proprietà automatiche senza notifica
- 03.03.05 - `ObservableCollection<T>`: quando usarla
- 03.03.06 - Attenzione: `ObservableCollection<T>` non sostituisce `INotifyPropertyChanged`
- 03.03.07 - Esempio con `ListBox`
- 03.03.08 - Esempio con `DataGrid`
- 03.03.09 - Caso d’uso lavorativo concreto
- 03.03.10 - Errori classici e come risolverli
- 03.03.11 - Regola pratica da fissare bene

### 03.04.00 - Converter
- 03.04.01 - Quando usare un converter
- 03.04.02 - `IValueConverter`
- 03.04.03 - Esempio: `bool` → `Visibility`
- 03.04.04 - Converter di formattazione
- 03.04.05 - `ConvertBack`
- 03.04.06 - `ConverterParameter`
- 03.04.07 - Converter e cultura (`CultureInfo`)
- 03.04.08 - Errori classici con i converter

### 03.05.00 - Ordinare, filtrare e raggruppare
- 03.05.01 - Perché una view è meglio che modificare la collezione originale
- 03.05.02 - `CollectionView`
- 03.05.03 - La default view di una collezione
- 03.05.04 - Primo esempio: ordinare da codice con la default view
- 03.05.05 - `CollectionViewSource`
- 03.05.06 - Filtering
- 03.05.07 - Sorting
- 03.05.08 - Grouping
- 03.05.09 - `GroupStyle`

### 03.06.00 - Risorse, stili e template
- 03.06.01 - Perché esistono le risorse
- 03.06.02 - Una risorsa semplice
- 03.06.03 - `x:Key`
- 03.06.04 - Dove si possono dichiarare
- 03.06.05 - `StaticResource`
- 03.06.06 - `DynamicResource`
- 03.06.07 - Regola pratica
- 03.06.08 - Risorse non solo di colore
- 03.06.09 - Lo stile: applicare un insieme di proprietà senza ripeterle
- 03.06.10 - Stili con chiave e stili impliciti
- 03.06.11 - I trigger
- 03.06.12 - La differenza tra stile e template
- 03.06.13 - `ControlTemplate`
- 03.06.14 - `DataTemplate`
- 03.06.15 - `ResourceDictionary`
- 03.06.16 - `MergedDictionaries`
- 03.06.17 - Un esempio pratico di organizzazione delle risorse
- 03.06.18 - Risorse e converter
- 03.06.19 - Risorse e template
- 03.06.20 - Risorse e manutenzione
- 03.06.21 - Errori tipici
- 03.06.22 - Il punto da portare a casa

### 03.07.00 - Dependency Properties
- 03.07.01 - Perché le proprietà normali non bastano
- 03.07.02 - Definizione semplice
- 03.07.03 - Esempi di dependency property che usi già
- 03.07.04 - Che vantaggi danno davvero
- 03.07.05 - Binding
- 03.07.06 - Stili
- 03.07.07 - Animazioni
- 03.07.08 - Ereditarietà dei valori
- 03.07.09 - Come si dichiara una dependency property personalizzata
- 03.07.10 - Leggere bene lo schema `Register`
- 03.07.11 - Wrapper CLR
- 03.07.12 - Dove si usa davvero una dependency property personalizzata
- 03.07.13 - Metadata, callback e comportamento avanzato
- 03.07.14 - Dependency property e `UserControl`
- 03.07.15 - Quando non usarle
- 03.07.16 - Confronto rapido con `INotifyPropertyChanged`
- 03.07.17 - Il punto da portare a casa

## PARTE 04 - Comportamento applicativo e struttura moderna

### 04.01.00 - Commanding e MVVM
- 04.01.01 - Perché gli eventi `Click` non bastano sempre
- 04.01.02 - Che cos’è un comando in WPF
- 04.01.03 - Il commanding classico di WPF: `RoutedCommand`
- 04.01.04 - `Command`, `CommandParameter` e `CommandTarget`
- 04.01.05 - Le scorciatoie da tastiera: `KeyBinding`
- 04.01.06 - `ICommand` e command personalizzati
- 04.01.07 - `RelayCommand`
- 04.01.08 - Perché MVVM si sposa così bene con WPF
- 04.01.09 - Un primo esempio MVVM semplice ma concreto
- 04.01.10 - Perché `CanExecute` è così utile
- 04.01.11 - Eventi o comandi? Non bisogna essere dogmatici
- 04.01.12 - Un caso lavorativo concreto

### 04.02.00 - Navigazione interna con `UserControl`
- 04.02.01 - `Window`, `Page`, `UserControl`
- 04.02.02 - L’idea base: una finestra shell con un’area contenuto
- 04.02.03 - Perché `DataTemplate` è la chiave di questo approccio
- 04.02.04 - Il ViewModel della shell
- 04.02.05 - `UserControl` come vista, non come contenitore di logica
- 04.02.06 - Come viene assegnato il `DataContext`
- 04.02.07 - Come caricare il `UserControl` in un’area della pagina
- 04.02.08 - Come comunicare con il `UserControl`
- 04.02.09 - Come ricevere feedback dal `UserControl`
- 04.02.10 - Un esempio completo e realistico

### 04.03.00 - CRUD SQLite integrato col Binding
- 04.03.01 - L’idea generale
- 04.03.02 - Il modello
- 04.03.03 - La collezione bindata
- 04.03.04 - Il database SQLite
- 04.03.05 - Creazione della tabella
- 04.03.06 - Il repository
- 04.03.07 - Caricare i dati nella raccolta bindata
- 04.03.08 - Inserimento
- 04.03.09 - Aggiornamento
- 04.03.10 - Eliminazione
- 04.03.11 - Interfaccia con `DataGrid`
- 04.03.12 - CRUD e Binding: il modello mentale corretto
- 04.03.13 - Variante con Entity Framework Core
- 04.03.14 - Errori tipici
- 04.03.15 - Regola pratica da ricordare
- 04.03.16 - Il punto da portare a casa

### 04.04.00 - Drag and Drop
- 04.04.01 - Il modello mentale
- 04.04.02 - Avviare un drag
- 04.04.03 - Preparare il target
- 04.04.04 - `AllowDrop`
- 04.04.05 - Effetti di trascinamento
- 04.04.06 - Ricevere file trascinati da Esplora Risorse
- 04.04.07 - Eventi intermedi
- 04.04.08 - Un esempio pratico: trascinare da una `ListBox` a un’altra
- 04.04.09 - Drag and drop e `ObservableCollection<T>`
- 04.04.10 - Drag and drop con oggetti personalizzati
- 04.04.11 - Drag and drop e `UserControl`
- 04.04.12 - Feedback visivo
- 04.04.13 - Errori tipici
- 04.04.14 - Regola pratica da ricordare
- 04.04.15 - Il punto da portare a casa

### 04.05.00 - Multithreading e reattività della UI
- 04.05.01 - Il `Dispatcher`: il cuore del thread UI
- 04.05.02 - `async` e `await`
- 04.05.03 - I/O-bound e CPU-bound
- 04.05.04 - `Dispatcher.Invoke`, `BeginInvoke` e `InvokeAsync`
- 04.05.05 - Un errore molto pericoloso: `Task.Wait()` o `.Result`
- 04.05.06 - Progress bar e UI reattiva
- 04.05.07 - Progress reporting con percentuale reale
- 04.05.08 - E le collezioni bindate?

## PARTE 05 - Professionalità, localizzazione e distribuzione

### 05.01.00 - Errori classici in WPF
- 05.01.01 - Il binding non mostra nulla
- 05.01.02 - La UI non si aggiorna
- 05.01.03 - Le liste non si aggiornano
- 05.01.04 - `DataContext` errato
- 05.01.05 - Template e stili usati male
- 05.01.06 - Errori ricorrenti reali

### 05.02.00 - Localizzazione e globalizzazione
- 05.02.01 - Globalizzazione e localizzazione: la differenza giusta
- 05.02.02 - Il primo errore da evitare: stringhe hardcoded ovunque
- 05.02.03 - Il ruolo di `x:Uid`
- 05.02.04 - Attributi e commenti di localizzazione
- 05.02.05 - Il layout automatico
- 05.02.06 - Testi più lunghi
- 05.02.07 - Direzione del testo e bidirezionalità
- 05.02.08 - Formati data, numero e valuta
- 05.02.09 - Satellite assemblies e risorse localizzate
- 05.02.10 - Risorse XAML localizzabili e `MergedDictionaries`

### 05.03.00 - Splash Screen personalizzati
- 05.03.01 - Il modo più semplice: splash screen nativo
- 05.03.02 - Perché è comodo
- 05.03.03 - I limiti dello splash standard
- 05.03.04 - Splash personalizzato come finestra WPF
- 05.03.05 - Come mostrarla all’avvio
- 05.03.06 - Quando conviene uno splash personalizzato
- 05.03.07 - Una strategia pratica molto sensata
- 05.03.08 - Splash screen, loading screen e schermata iniziale: non sono la stessa cosa
- 05.03.09 - Curare il design dello splash
- 05.03.10 - Errori tipici
- 05.03.11 - Regola pratica da ricordare
- 05.03.12 - Il punto da portare a casa

### 05.04.00 - Deployment e distribuzione
- 05.04.01 - Il quadro generale: quali strade esistono davvero
- 05.04.02 - Publish to folder
- 05.04.03 - ClickOnce
- 05.04.04 - MSIX
- 05.04.05 - Framework-dependent o self-contained
- 05.04.06 - Publish to folder: la soluzione più semplice
- 05.04.07 - ClickOnce: installazione semplice e aggiornamenti integrati
- 05.04.08 - Le proprietà importanti di ClickOnce
- 05.04.09 - Quando scegliere quale strada

### 05.05.00 - Chiudere il cerchio
- 05.05.01 - Il modello mentale corretto di WPF
- 05.05.02 - Il ruolo di XAML
- 05.05.03 - Layout, dati e presentazione
- 05.05.04 - Il ruolo del code-behind
- 05.05.05 - Come proseguire dopo il libro

## PARTE 06 - Caso d’uso finale

### 06.01.00 - Cassa di un ristorante
- 06.01.01 - Perché questo caso d’uso è didatticamente utile
- 06.01.02 - Le varianti possibili
- 06.01.03 - I concetti WPF che mette insieme

### 06.02.00 - Caso d’uso
- 06.02.01 - Obiettivo della schermata
- 06.02.02 - Requisiti pratici
- 06.02.03 - Flusso operativo

### 06.03.00 - Progettazione del caso d’uso
- 06.03.01 - Regole funzionali
- 06.03.02 - Modelli: `Tavolo`, `Piatto`, `RigaConto`
- 06.03.03 - `CassaRistoranteViewModel`
- 06.03.04 - Comandi e collezioni
- 06.03.05 - Scelte di layout

### 06.04.00 - Implementazione
- 06.04.01 - Modelli
- 06.04.02 - `RelayCommand`
- 06.04.03 - ViewModel
- 06.04.04 - Collezioni osservabili
- 06.04.05 - Proprietà e comandi

### 06.05.00 - Costruire l’interfaccia
- 06.05.01 - `MainWindow.xaml`
- 06.05.02 - Struttura della `Grid`
- 06.05.03 - Parte sinistra
- 06.05.04 - Parte destra con `DataGrid`
- 06.05.05 - Rifiniture visive

### 06.06.00 - La schermata completa
- 06.06.01 - Lettura guidata della UI completa
- 06.06.02 - Input
- 06.06.03 - `DataGrid`
- 06.06.04 - Scelte progettuali
- 06.06.05 - Cosa migliorare in una versione successiva

---


# WPF in pratica
## Costruire applicazioni desktop vere con XAML, binding, MVVM e un progetto finale completo

Questo repository raccoglie un libro pratico su WPF pensato per accompagnare il lettore dentro il framework con una progressione più naturale e più forte dal punto di vista didattico. L’obiettivo non è mostrare soltanto controlli o frammenti di codice, ma costruire poco per volta un modo corretto di leggere e progettare una UI desktop: prima si capisce che cos’è WPF e che ruolo ha XAML, poi si entra nel layout, nei binding, nei template, nei comandi e nella struttura moderna delle schermate, fino ad arrivare a un progetto finale che cresce davvero e si lascia leggere come una piccola applicazione desktop credibile.

Il percorso è rivolto soprattutto a sviluppatori C# che vogliono imparare WPF in modo chiaro e progressivo. È utile conoscere Visual Studio e il linguaggio C#, ma non è necessario sapere già che cosa siano `DataContext`, dependency property o MVVM. Il libro lavora proprio per costruire questi concetti in ordine, evitando di presentare troppo presto i meccanismi interni del framework senza che il lettore abbia ancora una base sufficiente per capirli.

Il punto di arrivo del libro è una cassa di ristorante sviluppata come caso d’uso finale. Non è lì per fare scena: serve a mostrare come modelli, `ViewModel`, comandi, `DataGrid`, layout, stato e rifinitura della UI possano collaborare davvero in un progetto WPF piccolo ma convincente. In questa versione consolidata del repository sono stati aggiunti anche un capitolo sulla testabilità del `ViewModel`, uno sull’accessibilità e una sezione di costruzione guidata del progetto finale, così che il percorso resti coerente con la promessa di arrivare a un’applicazione desktop vera.

## Accesso rapido al libro

- [00 - Scaletta_definitiva_libro_WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/00%20-%20Scaletta_definitiva_libro_WPF.md)
- [00.00.00 - Prefazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/00.00.00%20-%20Prefazione.md)
- [README](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/README.md)

## Parte 01 — Fondamenta: capire WPF prima di usarlo

### 01.01.00

- [01.01.01 - WPF e XAML_ da dove si parte davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.01%20-%20WPF%20e%20XAML_%20da%20dove%20si%20parte%20davvero.md)
- [01.01.02 - Che cos’è WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.02%20-%20Che%20cos%E2%80%99%C3%A8%20WPF.md)
- [01.01.03 - Che cos’è XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.03%20-%20Che%20cos%E2%80%99%C3%A8%20XAML.md)
- [01.01.04 - Il rapporto tra XAML e C#](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.04%20-%20Il%20rapporto%20tra%20XAML%20e%20C%23.md)
- [01.01.05 - Un esempio minimo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.05%20-%20Un%20esempio%20minimo.md)
- [01.01.06 - Leggere XAML senza paura](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.06%20-%20Leggere%20XAML%20senza%20paura.md)
- [01.01.07 - Perché non si fa tutto direttamente in C#_](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.07%20-%20Perch%C3%A9%20non%20si%20fa%20tutto%20direttamente%20in%20C%23_.md)
- [01.01.08 - Un primo confronto mentale_ WPF non è WinForms](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.08%20-%20Un%20primo%20confronto%20mentale_%20WPF%20non%20%C3%A8%20WinForms.md)
- [01.01.09 - Errori tipici all’inizio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.09%20-%20Errori%20tipici%20all%E2%80%99inizio.md)
- [01.01.10 - Primo esempio un po’ più realistico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.10%20-%20Primo%20esempio%20un%20po%E2%80%99%20pi%C3%B9%20realistico.md)
- [01.01.11 - Cosa dobbiamo aver capito fin qui](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.11%20-%20Cosa%20dobbiamo%20aver%20capito%20fin%20qui.md)
- [01.01.12 - Come proseguire bene](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.12%20-%20Come%20proseguire%20bene.md)

### 01.02.00

- [01.02.01 - WPF è Windows-only](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.01%20-%20WPF%20%C3%A8%20Windows-only.md)
- [01.02.02 - L’IDE di riferimento - Visual Studio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.02%20-%20L%E2%80%99IDE%20di%20riferimento%20-%20Visual%20Studio.md)
- [01.02.03 - Il workload da installare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.03%20-%20Il%20workload%20da%20installare.md)
- [01.02.04 - Creare un nuovo progetto WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.04%20-%20Creare%20un%20nuovo%20progetto%20WPF.md)
- [01.02.05 - .NET moderno o .NET Framework](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.05%20-%20.NET%20moderno%20o%20.NET%20Framework.md)
- [01.02.06 - Cosa crea Visual Studio all’inizio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.06%20-%20Cosa%20crea%20Visual%20Studio%20all%E2%80%99inizio.md)
- [01.02.07 - Che ruolo hanno questi file](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.07%20-%20Che%20ruolo%20hanno%20questi%20file.md)
- [01.02.08 - L’editor XAML e il designer](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.08%20-%20L%E2%80%99editor%20XAML%20e%20il%20designer.md)
- [01.02.09 - Build, esecuzione e debug](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.09%20-%20Build%2C%20esecuzione%20e%20debug.md)
- [01.02.10 - NuGet e librerie esterne](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.10%20-%20NuGet%20e%20librerie%20esterne.md)
- [01.02.11 - Publish e distribuzione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.11%20-%20Publish%20e%20distribuzione.md)
- [01.02.12 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.12%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 01.03.00

- [01.03.01 - Il ruolo del tag radice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.01%20-%20Il%20ruolo%20del%20tag%20radice.md)
- [01.03.02 - Gli attributi più comuni all’inizio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.02%20-%20Gli%20attributi%20pi%C3%B9%20comuni%20all%E2%80%99inizio.md)
- [01.03.03 - Elementi annidati - la gerarchia della UI](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.03%20-%20Elementi%20annidati%20-%20la%20gerarchia%20della%20UI.md)
- [01.03.04 - Tag aperto e chiuso, oppure elemento autochiuso](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.04%20-%20Tag%20aperto%20e%20chiuso%2C%20oppure%20elemento%20autochiuso.md)
- [01.03.05 - Proprietà semplici e proprietà complesse](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.05%20-%20Propriet%C3%A0%20semplici%20e%20propriet%C3%A0%20complesse.md)
- [01.03.06 - Quando usare una forma o l’altra](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.06%20-%20Quando%20usare%20una%20forma%20o%20l%E2%80%99altra.md)
- [01.03.07 - La content property - perché certi controlli sembrano magici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.07%20-%20La%20content%20property%20-%20perch%C3%A9%20certi%20controlli%20sembrano%20magici.md)
- [01.03.08 - Name e x-Name - quando servono davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.08%20-%20Name%20e%20x-Name%20-%20quando%20servono%20davvero.md)
- [01.03.09 - Eventi scritti direttamente in XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.09%20-%20Eventi%20scritti%20direttamente%20in%20XAML.md)
- [01.03.10 - Le markup extension - quelle espressioni tra parentesi graffe](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.10%20-%20Le%20markup%20extension%20-%20quelle%20espressioni%20tra%20parentesi%20graffe.md)
- [01.03.11 - Proprietà scritte come testo ma convertite in oggetti](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.11%20-%20Propriet%C3%A0%20scritte%20come%20testo%20ma%20convertite%20in%20oggetti.md)
- [01.03.12 - Un esempio completo ma semplice da leggere](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.12%20-%20Un%20esempio%20completo%20ma%20semplice%20da%20leggere.md)
- [01.03.13 - Errori di sintassi molto comuni in XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.13%20-%20Errori%20di%20sintassi%20molto%20comuni%20in%20XAML.md)

### 01.04.00

- [01.04.01 - L’idea base una UI fatta di oggetti](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.01%20-%20L%E2%80%99idea%20base%20una%20UI%20fatta%20di%20oggetti.md)
- [01.04.02 - Albero logico e albero visuale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.02%20-%20Albero%20logico%20e%20albero%20visuale.md)
- [01.04.03 - La gerarchia delle classi da Object a Control](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.03%20-%20La%20gerarchia%20delle%20classi%20da%20Object%20a%20Control.md)
- [01.04.04 - Il property system uno dei cuori di WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.04%20-%20Il%20property%20system%20uno%20dei%20cuori%20di%20WPF.md)
- [01.04.05 - Layout misura e disposizione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.05%20-%20Layout%20misura%20e%20disposizione.md)
- [01.04.06 - Rendering non solo controlli ma anche grafica testo e media](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.06%20-%20Rendering%20non%20solo%20controlli%20ma%20anche%20grafica%20testo%20e%20media.md)
- [01.04.07 - Eventi instradati](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.07%20-%20Eventi%20instradati.md)
- [01.04.08 - Dati template e separazione delle responsabilita](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.08%20-%20Dati%20template%20e%20separazione%20delle%20responsabilita.md)
- [01.04.09 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.09%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 01.05.00

- [01.05.01 - I due namespace che vedi quasi sempre](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.01%20-%20I%20due%20namespace%20che%20vedi%20quasi%20sempre.md)
- [01.05.02 - Che cos’è un namespace, in pratica](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.02%20-%20Che%20cos%E2%80%99%C3%A8%20un%20namespace%2C%20in%20pratica.md)
- [01.05.03 - Quando basta clr-namespace](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.03%20-%20Quando%20basta%20clr-namespace.md)
- [01.05.04 - Quando serve anche assembly=](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.04%20-%20Quando%20serve%20anche%20assembly%3D.md)
- [01.05.05 - Namespace CLR, namespace XAML e assembly - non sono la stessa cosa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.05%20-%20Namespace%20CLR%2C%20namespace%20XAML%20e%20assembly%20-%20non%20sono%20la%20stessa%20cosa.md)
- [01.05.06 - Il ruolo di x-Class](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.06%20-%20Il%20ruolo%20di%20x-Class.md)
- [01.05.07 - Namespace e converter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.07%20-%20Namespace%20e%20converter.md)
- [01.05.08 - Namespace e UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.08%20-%20Namespace%20e%20UserControl.md)
- [01.05.09 - Un accenno a XmlnsDefinition](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.09%20-%20Un%20accenno%20a%20XmlnsDefinition.md)
- [01.05.10 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.10%20-%20Errori%20tipici.md)
- [01.05.11 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.11%20-%20Regola%20pratica%20da%20ricordare.md)
- [01.05.12 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.12%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 01.06.00

- [01.06.01 - Application.Resources - risorse globali](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.01%20-%20Application.Resources%20-%20risorse%20globali.md)
- [01.06.02 - A cosa serve App.xaml.cs](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.02%20-%20A%20cosa%20serve%20App.xaml.cs.md)
- [01.06.03 - Differenza pratica tra App e MainWindow](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.03%20-%20Differenza%20pratica%20tra%20App%20e%20MainWindow.md)
- [01.06.04 - StartupUri - il caso più semplice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.04%20-%20StartupUri%20-%20il%20caso%20pi%C3%B9%20semplice.md)
- [01.06.05 - Quando togliere StartupUri e usare codice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.05%20-%20Quando%20togliere%20StartupUri%20e%20usare%20codice.md)
- [01.06.06 - Gli eventi importanti del livello applicazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.06%20-%20Gli%20eventi%20importanti%20del%20livello%20applicazione.md)
- [01.06.07 - ShutdownMode - quando finisce davvero l applicazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.07%20-%20ShutdownMode%20-%20quando%20finisce%20davvero%20l%20applicazione.md)
- [01.06.08 - Un esempio completo e realistico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.08%20-%20Un%20esempio%20completo%20e%20realistico.md)
- [01.06.09 - Il rapporto tra XAML, App e MainWindow](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.09%20-%20Il%20rapporto%20tra%20XAML%2C%20App%20e%20MainWindow.md)

### 01.07.00

- [01.07.01 - x Class - il primo ponte tra markup e codice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.01%20-%20x%20Class%20-%20il%20primo%20ponte%20tra%20markup%20e%20codice.md)
- [01.07.02 - InitializeComponent - il punto in cui la finestra prende forma](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.02%20-%20InitializeComponent%20-%20il%20punto%20in%20cui%20la%20finestra%20prende%20forma.md)
- [01.07.03 - x Name - come il codice C Sharp vede i controlli](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.03%20-%20x%20Name%20-%20come%20il%20codice%20C%20Sharp%20vede%20i%20controlli.md)
- [01.07.04 - Gli eventi dichiarati in XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.04%20-%20Gli%20eventi%20dichiarati%20in%20XAML.md)
- [01.07.05 - Un esempio completo di collaborazione tra XAML e C Sharp](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.05%20-%20Un%20esempio%20completo%20di%20collaborazione%20tra%20XAML%20e%20C%20Sharp.md)
- [01.07.06 - Quando è lecito usare il code-behind](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.06%20-%20Quando%20%C3%A8%20lecito%20usare%20il%20code-behind.md)
- [01.07.07 - Quando il code-behind inizia a diventare un problema](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.07%20-%20Quando%20il%20code-behind%20inizia%20a%20diventare%20un%20problema.md)
- [01.07.08 - Un buon criterio pratico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.08%20-%20Un%20buon%20criterio%20pratico.md)
- [01.07.09 - Il ciclo di vita della finestra - quando il codice viene eseguito](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.09%20-%20Il%20ciclo%20di%20vita%20della%20finestra%20-%20quando%20il%20codice%20viene%20eseguito.md)

## Parte 02 — Layout, controlli e interfaccia

### 02.01.00

- [02.01.01 - Il layout in WPF_ come organizzare davvero bene una finestra](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.01%20-%20Il%20layout%20in%20WPF_%20come%20organizzare%20davvero%20bene%20una%20finestra.md)
- [02.01.02 - Il layout non è un dettaglio_ è parte del modello WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.02%20-%20Il%20layout%20non%20%C3%A8%20un%20dettaglio_%20%C3%A8%20parte%20del%20modello%20WPF.md)
- [02.01.03 - I pannelli principali da conoscere](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.03%20-%20I%20pannelli%20principali%20da%20conoscere.md)
- [02.01.04 - Grid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.04%20-%20Grid.md)
- [02.01.05 - StackPanel](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.05%20-%20StackPanel.md)
- [02.01.06 - DockPanel](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.06%20-%20DockPanel.md)
- [02.01.07 - WrapPanel](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.07%20-%20WrapPanel.md)
- [02.01.08 - Canvas](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.08%20-%20Canvas.md)
- [02.01.09 - Margin, Padding e Alignment](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.09%20-%20Margin%2C%20Padding%20e%20Alignment.md)
- [02.01.10 - Errori tipici di layout](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.10%20-%20Errori%20tipici%20di%20layout.md)

### 02.02.00

- [02.02.01 - TextBlock e Label](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.01%20-%20TextBlock%20e%20Label.md)
- [02.02.02 - TextBox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.02%20-%20TextBox.md)
- [02.02.03 - Button](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.03%20-%20Button.md)
- [02.02.04 - CheckBox e RadioButton](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.04%20-%20CheckBox%20e%20RadioButton.md)
- [02.02.05 - ComboBox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.05%20-%20ComboBox.md)
- [02.02.06 - ListBox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.06%20-%20ListBox.md)
- [02.02.07 - ListView](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.07%20-%20ListView.md)
- [02.02.08 - DataGrid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.08%20-%20DataGrid.md)
- [02.02.09 - ContentControl e ItemsControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.09%20-%20ContentControl%20e%20ItemsControl.md)
- [02.02.10 - Errori tipici nella scelta dei controlli](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.10%20-%20Errori%20tipici%20nella%20scelta%20dei%20controlli.md)

### 02.03.00

- [02.03.01 - La ComboBox base](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.01%20-%20La%20ComboBox%20base.md)
- [02.03.02 - ItemsSource, SelectedItem e DisplayMemberPath](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.02%20-%20ItemsSource%2C%20SelectedItem%20e%20DisplayMemberPath.md)
- [02.03.03 - Quando DisplayMemberPath basta](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.03%20-%20Quando%20DisplayMemberPath%20basta.md)
- [02.03.04 - Quando serve un ItemTemplate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.04%20-%20Quando%20serve%20un%20ItemTemplate.md)
- [02.03.05 - Il problema classico, quando chiusa mostra il nome della classe](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.05%20-%20Il%20problema%20classico%2C%20quando%20chiusa%20mostra%20il%20nome%20della%20classe.md)
- [02.03.06 - IsEditable, una ComboBox più simile a una casella con ricerca](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.06%20-%20IsEditable%2C%20una%20ComboBox%20pi%C3%B9%20simile%20a%20una%20casella%20con%20ricerca.md)
- [02.03.07 - IsTextSearchEnabled e ricerca rapida](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.07%20-%20IsTextSearchEnabled%20e%20ricerca%20rapida.md)
- [02.03.08 - SelectedValuePath e SelectedValue](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.08%20-%20SelectedValuePath%20e%20SelectedValue.md)
- [02.03.09 - ComboBox con immagine, testo e ricerca](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.09%20-%20ComboBox%20con%20immagine%2C%20testo%20e%20ricerca.md)
- [02.03.10 - ComboBox con filtro vero e proprio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.10%20-%20ComboBox%20con%20filtro%20vero%20e%20proprio.md)
- [02.03.11 - Personalizzazione visuale della ComboBox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.11%20-%20Personalizzazione%20visuale%20della%20ComboBox.md)
- [02.03.12 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.12%20-%20Errori%20tipici.md)
- [02.03.13 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.13%20-%20Regola%20pratica%20da%20ricordare.md)
- [02.03.14 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.14%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 02.04.00

- [02.04.01 - Il Menu classico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.01%20-%20Il%20Menu%20classico.md)
- [02.04.02 - Il significato dell’underscore](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.02%20-%20Il%20significato%20dell%E2%80%99underscore.md)
- [02.04.03 - La ToolBar](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.03%20-%20La%20ToolBar.md)
- [02.04.04 - ToolBarTray](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.04%20-%20ToolBarTray.md)
- [02.04.05 - Il vero punto non attaccare tutto a Click](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.05%20-%20Il%20vero%20punto%20non%20attaccare%20tutto%20a%20Click.md)
- [02.04.06 - Collegare MenuItem e Button allo stesso comando](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.06%20-%20Collegare%20MenuItem%20e%20Button%20allo%20stesso%20comando.md)
- [02.04.07 - CanExecute abilitare e disabilitare bene i comandi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.07%20-%20CanExecute%20abilitare%20e%20disabilitare%20bene%20i%20comandi.md)
- [02.04.08 - CommandTarget](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.08%20-%20CommandTarget.md)
- [02.04.09 - Toolbar con icone testo e tooltip](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.09%20-%20Toolbar%20con%20icone%20testo%20e%20tooltip.md)
- [02.04.10 - Menu contestuali](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.10%20-%20Menu%20contestuali.md)
- [02.04.11 - Menu toolbar e MVVM](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.11%20-%20Menu%20toolbar%20e%20MVVM.md)
- [02.04.12 - Quando usare menu e toolbar](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.12%20-%20Quando%20usare%20menu%20e%20toolbar.md)
- [02.04.13 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.13%20-%20Errori%20tipici.md)
- [02.04.14 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.14%20-%20Regola%20pratica%20da%20ricordare.md)
- [02.04.15 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.15%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 02.05.00

- [02.05.01 - DatePicker](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.01%20-%20DatePicker.md)
- [02.05.02 - Calendar](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.02%20-%20Calendar.md)
- [02.05.03 - ProgressBar](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.03%20-%20ProgressBar.md)
- [02.05.04 - Slider](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.04%20-%20Slider.md)
- [02.05.05 - ScrollViewer](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.05%20-%20ScrollViewer.md)
- [02.05.06 - Altri controlli utili](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.06%20-%20Altri%20controlli%20utili.md)
- [02.05.07 - Criteri pratici di scelta](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.07%20-%20Criteri%20pratici%20di%20scelta.md)

### 02.06.00

- [02.06.01 - Spaziature, dimensioni, allineamenti](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.01%20-%20Spaziature%2C%20dimensioni%2C%20allineamenti.md)
- [02.06.02 - Colori, bordi e font](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.02%20-%20Colori%2C%20bordi%20e%20font.md)
- [02.06.03 - Personalizzazione dei controlli più usati](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.03%20-%20Personalizzazione%20dei%20controlli%20pi%C3%B9%20usati.md)
- [02.06.04 - Focus, hover e stati visivi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.04%20-%20Focus%2C%20hover%20e%20stati%20visivi.md)
- [02.06.05 - Quando basta uno stile e quando serve un template](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.05%20-%20Quando%20basta%20uno%20stile%20e%20quando%20serve%20un%20template.md)
- [02.06.06 - Risorse condivise e coerenza visiva](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.06%20-%20Risorse%20condivise%20e%20coerenza%20visiva.md)

### 02.07.00

- [02.07.01 - Shape e geometrie](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.01%20-%20Shape%20e%20geometrie.md)
- [02.07.02 - Path](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.02%20-%20Path.md)
- [02.07.03 - Drawing](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.03%20-%20Drawing.md)
- [02.07.04 - Viewbox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.04%20-%20Viewbox.md)
- [02.07.05 - Brush grafici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.05%20-%20Brush%20grafici.md)
- [02.07.06 - Quando usare davvero il disegno vettoriale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.06%20-%20Quando%20usare%20davvero%20il%20disegno%20vettoriale.md)

### 02.08.00

- [02.08.01 - Il sistema di animazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.01%20-%20Il%20sistema%20di%20animazione.md)
- [02.08.02 - Storyboard](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.02%20-%20Storyboard.md)
- [02.08.03 - TargetName e TargetProperty](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.03%20-%20TargetName%20e%20TargetProperty.md)
- [02.08.04 - RenderTransform](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.04%20-%20RenderTransform.md)
- [02.08.05 - DoubleAnimation](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.05%20-%20DoubleAnimation.md)
- [02.08.06 - From, To, By](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.06%20-%20From%2C%20To%2C%20By.md)
- [02.08.07 - Errori tipici nelle animazioni](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.07%20-%20Errori%20tipici%20nelle%20animazioni.md)

### 02.09.00

- [02.09.01 - Perché non bastano sempre i trigger](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.01%20-%20Perch%C3%A9%20non%20bastano%20sempre%20i%20trigger.md)
- [02.09.02 - VisualState](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.02%20-%20VisualState.md)
- [02.09.03 - VisualStateGroup](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.03%20-%20VisualStateGroup.md)
- [02.09.04 - VisualStateManager.VisualStateGroups](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.04%20-%20VisualStateManager.VisualStateGroups.md)
- [02.09.05 - Primo esempio un Button con stati visivi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.05%20-%20Primo%20esempio%20un%20Button%20con%20stati%20visivi.md)
- [02.09.06 - VisualTransition](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.06%20-%20VisualTransition.md)
- [02.09.07 - Quando conviene usarlo davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.07%20-%20Quando%20conviene%20usarlo%20davvero.md)

## Parte 03 — Dati, binding e presentazione

### 03.01.00

- [03.01.01 - Il passaggio che cambia davvero il modo di lavorare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.01%20-%20Il%20passaggio%20che%20cambia%20davvero%20il%20modo%20di%20lavorare.md)
- [03.01.02 - L’idea base target source e path](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.02%20-%20L%E2%80%99idea%20base%20target%20source%20e%20path.md)
- [03.01.03 - Il primo esempio minimo binding a un oggetto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.03%20-%20Il%20primo%20esempio%20minimo%20binding%20a%20un%20oggetto.md)
- [03.01.04 - DataContext il concetto da capire davvero bene](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.04%20-%20DataContext%20il%20concetto%20da%20capire%20davvero%20bene.md)
- [03.01.05 - Binding OneWay e TwoWay](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.05%20-%20Binding%20OneWay%20e%20TwoWay.md)
- [03.01.06 - Primo esempio utile form con TwoWay binding](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.06%20-%20Primo%20esempio%20utile%20form%20con%20TwoWay%20binding.md)
- [03.01.07 - Perché a volte il binding funziona solo a metà](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.07%20-%20Perch%C3%A9%20a%20volte%20il%20binding%20funziona%20solo%20a%20met%C3%A0.md)
- [03.01.08 - INotifyPropertyChanged la chiave per aggiornare la UI](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.08%20-%20INotifyPropertyChanged%20la%20chiave%20per%20aggiornare%20la%20UI.md)
- [03.01.09 - Esempio completo con aggiornamento reale della UI](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.09%20-%20Esempio%20completo%20con%20aggiornamento%20reale%20della%20UI.md)
- [03.01.10 - UpdateSourceTrigger](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.10%20-%20UpdateSourceTrigger.md)
- [03.01.11 - La sintassi del binding in XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.11%20-%20La%20sintassi%20del%20binding%20in%20XAML.md)
- [03.01.12 - Errori classici nel data binding](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.12%20-%20Errori%20classici%20nel%20data%20binding.md)

### 03.02.00

- [03.02.01 - Un solo oggetto nel DataContext](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.01%20-%20Un%20solo%20oggetto%20nel%20DataContext.md)
- [03.02.02 - Più oggetti diversi nella stessa finestra](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.02%20-%20Pi%C3%B9%20oggetti%20diversi%20nella%20stessa%20finestra.md)
- [03.02.03 - Sezioni con DataContext diversi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.03%20-%20Sezioni%20con%20DataContext%20diversi.md)
- [03.02.04 - Sorgente esplicita con Source ElementName o RelativeSource](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.04%20-%20Sorgente%20esplicita%20con%20Source%20ElementName%20o%20RelativeSource.md)
- [03.02.05 - Come nominarli correttamente in pratica](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.05%20-%20Come%20nominarli%20correttamente%20in%20pratica.md)
- [03.02.06 - Regola pratica da libro](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.06%20-%20Regola%20pratica%20da%20libro.md)
- [03.02.07 - Errore tipico da evitare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.07%20-%20Errore%20tipico%20da%20evitare.md)

### 03.03.00

- [03.03.01 - Perché una proprietà e un elenco non si aggiornano allo stesso modo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.01%20-%20Perch%C3%A9%20una%20propriet%C3%A0%20e%20un%20elenco%20non%20si%20aggiornano%20allo%20stesso%20modo.md)
- [03.03.02 - INotifyPropertyChanged a cosa serve davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.02%20-%20INotifyPropertyChanged%20a%20cosa%20serve%20davvero.md)
- [03.03.03 - Esempio completo con proprietà singole](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.03%20-%20Esempio%20completo%20con%20propriet%C3%A0%20singole.md)
- [03.03.04 - Errore classico proprietà automatiche senza notifica](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.04%20-%20Errore%20classico%20propriet%C3%A0%20automatiche%20senza%20notifica.md)
- [03.03.05 - ObservableCollection quando usarla](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.05%20-%20ObservableCollection%20quando%20usarla.md)
- [03.03.06 - Attenzione ObservableCollection non sostituisce INotifyPropertyChanged](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.06%20-%20Attenzione%20ObservableCollection%20non%20sostituisce%20INotifyPropertyChanged.md)
- [03.03.07 - Esempio con ListBox](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.07%20-%20Esempio%20con%20ListBox.md)
- [03.03.08 - Esempio con DataGrid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.08%20-%20Esempio%20con%20DataGrid.md)
- [03.03.09 - Caso d’uso lavorativo concreto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.09%20-%20Caso%20d%E2%80%99uso%20lavorativo%20concreto.md)
- [03.03.10 - Errori classici e come risolverli](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.10%20-%20Errori%20classici%20e%20come%20risolverli.md)
- [03.03.11 - Regola pratica da fissare bene](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.11%20-%20Regola%20pratica%20da%20fissare%20bene.md)

### 03.04.00

- [03.04.01 - Quando usare un converter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.01%20-%20Quando%20usare%20un%20converter.md)
- [03.04.02 - IValueConverter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.02%20-%20IValueConverter.md)
- [03.04.03 - Esempio bool a Visibility](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.03%20-%20Esempio%20bool%20a%20Visibility.md)
- [03.04.04 - Converter di formattazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.04%20-%20Converter%20di%20formattazione.md)
- [03.04.05 - ConvertBack](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.05%20-%20ConvertBack.md)
- [03.04.06 - ConverterParameter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.06%20-%20ConverterParameter.md)
- [03.04.07 - Converter e cultura CultureInfo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.07%20-%20Converter%20e%20cultura%20CultureInfo.md)
- [03.04.08 - Errori classici con i converter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.08%20-%20Errori%20classici%20con%20i%20converter.md)

### 03.05.00

- [03.05.01 - Perché una view è meglio che modificare la collezione originale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.01%20-%20Perch%C3%A9%20una%20view%20%C3%A8%20meglio%20che%20modificare%20la%20collezione%20originale.md)
- [03.05.02 - CollectionView](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.02%20-%20CollectionView.md)
- [03.05.03 - La default view di una collezione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.03%20-%20La%20default%20view%20di%20una%20collezione.md)
- [03.05.04 - Primo esempio ordinare da codice con la default view](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.04%20-%20Primo%20esempio%20ordinare%20da%20codice%20con%20la%20default%20view.md)
- [03.05.05 - CollectionViewSource](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.05%20-%20CollectionViewSource.md)
- [03.05.06 - Filtering](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.06%20-%20Filtering.md)
- [03.05.07 - Sorting](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.07%20-%20Sorting.md)
- [03.05.08 - Grouping](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.08%20-%20Grouping.md)
- [03.05.09 - GroupStyle](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.09%20-%20GroupStyle.md)

### 03.06.00

- [03.06.01 - Perché esistono le risorse](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.01%20-%20Perch%C3%A9%20esistono%20le%20risorse.md)
- [03.06.02 - Una risorsa semplice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.02%20-%20Una%20risorsa%20semplice.md)
- [03.06.03 - xKey](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.03%20-%20xKey.md)
- [03.06.04 - Dove si possono dichiarare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.04%20-%20Dove%20si%20possono%20dichiarare.md)
- [03.06.05 - StaticResource](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.05%20-%20StaticResource.md)
- [03.06.06 - DynamicResource](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.06%20-%20DynamicResource.md)
- [03.06.07 - Regola pratica](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.07%20-%20Regola%20pratica.md)
- [03.06.08 - Risorse non solo di colore](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.08%20-%20Risorse%20non%20solo%20di%20colore.md)
- [03.06.09 - Lo stile applicare un insieme di proprietà senza ripeterle](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.09%20-%20Lo%20stile%20applicare%20un%20insieme%20di%20propriet%C3%A0%20senza%20ripeterle.md)
- [03.06.10 - Stili con chiave e stili impliciti](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.10%20-%20Stili%20con%20chiave%20e%20stili%20impliciti.md)
- [03.06.11 - I trigger](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.11%20-%20I%20trigger.md)
- [03.06.12 - La differenza tra stile e template](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.12%20-%20La%20differenza%20tra%20stile%20e%20template.md)
- [03.06.13 - ControlTemplate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.13%20-%20ControlTemplate.md)
- [03.06.14 - DataTemplate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.14%20-%20DataTemplate.md)
- [03.06.15 - ResourceDictionary](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.15%20-%20ResourceDictionary.md)
- [03.06.16 - MergedDictionaries](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.16%20-%20MergedDictionaries.md)
- [03.06.17 - Un esempio pratico di organizzazione delle risorse](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.17%20-%20Un%20esempio%20pratico%20di%20organizzazione%20delle%20risorse.md)
- [03.06.18 - Risorse e converter](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.18%20-%20Risorse%20e%20converter.md)
- [03.06.19 - Risorse e template](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.19%20-%20Risorse%20e%20template.md)
- [03.06.20 - Risorse e manutenzione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.20%20-%20Risorse%20e%20manutenzione.md)
- [03.06.21 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.21%20-%20Errori%20tipici.md)
- [03.06.22 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.22%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 03.07.00

- [03.07.01 - Perché le proprietà normali non bastano](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.01%20-%20Perch%C3%A9%20le%20propriet%C3%A0%20normali%20non%20bastano.md)
- [03.07.02 - Definizione semplice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.02%20-%20Definizione%20semplice.md)
- [03.07.03 - Esempi di dependency property che usi già](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.03%20-%20Esempi%20di%20dependency%20property%20che%20usi%20gi%C3%A0.md)
- [03.07.04 - Che vantaggi danno davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.04%20-%20Che%20vantaggi%20danno%20davvero.md)
- [03.07.05 - Binding](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.05%20-%20Binding.md)
- [03.07.06 - Stili](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.06%20-%20Stili.md)
- [03.07.07 - Animazioni](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.07%20-%20Animazioni.md)
- [03.07.08 - Ereditarietà dei valori](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.08%20-%20Ereditariet%C3%A0%20dei%20valori.md)
- [03.07.09 - Come si dichiara una dependency property personalizzata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.09%20-%20Come%20si%20dichiara%20una%20dependency%20property%20personalizzata.md)
- [03.07.10 - Leggere bene lo schema Register](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.10%20-%20Leggere%20bene%20lo%20schema%20Register.md)
- [03.07.11 - Wrapper CLR](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.11%20-%20Wrapper%20CLR.md)
- [03.07.12 - Dove si usa davvero una dependency property personalizzata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.12%20-%20Dove%20si%20usa%20davvero%20una%20dependency%20property%20personalizzata.md)
- [03.07.13 - Metadata callback e comportamento avanzato](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.13%20-%20Metadata%20callback%20e%20comportamento%20avanzato.md)
- [03.07.14 - Dependency property e UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.14%20-%20Dependency%20property%20e%20UserControl.md)
- [03.07.15 - Quando non usarle](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.15%20-%20Quando%20non%20usarle.md)
- [03.07.16 - Confronto rapido con INotifyPropertyChanged](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.16%20-%20Confronto%20rapido%20con%20INotifyPropertyChanged.md)
- [03.07.17 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.17%20-%20Il%20punto%20da%20portare%20a%20casa.md)

## Parte 04 — Comportamento applicativo e struttura moderna

### 04.01.00

- [04.01.01 - Perché gli eventi Click non bastano sempre](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.01%20-%20Perch%C3%A9%20gli%20eventi%20Click%20non%20bastano%20sempre.md)
- [04.01.02 - Che cos’è un comando in WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.02%20-%20Che%20cos%E2%80%99%C3%A8%20un%20comando%20in%20WPF.md)
- [04.01.03 - Il commanding classico di WPF RoutedCommand](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.03%20-%20Il%20commanding%20classico%20di%20WPF%20RoutedCommand.md)
- [04.01.04 - Command CommandParameter e CommandTarget](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.04%20-%20Command%20CommandParameter%20e%20CommandTarget.md)
- [04.01.05 - Le scorciatoie da tastiera KeyBinding](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.05%20-%20Le%20scorciatoie%20da%20tastiera%20KeyBinding.md)
- [04.01.06 - ICommand e command personalizzati](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.06%20-%20ICommand%20e%20command%20personalizzati.md)
- [04.01.07 - RelayCommand](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.07%20-%20RelayCommand.md)
- [04.01.08 - Perché MVVM si sposa così bene con WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.08%20-%20Perch%C3%A9%20MVVM%20si%20sposa%20cos%C3%AC%20bene%20con%20WPF.md)
- [04.01.09 - Un primo esempio MVVM semplice ma concreto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.09%20-%20Un%20primo%20esempio%20MVVM%20semplice%20ma%20concreto.md)
- [04.01.10 - Perché CanExecute è così utile](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.10%20-%20Perch%C3%A9%20CanExecute%20%C3%A8%20cos%C3%AC%20utile.md)
- [04.01.11 - Eventi o comandi Non bisogna essere dogmatici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.11%20-%20Eventi%20o%20comandi%20Non%20bisogna%20essere%20dogmatici.md)
- [04.01.12 - Un caso lavorativo concreto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.12%20-%20Un%20caso%20lavorativo%20concreto.md)

### 04.02.00

- [04.02.01 - Window Page UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.01%20-%20Window%20Page%20UserControl.md)
- [04.02.02 - L’idea base una finestra shell con un’area contenuto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.02%20-%20L%E2%80%99idea%20base%20una%20finestra%20shell%20con%20un%E2%80%99area%20contenuto.md)
- [04.02.03 - Perché DataTemplate è la chiave di questo approccio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.03%20-%20Perch%C3%A9%20DataTemplate%20%C3%A8%20la%20chiave%20di%20questo%20approccio.md)
- [04.02.04 - Il ViewModel della shell](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.04%20-%20Il%20ViewModel%20della%20shell.md)
- [04.02.05 - UserControl come vista non come contenitore di logica](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.05%20-%20UserControl%20come%20vista%20non%20come%20contenitore%20di%20logica.md)
- [04.02.06 - Come viene assegnato il DataContext](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.06%20-%20Come%20viene%20assegnato%20il%20DataContext.md)
- [04.02.07 - Come caricare il UserControl in un’area della pagina](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.07%20-%20Come%20caricare%20il%20UserControl%20in%20un%E2%80%99area%20della%20pagina.md)
- [04.02.08 - Come comunicare con il UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.08%20-%20Come%20comunicare%20con%20il%20UserControl.md)
- [04.02.09 - Come ricevere feedback dal UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.09%20-%20Come%20ricevere%20feedback%20dal%20UserControl.md)
- [04.02.10 - Un esempio completo e realistico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.10%20-%20Un%20esempio%20completo%20e%20realistico.md)

### 04.03.00

- [04.03.01 - L’idea generale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.01%20-%20L%E2%80%99idea%20generale.md)
- [04.03.02 - Il modello](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.02%20-%20Il%20modello.md)
- [04.03.03 - La collezione bindata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.03%20-%20La%20collezione%20bindata.md)
- [04.03.04 - Il database SQLite](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.04%20-%20Il%20database%20SQLite.md)
- [04.03.05 - Creazione della tabella](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.05%20-%20Creazione%20della%20tabella.md)
- [04.03.06 - Il repository](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.06%20-%20Il%20repository.md)
- [04.03.07 - Caricare i dati nella raccolta bindata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.07%20-%20Caricare%20i%20dati%20nella%20raccolta%20bindata.md)
- [04.03.08 - Inserimento](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.08%20-%20Inserimento.md)
- [04.03.09 - Aggiornamento](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.09%20-%20Aggiornamento.md)
- [04.03.10 - Eliminazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.10%20-%20Eliminazione.md)
- [04.03.11 - Interfaccia con DataGrid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.11%20-%20Interfaccia%20con%20DataGrid.md)
- [04.03.12 - CRUD e Binding il modello mentale corretto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.12%20-%20CRUD%20e%20Binding%20il%20modello%20mentale%20corretto.md)
- [04.03.13 - Variante con Entity Framework Core](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.13%20-%20Variante%20con%20Entity%20Framework%20Core.md)
- [04.03.14 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.14%20-%20Errori%20tipici.md)
- [04.03.15 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.15%20-%20Regola%20pratica%20da%20ricordare.md)
- [04.03.16 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.16%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 04.04.00

- [04.04.01 - Il modello mentale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.01%20-%20Il%20modello%20mentale.md)
- [04.04.02 - Avviare un drag](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.02%20-%20Avviare%20un%20drag.md)
- [04.04.03 - Preparare il target](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.03%20-%20Preparare%20il%20target.md)
- [04.04.04 - AllowDrop](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.04%20-%20AllowDrop.md)
- [04.04.05 - Effetti di trascinamento](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.05%20-%20Effetti%20di%20trascinamento.md)
- [04.04.06 - Ricevere file trascinati da Esplora Risorse](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.06%20-%20Ricevere%20file%20trascinati%20da%20Esplora%20Risorse.md)
- [04.04.07 - Eventi intermedi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.07%20-%20Eventi%20intermedi.md)
- [04.04.08 - Un esempio pratico trascinare da una ListBox a un’altra](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.08%20-%20Un%20esempio%20pratico%20trascinare%20da%20una%20ListBox%20a%20un%E2%80%99altra.md)
- [04.04.09 - Drag and drop e ObservableCollection](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.09%20-%20Drag%20and%20drop%20e%20ObservableCollection.md)
- [04.04.10 - Drag and drop con oggetti personalizzati](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.10%20-%20Drag%20and%20drop%20con%20oggetti%20personalizzati.md)
- [04.04.11 - Drag and drop e UserControl](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.11%20-%20Drag%20and%20drop%20e%20UserControl.md)
- [04.04.12 - Feedback visivo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.12%20-%20Feedback%20visivo.md)
- [04.04.13 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.13%20-%20Errori%20tipici.md)
- [04.04.14 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.14%20-%20Regola%20pratica%20da%20ricordare.md)
- [04.04.15 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.15%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 04.05.00

- [04.05.01 - Il Dispatcher il cuore del thread UI](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.01%20-%20Il%20Dispatcher%20il%20cuore%20del%20thread%20UI.md)
- [04.05.02 - async e await](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.02%20-%20async%20e%20await.md)
- [04.05.03 - I-O-bound e CPU-bound](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.03%20-%20I-O-bound%20e%20CPU-bound.md)
- [04.05.04 - Dispatcher Invoke BeginInvoke e InvokeAsync](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.04%20-%20Dispatcher%20Invoke%20BeginInvoke%20e%20InvokeAsync.md)
- [04.05.05 - Un errore molto pericoloso Task Wait o Result](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.05%20-%20Un%20errore%20molto%20pericoloso%20Task%20Wait%20o%20Result.md)
- [04.05.06 - Progress bar e UI reattiva](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.06%20-%20Progress%20bar%20e%20UI%20reattiva.md)
- [04.05.07 - Progress reporting con percentuale reale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.07%20-%20Progress%20reporting%20con%20percentuale%20reale.md)
- [04.05.08 - E le collezioni bindate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.08%20-%20E%20le%20collezioni%20bindate.md)

### 04.06.00

- [04.06.01 - Perché MVVM rende testabile la logica della schermata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.01%20-%20Perch%C3%A9%20MVVM%20rende%20testabile%20la%20logica%20della%20schermata.md)
- [04.06.02 - Che cosa ha senso testare davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.02%20-%20Che%20cosa%20ha%20senso%20testare%20davvero.md)
- [04.06.03 - Primo esempio con xUnit](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.03%20-%20Primo%20esempio%20con%20xUnit.md)
- [04.06.04 - Testare proprietà derivate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.04%20-%20Testare%20propriet%C3%A0%20derivate.md)
- [04.06.05 - Testare un comando](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.05%20-%20Testare%20un%20comando.md)
- [04.06.06 - Che cosa non va testato nella view](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.06%20-%20Che%20cosa%20non%20va%20testato%20nella%20view.md)
- [04.06.07 - Il valore pratico della testabilità](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.07%20-%20Il%20valore%20pratico%20della%20testabilit%C3%A0.md)

## Parte 05 — Professionalità, localizzazione e distribuzione

### 05.01.00

- [05.01.01 - Il binding non mostra nulla](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.01%20-%20Il%20binding%20non%20mostra%20nulla.md)
- [05.01.02 - La UI non si aggiorna](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.02%20-%20La%20UI%20non%20si%20aggiorna.md)
- [05.01.03 - Le liste non si aggiornano](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.03%20-%20Le%20liste%20non%20si%20aggiornano.md)
- [05.01.04 - DataContext errato](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.04%20-%20DataContext%20errato.md)
- [05.01.05 - Template e stili usati male](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.05%20-%20Template%20e%20stili%20usati%20male.md)
- [05.01.06 - Errori ricorrenti reali](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.06%20-%20Errori%20ricorrenti%20reali.md)

### 05.02.00

- [05.02.01 - Globalizzazione e localizzazione la differenza giusta](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.01%20-%20Globalizzazione%20e%20localizzazione%20la%20differenza%20giusta.md)
- [05.02.02 - Il primo errore da evitare stringhe hardcoded ovunque](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.02%20-%20Il%20primo%20errore%20da%20evitare%20stringhe%20hardcoded%20ovunque.md)
- [05.02.03 - Il ruolo di xUid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.03%20-%20Il%20ruolo%20di%20xUid.md)
- [05.02.04 - Attributi e commenti di localizzazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.04%20-%20Attributi%20e%20commenti%20di%20localizzazione.md)
- [05.02.05 - Il layout automatico](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.05%20-%20Il%20layout%20automatico.md)
- [05.02.06 - Testi più lunghi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.06%20-%20Testi%20pi%C3%B9%20lunghi.md)
- [05.02.07 - Direzione del testo e bidirezionalita](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.07%20-%20Direzione%20del%20testo%20e%20bidirezionalita.md)
- [05.02.08 - Formati data numero e valuta](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.08%20-%20Formati%20data%20numero%20e%20valuta.md)
- [05.02.09 - Satellite assemblies e risorse localizzate](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.09%20-%20Satellite%20assemblies%20e%20risorse%20localizzate.md)
- [05.02.10 - Risorse XAML localizzabili e MergedDictionaries](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.10%20-%20Risorse%20XAML%20localizzabili%20e%20MergedDictionaries.md)

### 05.03.00

- [05.03.01 - Il modo più semplice splash screen nativo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.01%20-%20Il%20modo%20pi%C3%B9%20semplice%20splash%20screen%20nativo.md)
- [05.03.02 - Perché è comodo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.02%20-%20Perch%C3%A9%20%C3%A8%20comodo.md)
- [05.03.03 - I limiti dello splash standard](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.03%20-%20I%20limiti%20dello%20splash%20standard.md)
- [05.03.04 - Splash personalizzato come finestra WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.04%20-%20Splash%20personalizzato%20come%20finestra%20WPF.md)
- [05.03.05 - Come mostrarla all’avvio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.05%20-%20Come%20mostrarla%20all%E2%80%99avvio.md)
- [05.03.06 - Quando conviene uno splash personalizzato](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.06%20-%20Quando%20conviene%20uno%20splash%20personalizzato.md)
- [05.03.07 - Una strategia pratica molto sensata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.07%20-%20Una%20strategia%20pratica%20molto%20sensata.md)
- [05.03.08 - Splash screen loading screen e schermata iniziale non sono la stessa cosa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.08%20-%20Splash%20screen%20loading%20screen%20e%20schermata%20iniziale%20non%20sono%20la%20stessa%20cosa.md)
- [05.03.09 - Curare il design dello splash](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.09%20-%20Curare%20il%20design%20dello%20splash.md)
- [05.03.10 - Errori tipici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.10%20-%20Errori%20tipici.md)
- [05.03.11 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.11%20-%20Regola%20pratica%20da%20ricordare.md)
- [05.03.12 - Il punto da portare a casa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.12%20-%20Il%20punto%20da%20portare%20a%20casa.md)

### 05.04.00

- [05.04.01 - Il quadro generale quali strade esistono davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.01%20-%20Il%20quadro%20generale%20quali%20strade%20esistono%20davvero.md)
- [05.04.02 - Publish to folder](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.02%20-%20Publish%20to%20folder.md)
- [05.04.03 - ClickOnce](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.03%20-%20ClickOnce.md)
- [05.04.04 - MSIX](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.04%20-%20MSIX.md)
- [05.04.05 - Framework-dependent o self-contained](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.05%20-%20Framework-dependent%20o%20self-contained.md)
- [05.04.06 - Publish to folder la soluzione più semplice](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.06%20-%20Publish%20to%20folder%20la%20soluzione%20pi%C3%B9%20semplice.md)
- [05.04.07 - ClickOnce installazione semplice e aggiornamenti integrati](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.07%20-%20ClickOnce%20installazione%20semplice%20e%20aggiornamenti%20integrati.md)
- [05.04.08 - Le proprietà importanti di ClickOnce](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.08%20-%20Le%20propriet%C3%A0%20importanti%20di%20ClickOnce.md)
- [05.04.09 - Quando scegliere quale strada](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.09%20-%20Quando%20scegliere%20quale%20strada.md)

### 05.05.00

- [05.05.01 - Perché l’accessibilità non è un dettaglio](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.01%20-%20Perch%C3%A9%20l%E2%80%99accessibilit%C3%A0%20non%20%C3%A8%20un%20dettaglio.md)
- [05.05.02 - Focus e keyboard navigation](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.02%20-%20Focus%20e%20keyboard%20navigation.md)
- [05.05.03 - Ordine di tabulazione e leggibilità operativa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.03%20-%20Ordine%20di%20tabulazione%20e%20leggibilit%C3%A0%20operativa.md)
- [05.05.04 - Proprietà utili per UI Automation](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.04%20-%20Propriet%C3%A0%20utili%20per%20UI%20Automation.md)
- [05.05.05 - Un accenno a AutomationPeer](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.05%20-%20Un%20accenno%20a%20AutomationPeer.md)
- [05.05.06 - Errori tipici da evitare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.06%20-%20Errori%20tipici%20da%20evitare.md)
- [05.05.07 - Regola pratica da ricordare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.07%20-%20Regola%20pratica%20da%20ricordare.md)

### 05.06.00

- [05.06.01 - Il modello mentale corretto di WPF](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.01%20-%20Il%20modello%20mentale%20corretto%20di%20WPF.md)
- [05.06.02 - Il ruolo di XAML](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.02%20-%20Il%20ruolo%20di%20XAML.md)
- [05.06.03 - Layout dati e presentazione](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.03%20-%20Layout%20dati%20e%20presentazione.md)
- [05.06.04 - Il ruolo del code-behind](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.04%20-%20Il%20ruolo%20del%20code-behind.md)
- [05.06.05 - Come proseguire dopo il libro](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.05%20-%20Come%20proseguire%20dopo%20il%20libro.md)

## Parte 06 — Caso d’uso finale

### 06.01.00

- [06.01.01 - Perché questo caso d’uso è didatticamente utile](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.01.01%20-%20Perch%C3%A9%20questo%20caso%20d%E2%80%99uso%20%C3%A8%20didatticamente%20utile.md)
- [06.01.02 - Le varianti possibili](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.01.02%20-%20Le%20varianti%20possibili.md)
- [06.01.03 - I concetti WPF che mette insieme](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.01.03%20-%20I%20concetti%20WPF%20che%20mette%20insieme.md)

### 06.02.00

- [06.02.01 - Obiettivo della schermata](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.02.01%20-%20Obiettivo%20della%20schermata.md)
- [06.02.02 - Requisiti pratici](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.02.02%20-%20Requisiti%20pratici.md)
- [06.02.03 - Flusso operativo](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.02.03%20-%20Flusso%20operativo.md)

### 06.03.00

- [06.03.01 - Regole funzionali](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.01%20-%20Regole%20funzionali.md)
- [06.03.02 - Modelli Tavolo Piatto RigaConto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.02%20-%20Modelli%20Tavolo%20Piatto%20RigaConto.md)
- [06.03.03 - CassaRistoranteViewModel](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.03%20-%20CassaRistoranteViewModel.md)
- [06.03.04 - Comandi e collezioni](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.04%20-%20Comandi%20e%20collezioni.md)
- [06.03.05 - Scelte di layout](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.05%20-%20Scelte%20di%20layout.md)

### 06.04.00

- [06.04.01 - Modelli](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.01%20-%20Modelli.md)
- [06.04.02 - RelayCommand](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.02%20-%20RelayCommand.md)
- [06.04.03 - ViewModel](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.03%20-%20ViewModel.md)
- [06.04.04 - Collezioni osservabili](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.04%20-%20Collezioni%20osservabili.md)
- [06.04.05 - Proprietà e comandi](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.05%20-%20Propriet%C3%A0%20e%20comandi.md)

### 06.05.00

- [06.05.01 - MainWindow.xaml](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.01%20-%20MainWindow.xaml.md)
- [06.05.02 - Struttura della Grid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.02%20-%20Struttura%20della%20Grid.md)
- [06.05.03 - Parte sinistra](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.03%20-%20Parte%20sinistra.md)
- [06.05.04 - Parte destra con DataGrid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.04%20-%20Parte%20destra%20con%20DataGrid.md)
- [06.05.05 - Rifiniture visive](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.05%20-%20Rifiniture%20visive.md)

### 06.06.00

- [06.06.01 - Lettura guidata della UI completa](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.01%20-%20Lettura%20guidata%20della%20UI%20completa.md)
- [06.06.02 - Input](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.02%20-%20Input.md)
- [06.06.03 - DataGrid](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.03%20-%20DataGrid.md)
- [06.06.04 - Scelte progettuali](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.04%20-%20Scelte%20progettuali.md)
- [06.06.05 - Cosa migliorare in una versione successiva](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.05%20-%20Cosa%20migliorare%20in%20una%20versione%20successiva.md)

### 06.07.00

- [06.07.01 - Prima finestra compilabile](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.01%20-%20Prima%20finestra%20compilabile.md)
- [06.07.02 - Inserire i tavoli e vedere il contesto cambiare](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.02%20-%20Inserire%20i%20tavoli%20e%20vedere%20il%20contesto%20cambiare.md)
- [06.07.03 - Aggiungere i piatti e far nascere il conto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.03%20-%20Aggiungere%20i%20piatti%20e%20far%20nascere%20il%20conto.md)
- [06.07.04 - Far aggiornare quantità e totale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.04%20-%20Far%20aggiornare%20quantit%C3%A0%20e%20totale.md)
- [06.07.05 - Introdurre i comandi e ripulire il code-behind](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.05%20-%20Introdurre%20i%20comandi%20e%20ripulire%20il%20code-behind.md)
- [06.07.06 - Rifinire la UI senza romperne la chiarezza](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.06%20-%20Rifinire%20la%20UI%20senza%20romperne%20la%20chiarezza.md)
- [06.07.07 - Versione completa del progetto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.07%20-%20Versione%20completa%20del%20progetto.md)
- [06.07.08 - Cosa abbiamo costruito davvero](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.08%20-%20Cosa%20abbiamo%20costruito%20davvero.md)

### 06.08.00

- [06.08.01 - Aggiungere categorie prodotto](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.08.01%20-%20Aggiungere%20categorie%20prodotto.md)
- [06.08.02 - Salvare i dati con SQLite](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.08.02%20-%20Salvare%20i%20dati%20con%20SQLite.md)
- [06.08.03 - Migliorare gli stati dei tavoli](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.08.03%20-%20Migliorare%20gli%20stati%20dei%20tavoli.md)
- [06.08.04 - Preparare la strada a una versione più professionale](https://github.com/archistico/WPF-in-pratica/blob/main/book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.08.04%20-%20Preparare%20la%20strada%20a%20una%20versione%20pi%C3%B9%20professionale.md)

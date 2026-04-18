# WPF in pratica

## Dalle fondamenta a un progetto desktop vero con XAML, binding, MVVM e caso d’uso finale

Questo repository raccoglie il materiale di un libro pratico su **WPF (Windows Presentation Foundation)** pensato per accompagnare il lettore dalla base fino a una piccola applicazione desktop completa e credibile.

L’idea non è mostrare solo controlli isolati o frammenti di XAML, ma costruire poco per volta un modo corretto di leggere, progettare e sviluppare una UI desktop con WPF:

- prima si capisce **che cos’è WPF** e quale ruolo ha **XAML**
- poi si entra in **layout, controlli, binding, risorse, stili e template**
- quindi si affrontano **commanding, MVVM, navigazione, testabilità, localizzazione e distribuzione**
- infine si arriva a un **caso d’uso finale** sviluppato come progetto guidato

Il percorso è pensato soprattutto per sviluppatori C# che vogliono imparare WPF in modo chiaro, progressivo e orientato alla pratica.

---

## Struttura del repository

Il contenuto del libro si trova nella cartella:

- [`book_extract_revised`](./book_extract_revised)

All’interno trovi:

- la scaletta generale del libro
- la prefazione
- le cartelle delle varie parti
- dentro ogni parte, le cartelle dei capitoli
- dentro ogni capitolo, i file Markdown dei sottocapitoli realmente presenti

Questa organizzazione rende più semplice spostare, aggiungere o completare i contenuti senza dover riscrivere ogni volta tutto il README.

---

## Accesso rapido

### File iniziali

- [`00 - Scaletta_definitiva_libro_WPF.md`](./book_extract_revised/00%20-%20Scaletta_definitiva_libro_WPF.md)
- [`00.00.00 - Prefazione.md`](./book_extract_revised/00.00.00%20-%20Prefazione.md)

### Parti del libro

- [PARTE 01 - Fondamenta: capire WPF prima di usarlo](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo)
- [PARTE 02 - Layout, controlli e interfaccia](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia)
- [PARTE 03 - Dati, binding e presentazione](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione)
- [PARTE 04 - Comportamento applicativo e struttura moderna](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna)
- [PARTE 05 - Professionalità, localizzazione e distribuzione](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione)
- [PARTE 06 - Caso d’uso finale](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale)

---

## Indice ragionato

## Parte 01 — Fondamenta: capire WPF prima di usarlo

Questa parte costruisce le basi concettuali necessarie per leggere WPF nel modo giusto, senza partire subito da concetti troppo avanzati.

Capitoli:

- [`01.01.00 - Architettura di WPF`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.01.00%20-%20Architettura%20di%20WPF)
- [`01.02.00 - Ambiente di sviluppo`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.02.00%20-%20Ambiente%20di%20sviluppo)
- [`01.03.00 - Che cos’è WPF, che cos’è XAML`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.03.00%20-%20Che%20cos%E2%80%99%C3%A8%20WPF%2C%20che%20cos%E2%80%99%C3%A8%20XAML)
- [`01.04.00 - La sintassi di XAML spiegata bene`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.04.00%20-%20La%20sintassi%20di%20XAML%20spiegata%20bene)
- [`01.05.00 - Namespace e Assembly`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.05.00%20-%20Namespace%20e%20Assembly)
- [`01.06.00 - A cosa serve App.xaml`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.06.00%20-%20A%20cosa%20serve%20%60App.xaml%60)
- [`01.07.00 - XAML e code-behind`](./book_extract_revised/PARTE%2001%20-%20Fondamenta%20capire%20WPF%20prima%20di%20usarlo/01.07.00%20-%20XAML%20e%20code-behind)

## Parte 02 — Layout, controlli e interfaccia

Questa parte entra nella costruzione concreta delle schermate: pannelli, controlli, personalizzazione visuale, grafica e animazioni.

Capitoli:

- [`02.01.00 - Il layout in WPF`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.01.00%20-%20Il%20layout%20in%20WPF)
- [`02.02.00 - I controlli fondamentali`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.02.00%20-%20I%20controlli%20fondamentali)
- [`02.03.00 - ComboBox e scenari avanzati`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.03.00%20-%20ComboBox%20e%20scenari%20avanzati)
- [`02.04.00 - Menu e ToolBar`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.04.00%20-%20Menu%20e%20ToolBar)
- [`02.05.00 - Altri controlli utili`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.05.00%20-%20Altri%20controlli%20utili)
- [`02.06.00 - Styling e rifinitura visiva`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.06.00%20-%20Styling%20e%20rifinitura%20visiva)
- [`02.07.00 - Grafica vettoriale e disegno`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.07.00%20-%20Grafica%20vettoriale%20e%20disegno)
- [`02.08.00 - Animazioni`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.08.00%20-%20Animazioni)
- [`02.09.00 - VisualStateManager`](./book_extract_revised/PARTE%2002%20-%20Layout%2C%20controlli%20e%20interfaccia/02.09.00%20-%20VisualStateManager)

## Parte 03 — Dati, binding e presentazione

Qui si entra nel cuore produttivo di WPF: `DataContext`, binding, notifiche di cambiamento, converter, viste di collezione, risorse e dependency property.

Capitoli:

- [`03.01.00 - Data binding`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.01.00%20-%20Data%20binding)
- [`03.02.00 - DataContext e sorgenti dati`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.02.00%20-%20DataContext%20e%20sorgenti%20dati)
- [`03.03.00 - INotifyPropertyChanged e ObservableCollection`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.03.00%20-%20INotifyPropertyChanged%20e%20ObservableCollection)
- [`03.04.00 - Converter`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.04.00%20-%20Converter)
- [`03.05.00 - CollectionView, sorting, filtering e grouping`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.05.00%20-%20CollectionView%2C%20sorting%2C%20filtering%20e%20grouping)
- [`03.06.00 - Risorse, stili e template`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.06.00%20-%20Risorse%2C%20stili%20e%20template)
- [`03.07.00 - Dependency Properties`](./book_extract_revised/PARTE%2003%20-%20Dati%2C%20binding%20e%20presentazione/03.07.00%20-%20Dependency%20Properties)

## Parte 04 — Comportamento applicativo e struttura moderna

Questa parte sposta il focus dall’aspetto visivo alla struttura applicativa: comandi, MVVM, composizione delle viste, CRUD, drag and drop, threading e testabilità.

Capitoli:

- [`04.01.00 - Commanding e MVVM`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.01.00%20-%20Commanding%20e%20MVVM)
- [`04.02.00 - Navigazione con Window, Page e UserControl`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.02.00%20-%20Navigazione%20con%20Window%2C%20Page%20e%20UserControl)
- [`04.03.00 - CRUD SQLite integrato con il binding`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.03.00%20-%20CRUD%20SQLite%20integrato%20con%20il%20binding)
- [`04.04.00 - Drag and Drop`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.04.00%20-%20Drag%20and%20Drop)
- [`04.05.00 - Multithreading e reattività UI`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.05.00%20-%20Multithreading%20e%20reattivit%C3%A0%20UI)
- [`04.06.00 - Testabilità del ViewModel`](./book_extract_revised/PARTE%2004%20-%20Comportamento%20applicativo%20e%20struttura%20moderna/04.06.00%20-%20Testabilit%C3%A0%20del%20ViewModel)

## Parte 05 — Professionalità, localizzazione e distribuzione

Questa parte raccoglie i temi che fanno crescere un progetto WPF oltre il semplice esempio tecnico: problemi ricorrenti, localizzazione, splash screen, publish e accessibilità.

Capitoli:

- [`05.01.00 - Problemi reali e debugging`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.01.00%20-%20Problemi%20reali%20e%20debugging)
- [`05.02.00 - Localizzazione e globalizzazione`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.02.00%20-%20Localizzazione%20e%20globalizzazione)
- [`05.03.00 - Splash screen`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.03.00%20-%20Splash%20screen)
- [`05.04.00 - Distribuzione e packaging`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.04.00%20-%20Distribuzione%20e%20packaging)
- [`05.05.00 - Accessibilità`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.05.00%20-%20Accessibilit%C3%A0)
- [`05.06.00 - Conclusioni operative`](./book_extract_revised/PARTE%2005%20-%20Professionalit%C3%A0%2C%20localizzazione%20e%20distribuzione/05.06.00%20-%20Conclusioni%20operative)

## Parte 06 — Caso d’uso finale

L’ultima parte mette insieme i concetti del libro in un progetto desktop completo, presentato in modo progressivo.

Capitoli:

- [`06.01.00 - Perché questo caso d’uso`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.01.00%20-%20Perch%C3%A9%20questo%20caso%20d%E2%80%99uso)
- [`06.02.00 - Obiettivo, requisiti e flusso`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.02.00%20-%20Obiettivo%2C%20requisiti%20e%20flusso)
- [`06.03.00 - Modello concettuale dell’app`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.03.00%20-%20Modello%20concettuale%20dell%E2%80%99app)
- [`06.04.00 - Costruzione della logica`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.04.00%20-%20Costruzione%20della%20logica)
- [`06.05.00 - Costruzione della UI`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.05.00%20-%20Costruzione%20della%20UI)
- [`06.06.00 - Lettura guidata del progetto`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.06.00%20-%20Lettura%20guidata%20del%20progetto)
- [`06.07.00 - Costruzione guidata passo per passo`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.07.00%20-%20Costruzione%20guidata%20passo%20per%20passo)
- [`06.08.00 - Evoluzioni possibili`](./book_extract_revised/PARTE%2006%20-%20Caso%20d%E2%80%99uso%20finale/06.08.00%20-%20Evoluzioni%20possibili)

---

## Come leggere il materiale

Il repository non va letto come un dump di appunti isolati, ma come un percorso progressivo.

Ogni capitolo ha una sua cartella.  
Ogni sottocapitolo è un file Markdown numerato.

Questo permette di:

- mantenere l’ordine didattico
- spostare facilmente i file senza rompere la numerazione generale
- vedere subito quali sezioni sono già presenti in un capitolo
- aggiungere nuovi contenuti senza riorganizzare tutto il repository

---

## Stato del progetto editoriale

Questo repository è un lavoro editoriale in evoluzione.

Per questo motivo:

- alcuni capitoli possono avere più sottocapitoli di altri
- alcuni contenuti possono essere ancora in fase di completamento o revisione
- la struttura principale per parti e capitoli resta il riferimento più stabile per orientarsi

---

## A chi è rivolto

Questo materiale è utile soprattutto a:

- sviluppatori C# che vogliono iniziare con WPF
- sviluppatori WinForms che vogliono capire il cambio di mentalità
- chi conosce già XAML ma vuole consolidare binding, MVVM e struttura applicativa
- chi cerca un percorso pratico e non solo una raccolta di esempi scollegati

---

## Obiettivo finale

Il vero obiettivo del repository non è “spiegare i controlli di WPF”, ma arrivare a questo risultato:

- capire il modello mentale di WPF
- costruire interfacce leggibili e manutenibili
- usare bene binding, risorse, comandi e ViewModel
- saper organizzare un piccolo progetto desktop reale
- completare un caso d’uso finale che unisca UI, logica e struttura

---

## Nota sulla navigazione

Se cerchi un argomento specifico, il modo più robusto per trovarlo è:

1. entrare nella parte corretta
2. aprire il capitolo corretto
3. consultare i file `.md` realmente presenti in quella cartella

In questo modo il README resta stabile anche quando i file vengono spostati, rinominati o completati nel tempo.
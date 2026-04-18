using System.Text;

internal static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            string repositoryRoot = AppContext.BaseDirectory;
            string sourceFolderName = "book_extract_revised";
            string outputFileName = "README.md";

            if (args.Length >= 1 && !string.IsNullOrWhiteSpace(args[0]))
            {
                repositoryRoot = Path.GetFullPath(args[0]);
            }

            if (args.Length >= 2 && !string.IsNullOrWhiteSpace(args[1]))
            {
                sourceFolderName = args[1];
            }

            if (args.Length >= 3 && !string.IsNullOrWhiteSpace(args[2]))
            {
                outputFileName = args[2];
            }

            string sourceFolderPath = Path.Combine(repositoryRoot, sourceFolderName);
            string outputFilePath = Path.Combine(repositoryRoot, outputFileName);

            if (!Directory.Exists(sourceFolderPath))
            {
                Console.Error.WriteLine($"Cartella non trovata: {sourceFolderPath}");
                Console.Error.WriteLine("Uso:");
                Console.Error.WriteLine("  ReadmeGenerator.exe [RepositoryRoot] [SourceFolderName] [OutputFileName]");
                Console.Error.WriteLine("Esempio:");
                Console.Error.WriteLine(@"  ReadmeGenerator.exe ""R:\Siti\WPF-in-pratica"" ""book_extract_revised"" ""README.md""");
                return 1;
            }

            string readme = BuildReadme(repositoryRoot, sourceFolderPath, sourceFolderName);
            File.WriteAllText(outputFilePath, readme, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

            Console.WriteLine($"README generato: {outputFilePath}");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Errore durante la generazione del README.");
            Console.Error.WriteLine(ex.ToString());
            return 2;
        }
    }

    private static string BuildReadme(string repositoryRoot, string sourceFolderPath, string sourceFolderName)
    {
        var sb = new StringBuilder();

        var topFiles = Directory
            .GetFiles(sourceFolderPath, "*.md", SearchOption.TopDirectoryOnly)
            .OrderBy(Path.GetFileName, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var partDirectories = Directory
            .GetDirectories(sourceFolderPath)
            .OrderBy(Path.GetFileName, StringComparer.OrdinalIgnoreCase)
            .ToList();

        sb.AppendLine("# WPF in pratica");
        sb.AppendLine();
        sb.AppendLine("## Dalle fondamenta a un progetto desktop vero con XAML, binding, MVVM e caso d’uso finale");
        sb.AppendLine();
        sb.AppendLine("Questo repository raccoglie il materiale di un libro pratico su **WPF (Windows Presentation Foundation)** pensato per accompagnare il lettore dalla base fino a una piccola applicazione desktop completa e credibile.");
        sb.AppendLine();
        sb.AppendLine("L’idea non è mostrare solo controlli isolati o frammenti di XAML, ma costruire poco per volta un modo corretto di leggere, progettare e sviluppare una UI desktop con WPF:");
        sb.AppendLine();
        sb.AppendLine("- prima si capisce **che cos’è WPF** e quale ruolo ha **XAML**");
        sb.AppendLine("- poi si entra in **layout, controlli, binding, risorse, stili e template**");
        sb.AppendLine("- quindi si affrontano **commanding, MVVM, navigazione, testabilità, localizzazione e distribuzione**");
        sb.AppendLine("- infine si arriva a un **caso d’uso finale** sviluppato come progetto guidato");
        sb.AppendLine();
        sb.AppendLine("Il percorso è pensato soprattutto per sviluppatori C# che vogliono imparare WPF in modo chiaro, progressivo e orientato alla pratica.");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Struttura del repository");
        sb.AppendLine();
        sb.AppendLine($"- [`{sourceFolderName}`](./{EncodeRelativePath(sourceFolderName)})");
        sb.AppendLine();
        sb.AppendLine("All’interno trovi:");
        sb.AppendLine();
        sb.AppendLine("- la scaletta generale del libro");
        sb.AppendLine("- la prefazione");
        sb.AppendLine("- le cartelle delle varie parti");
        sb.AppendLine("- dentro ogni parte, le cartelle dei capitoli");
        sb.AppendLine("- dentro ogni capitolo, i file Markdown dei sottocapitoli realmente presenti");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Accesso rapido");
        sb.AppendLine();
        sb.AppendLine("### File iniziali");
        sb.AppendLine();

        foreach (string file in topFiles)
        {
            string relativePath = Path.GetRelativePath(repositoryRoot, file);
            sb.AppendLine($"- [`{Path.GetFileName(file)}`](./{EncodeRelativePath(relativePath)})");
        }

        sb.AppendLine();
        sb.AppendLine("### Parti del libro");
        sb.AppendLine();

        foreach (string partDir in partDirectories)
        {
            string relativePath = Path.GetRelativePath(repositoryRoot, partDir);
            sb.AppendLine($"- [`{Path.GetFileName(partDir)}`](./{EncodeRelativePath(relativePath)})");
        }

        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Indice completo");
        sb.AppendLine();

        foreach (string partDir in partDirectories)
        {
            string partName = Path.GetFileName(partDir);
            string partRelativePath = Path.GetRelativePath(repositoryRoot, partDir);

            sb.AppendLine($"## [{EscapeMarkdown(partName)}](./{EncodeRelativePath(partRelativePath)})");
            sb.AppendLine();

            var chapterDirectories = Directory
                .GetDirectories(partDir)
                .OrderBy(Path.GetFileName, StringComparer.OrdinalIgnoreCase)
                .ToList();

            foreach (string chapterDir in chapterDirectories)
            {
                string chapterName = Path.GetFileName(chapterDir);
                string chapterRelativePath = Path.GetRelativePath(repositoryRoot, chapterDir);

                sb.AppendLine($"### [{EscapeMarkdown(chapterName)}](./{EncodeRelativePath(chapterRelativePath)})");
                sb.AppendLine();

                var chapterFiles = Directory
                    .GetFiles(chapterDir, "*.md", SearchOption.TopDirectoryOnly)
                    .OrderBy(Path.GetFileName, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (chapterFiles.Count == 0)
                {
                    sb.AppendLine("- _Nessun file Markdown presente in questo capitolo._");
                    sb.AppendLine();
                    continue;
                }

                foreach (string chapterFile in chapterFiles)
                {
                    string fileName = Path.GetFileName(chapterFile);
                    string fileBaseName = Path.GetFileNameWithoutExtension(chapterFile);
                    string fileRelativePath = Path.GetRelativePath(repositoryRoot, chapterFile);

                    sb.AppendLine($"- [`{EscapeMarkdown(fileBaseName)}`](./{EncodeRelativePath(fileRelativePath)})");
                }

                sb.AppendLine();
            }
        }

        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Come leggere il materiale");
        sb.AppendLine();
        sb.AppendLine("Il repository non va letto come un dump di appunti isolati, ma come un percorso progressivo.");
        sb.AppendLine();
        sb.AppendLine("Ogni capitolo ha una sua cartella.");
        sb.AppendLine("Ogni sottocapitolo è un file Markdown numerato.");
        sb.AppendLine();
        sb.AppendLine("Questo permette di:");
        sb.AppendLine();
        sb.AppendLine("- mantenere l’ordine didattico");
        sb.AppendLine("- spostare facilmente i file senza rompere la navigazione");
        sb.AppendLine("- vedere subito quali sezioni sono già presenti in un capitolo");
        sb.AppendLine("- aggiungere nuovi contenuti senza dover riscrivere il README a mano");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Stato del progetto editoriale");
        sb.AppendLine();
        sb.AppendLine("Questo repository è un lavoro editoriale in evoluzione.");
        sb.AppendLine();
        sb.AppendLine("Per questo motivo:");
        sb.AppendLine();
        sb.AppendLine("- alcuni capitoli possono avere più sottocapitoli di altri");
        sb.AppendLine("- alcuni contenuti possono essere ancora in fase di completamento o revisione");
        sb.AppendLine("- l’indice qui sopra riflette i file realmente presenti nel repository");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## A chi è rivolto");
        sb.AppendLine();
        sb.AppendLine("- sviluppatori C# che vogliono iniziare con WPF");
        sb.AppendLine("- sviluppatori WinForms che vogliono capire il cambio di mentalità");
        sb.AppendLine("- chi conosce già XAML ma vuole consolidare binding, MVVM e struttura applicativa");
        sb.AppendLine("- chi cerca un percorso pratico e non solo una raccolta di esempi scollegati");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine("## Obiettivo finale");
        sb.AppendLine();
        sb.AppendLine("Il vero obiettivo del repository non è soltanto spiegare i controlli di WPF, ma arrivare a questo risultato:");
        sb.AppendLine();
        sb.AppendLine("- capire il modello mentale di WPF");
        sb.AppendLine("- costruire interfacce leggibili e manutenibili");
        sb.AppendLine("- usare bene binding, risorse, comandi e ViewModel");
        sb.AppendLine("- saper organizzare un piccolo progetto desktop reale");
        sb.AppendLine("- completare un caso d’uso finale che unisca UI, logica e struttura");
        sb.AppendLine();

        return sb.ToString();
    }

    private static string EncodeRelativePath(string relativePath)
    {
        string normalized = relativePath.Replace('\\', '/');
        string[] parts = normalized.Split('/', StringSplitOptions.RemoveEmptyEntries);

        return string.Join("/", parts.Select(Uri.EscapeDataString));
    }

    private static string EscapeMarkdown(string text)
    {
        return text
            .Replace(@"\", @"\\")
            .Replace("`", @"\`")
            .Replace("[", @"\[")
            .Replace("]", @"\]");
    }
}
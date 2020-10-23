using System;

namespace Canzoni
{
    class Program
    {
        public struct Canzone
        {
            public string codice;
            public string autore;
            public string titolo;
            public string nome;
            public int tempo;
            public string genere;
            public decimal prezzo;
        }

        public struct Playlist
        {
            public string nom;
            public Canzone[] eleCanzoni;
        }


        static void Main(string[] args)
        {
            //Varaibili
            Canzone[] elenco = new Canzone[100];            //Contiene tutte le canzoni
            int num = 0;        //Numero di canzoni
            ConsoleKeyInfo scelta = default(ConsoleKeyInfo);
            string[] genere = new string[30];           //Contiene i generi
            int y = 0;          //Numero di generi
            Playlist[] playlist = new Playlist[100];
            int p = 0;          //Numero di playlist


            if (true) //Esempi
            {
                elenco[num].codice = "tr01";
                elenco[num].autore = "Slait";
                elenco[num].titolo = "Altalene";
                elenco[num].nome = "Altalene.mp3";
                elenco[num].tempo = 156;
                elenco[num].genere = "Trap";
                genere[y] = "Trap";
                elenco[num].prezzo = 800;
                num = num + 1;
                y += 1;

                elenco[num].codice = "tr02";
                elenco[num].autore = "Ernia";
                elenco[num].titolo = "Superclassico";
                elenco[num].nome = "Superclassico.mp3";
                elenco[num].tempo = 204;
                elenco[num].genere = "Pop";
                genere[y] = "Pop";
                elenco[num].prezzo = 650;
                num = num + 1;
                y += 1;

                elenco[num].codice = "tr03";
                elenco[num].autore = "Slait";
                elenco[num].titolo = "X1 Mex";
                elenco[num].nome = "X1 Mex.mp3";
                elenco[num].tempo = 136;
                elenco[num].genere = "Trap";
                elenco[num].prezzo = 700;
                num = num + 1;

                elenco[num].codice = "tr04";
                elenco[num].autore = "Dj Ponte";
                elenco[num].titolo = "Blue (da ba dee)";
                elenco[num].nome = "Blue.mp3";
                elenco[num].tempo = 240;
                elenco[num].genere = "Disco";
                genere[y] = "Disco";
                elenco[num].prezzo = 600;
                num = num + 1;
                y += 1;

                elenco[num].codice = "tr05";
                elenco[num].autore = "Martin Garrix";
                elenco[num].titolo = "Animals";
                elenco[num].nome = "Animals.mp3";
                elenco[num].tempo = 162;
                elenco[num].genere = "Pop";
                elenco[num].prezzo = 900;
                num = num + 1;

                elenco[num].codice = "tr06";
                elenco[num].autore = "Il pagante";
                elenco[num].titolo = "Settimana bianca";
                elenco[num].nome = "Settimana.mp3";
                elenco[num].tempo = 195;
                elenco[num].genere = "Disco";
                elenco[num].prezzo = 800;
                num = num + 1;

                elenco[num].codice = "tr07";
                elenco[num].autore = "Linking Park";
                elenco[num].titolo = "Good Goodbye";
                elenco[num].nome = "Goodbye.mp3";
                elenco[num].tempo = 240;
                elenco[num].genere = "Pop";
                elenco[num].prezzo = 700;
                num = num + 1;


            }       //Esempi


            do
            {
                int x = 0;
                Console.Clear();

                //menù
                Console.WriteLine("Benvenuto nell'elenco di canzoni di Angioletti");
                Console.WriteLine("".PadRight(30, '_'));
                Console.WriteLine("[1] Nuova canzone");
                Console.WriteLine("[2] Elenca tutte le canzoni");
                Console.WriteLine("[3] Modifica una canzone");
                Console.WriteLine("[4] Cancella una traccia");
                Console.WriteLine("[5] Calcola la media di prezzo di un genere");
                Console.WriteLine("[6] Prodotto più costoso");
                Console.WriteLine("".PadRight(30, '_'));
                Console.WriteLine("[7] Cra una playlist");
                Console.WriteLine("[8] Visualizza una playlist");
                Console.WriteLine("[9] Modifica una playlist\n");
                Console.WriteLine("[U] Esci");

                scelta = Console.ReadKey(true);

                Console.Clear();
                switch (scelta.KeyChar.ToString())
                {
                    case "1":           //aggingi nuove canzoni
                        {
                            bool ripeti = true;

                            while (ripeti)
                            {
                                if (num >= 100)         //Controlla che ci siano spazi disponibili
                                {
                                    Console.WriteLine("Hai inserito toprri prodotti");
                                    break;
                                }


                                //Contatori
                                int n = 0;
                                int a = 0;
                                x = 0;

                                bool cerca = true;          //Continua solo con codici validi

                                Console.Write("Inserisci il codice della traccia:  ");
                                elenco[num].codice = Console.ReadLine();            //Inserisci il codice


                                if (String.IsNullOrWhiteSpace(elenco[num].codice) == true)          //Controlla che il codice non sia vuoto
                                {
                                    Console.WriteLine("Devi inserire il codice");
                                    cerca = false;
                                }


                                while (x < num)         // Controlla che il codice non sia già stato usato  
                                {

                                    if (elenco[x].codice == elenco[num].codice)
                                    {
                                        Console.WriteLine($"Hai già usato questo codice per la canzone {elenco[x].titolo}");
                                        cerca = false;
                                    }

                                    x = x + 1;
                                }


                                if (cerca)          //Se il codice non è mai stato usato inserisce il resto, sennò ricomincia
                                {
                                    Console.Write("Inserisci il nome dell'autore:  ");
                                    elenco[num].autore = Console.ReadLine();
                                    Console.Write("Inserisci il titolo della canzone: ");
                                    elenco[num].titolo = Console.ReadLine();
                                    Console.Write("Inserisci il nome della traccia:  ");
                                    elenco[num].nome = Console.ReadLine() + ".mp3";
                                    Console.Write("Inserisci la durata della traccia:  ");
                                    if (!int.TryParse(Console.ReadLine(), out int durata))
                                    {
                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                        break;
                                    }
                                    if (durata <= 0)
                                    {
                                        Console.WriteLine("La canzone non può durare meno di un secondo ");
                                        break;
                                    }

                                    elenco[num].tempo = durata;
                                    Console.Write("Inserisci il genere della canzone:  ");
                                    elenco[num].genere = Console.ReadLine();

                                    while (a < y)         // Mantieni un elenco di generi
                                    {
                                        if (elenco[num].genere != genere[a])
                                        {
                                            n += 1;
                                        }

                                        a += 1;
                                    }
                                    if (a == n)
                                    {
                                        genere[y] = elenco[num].genere;
                                        y = y + 1;
                                    }

                                    Console.Write("Inserisci il prezzo dei diritti:  ");            //Finisce di inserire i dati
                                    if (!decimal.TryParse(Console.ReadLine(), out decimal prezzo))
                                    {
                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                        break;
                                    }
                                    if (prezzo < 0)
                                    {
                                        Console.WriteLine("Il prezzo non può essere negativo");
                                        break;
                                    }

                                    elenco[num].prezzo = prezzo;

                                    num = num + 1;
                                }

                                Console.WriteLine("Premi un tasto per continuare, 0 per tornare al menù");
                                scelta = Console.ReadKey(true);
                                if (scelta.KeyChar.ToString() == "0")
                                    ripeti = false;
                            }

                            break;
                        }


                    case "2":           //Eleneco
                        {
                            Console.WriteLine("Elenco delle canzoni:\n");

                            while (x < num)
                            {

                                if (elenco[x].codice != default(string))            //Evita che vengano scritte canzoni eliminate, se no vengono scritte
                                {
                                    Console.WriteLine("".PadRight(20, '_'));

                                    Console.WriteLine(elenco[x].codice);
                                    Console.WriteLine($"\nAutore: {elenco[x].autore}");
                                    Console.WriteLine($"Titolo: {elenco[x].titolo}");
                                    Console.WriteLine($"Nome traccia: {elenco[x].nome}");
                                    Console.WriteLine($"Durata traccia: {elenco[x].tempo}");
                                    Console.WriteLine($"Genere canzone: {elenco[x].genere}");
                                    Console.WriteLine($"Prezzo diritti: {elenco[x].prezzo}");
                                }

                                x = x + 1;
                            }

                            break;
                        }


                    case "3":           //Modifica
                        {
                            string cerca = default(string);
                            Console.Write("Inserisci il codice di una canzone:  ");
                            cerca = Console.ReadLine();

                            while (x < num)
                            {
                                Console.Clear();

                                if (string.Compare(cerca, elenco[x].codice) == 0)          //Se trova un prodotto. (cerca == elenco[x].codice)
                                {
                                    do
                                    {
                                        Console.WriteLine("[1] Modifica il codice");
                                        Console.WriteLine("[2] Cambia autore");
                                        Console.WriteLine("[3] Modifica il titolo");
                                        Console.WriteLine("[4] Modifica il nome della traccia");
                                        Console.WriteLine("[5] Cambia la durata");
                                        Console.WriteLine("[6] Cambia il genere");
                                        Console.WriteLine("[7] Modifica il prezzo\n");
                                        Console.WriteLine("[0] Torna al menù");

                                        scelta = Console.ReadKey();

                                        switch (scelta.KeyChar.ToString())
                                        {
                                            case "1":           //Cambia il titolo
                                                {
                                                    Console.Write($"Inserisci il nuovo codice, prima era {elenco[x].codice}:  ");
                                                    if (String.IsNullOrWhiteSpace(elenco[num].codice) == true)          //Controlla che il codice non sia vuoto
                                                    {
                                                        Console.WriteLine("Devi inserire il codice");
                                                        break;
                                                    }


                                                    while (x < num)         // Controlla che il codice non sia già stato usato  
                                                    {

                                                        if (elenco[x].codice == elenco[num].codice)
                                                        {
                                                            Console.WriteLine($"Hai già usato questo codice per la canzone {elenco[x].titolo}");
                                                            break;
                                                        }

                                                        x = x + 1;
                                                    }
                                                    break;
                                                }

                                            case "2":           //Cambia l'autore
                                                {
                                                    Console.Write($"Inserisci il nome dell'autore, prima era {elenco[x].autore}:  ");
                                                    elenco[x].autore = Console.ReadLine();
                                                    break;
                                                }

                                            case "3":           //Cambia il titolo della canzone
                                                {
                                                    Console.Write($"Inserisci il titolo della canzone, prima era {elenco[x].titolo}:  ");
                                                    elenco[x].titolo = Console.ReadLine();
                                                    break;
                                                }

                                            case "4":           //Cambia il nome della traccia
                                                {
                                                    Console.Write($"Inserisci il nome della traccia, prima era {elenco[x].nome}:  ");
                                                    elenco[x].nome = Console.ReadLine() + ".mp3";
                                                    break;
                                                }

                                            case "5":           //Cambia la durata della canzone
                                                {
                                                    Console.Write($"Inserisci la durata della traccia, prima era {elenco[x].tempo}:  ");
                                                    if (!int.TryParse(Console.ReadLine(), out int durata))          //Constrolla se sia un intero
                                                    {
                                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                                        break;
                                                    }
                                                    if (durata <= 0)            //Controlla che tempo sia positivo
                                                    {
                                                        Console.WriteLine("La canzone non può durare meno di un secondo ");
                                                        break;
                                                    }
                                                    elenco[num].tempo = durata;
                                                    break;
                                                }

                                            case "6":           //Cambia il genere
                                                {
                                                    Console.Write($"Inserisci il genere della canzone, prima era {elenco[x].genere}:  ");
                                                    elenco[x].genere = Console.ReadLine();

                                                    break;
                                                }

                                            case "7":           //Cambia il prezzo dei diritti
                                                {
                                                    Console.Write($"Inserisci il prezzo dei diritti, prima era {elenco[x].prezzo}:  ");
                                                    if (!decimal.TryParse(Console.ReadLine(), out decimal prezzo))          //Controlla che il prezzo inserito sia un decimal
                                                    {
                                                        Console.WriteLine("Errore, non hai inserito un prezzo numerico");
                                                        break;
                                                    }
                                                    else if (prezzo < 0)            //Controlla che il prezzo non sia negativo
                                                    {
                                                        Console.WriteLine("Il prezzo non può essere negativo");
                                                        break;
                                                    }
                                                    else
                                                        elenco[num].prezzo = prezzo;
                                                    break;
                                                }

                                            case "0":
                                                { break; }

                                            default:            //Default
                                                {
                                                    Console.WriteLine("Comando errato");

                                                    break;
                                                }

                                        }

                                        Console.Write("Traccia modificata correttamente!");

                                    } while (scelta.KeyChar.ToString() != "0");

                                    break;
                                }

                                else
                                    Console.WriteLine("Nessuna traccia trovata");

                                x = x + 1;
                            }

                            break;
                        }


                    case "4":           //Elimina
                        {
                            string cerca = default(string);

                            Console.Write("Inserisci il codice di una canzone:  ");
                            cerca = Console.ReadLine();

                            while (x < num)         //Se lo trova esce per un break (riga 443)
                            {
                                Console.Clear();

                                if (cerca == elenco[x].codice)          //Quando trova la sovrascrive con quella in ultima posizione
                                {
                                    elenco[x] = default;

                                    Console.Write("Traccia eliminata correttamente!");
                                    num = num - 1;

                                    break;
                                }

                                else            //Se non lo trova lo scrive, poi lo cancella in riga 434
                                    Console.WriteLine($"Traccia {cerca} non trovata");

                                x = x + 1;
                            }

                            break;
                        }


                    case "5":           //Media
                        {
                            //Contatori
                            int c = 0;
                            int n = 0;

                            string categoria = default(String);
                            decimal somma = default(decimal);           //Accumulatore
                            decimal media = default(decimal);

                            Console.WriteLine("Scegli una categoria tra:");
                            while (c < y)           //Elenca tutte le categorie
                            {
                                Console.WriteLine(genere[c]);

                                c += 1;
                            }

                            categoria = Console.ReadLine();     //Scegli una categoria
                            Console.Clear();

                            while (x < num)
                            {
                                if (string.Compare(elenco[x].genere, categoria) == 0)          //elenco[x].genere == categoria
                                {
                                    somma = somma + elenco[x].prezzo;
                                    n = n + 1;
                                }

                                x = x + 1;
                            }

                            if (n == 0)         //Controlla che la categoria esista
                                Console.WriteLine("La categoria selezionata non esiste!");

                            else        //Media
                            {
                                media = somma / n;
                                Console.WriteLine($"La media delle canzoni {categoria} è {media}");
                            }

                            break;
                        }


                    case "6":           //Prezzo più alto
                        {
                            decimal pre = default;          //Contiene il prezzo più alto al momento
                            int b = 0;
                            x = 0;

                            while (x < num)
                            {
                                if (pre < elenco[x].prezzo)         //Controlla se il prezzo è minore lo aggiorna
                                {
                                    pre = elenco[x].prezzo;
                                    b = x;          //numero del prodotto con prezzo maggiore
                                }

                                x = x + 1;
                            }

                            Console.WriteLine($"La canzone con il prezzo più alto è {elenco[b].nome} che costa {pre}");

                            break;
                        }


                    case "7":           //Raggruppa canzoni in una playlist
                        {
                            {
                                Console.Write("Inserisci il titolo della playlist: ");
                                playlist[p].nom = Console.ReadLine();

                                playlist[p].eleCanzoni = new Canzone[30];
                                int h = 0;

                                bool ripeti = true;

                                while (ripeti)
                                {
                                    x = 0;
                                    string cerca = default(string);
                                    Console.Write("Inserisci il codice di una canzone da aggiungere:  ");
                                    cerca = Console.ReadLine();

                                    while (x < num)
                                    {
                                        Console.Clear();

                                        if (cerca == elenco[x].codice)
                                        {
                                            playlist[p].eleCanzoni[h] = elenco[x];
                                            Console.WriteLine($"{elenco[x].nome} aggiunta correttamente");

                                            h = h + 1;

                                            break;
                                        }

                                        else
                                            Console.WriteLine("Nessuna traccia trovata");

                                        x = x + 1;
                                    }

                                    Console.WriteLine("Premi un tasto per continuare, 0 per tornare al menù");
                                    scelta = Console.ReadKey(true);
                                    if (scelta.KeyChar.ToString() == "0")
                                    {
                                        ripeti = false;
                                        p = p + 1;
                                    }


                                }

                                break;
                            }
                        }


                    case "8":           //visualizza i nomi delle tracce di una playlist
                        {
                            Console.Write("Inserisci il nome della playlist:");
                            string nome = Console.ReadLine();
                            int b = 0;

                            while (x < p)
                            {
                                Console.Clear();

                                if (playlist[x].nom == nome)
                                {
                                    Console.WriteLine($"La playlist {nome} contiene: ");
                                    while (b < 30)
                                    {
                                        if (playlist[x].eleCanzoni[b].codice != default)
                                            Console.WriteLine($"{b + 1}){playlist[x].eleCanzoni[b].titolo} di {playlist[x].eleCanzoni[b].autore}");

                                        b = b + 1;
                                    }

                                }

                                x = x + 1;
                            }

                            if (b == 0)
                            {
                                Console.WriteLine("Nessuna playlist trovata");
                            }

                            break;
                        }


                    case "9":           //Modifica playlist
                        {

                            Console.Write("Inserisci il nome della playlist:");
                            string nome = Console.ReadLine();

                            while (x < p)
                            {
                                Console.Clear();

                                if (playlist[x].nom == nome)
                                {
                                    int a = 0;          //Contatore
                                    int f = 0;          //Numero di canzoni nella playlist
                                    while (a < 30)          //Trova quante 
                                    {
                                        if (playlist[x].eleCanzoni[a].codice != default)
                                            f = f + 1;

                                        a = a + 1;
                                    }

                                    do
                                    {
                                        Console.WriteLine($"Playlist {nome} trovata");
                                        Console.WriteLine("".PadRight(30, '_'));
                                        Console.WriteLine("[1] Aggiungi una canzone");
                                        Console.WriteLine("[2] Elimina una canzone da una playlist\n");
                                        Console.WriteLine("[0] Torna al menù");

                                        scelta = Console.ReadKey(true);

                                        switch (scelta.KeyChar.ToString())
                                        {
                                            case "1":           //Aggiunge una canzone
                                                {
                                                    int b = 0;          //Constatore
                                                    string cerca = default(string);
                                                    Console.Write("Inserisci il codice di una canzone da aggiungere:  ");
                                                    cerca = Console.ReadLine();

                                                    while (b < num)
                                                    {
                                                        Console.Clear();

                                                        if (cerca == elenco[b].codice)
                                                        {
                                                            playlist[x].eleCanzoni[f] = elenco[b];
                                                            Console.WriteLine("Canzone aggiunta correttamente");

                                                            f = f + 1;

                                                            break;
                                                        }

                                                        else
                                                            Console.WriteLine("Nessuna traccia trovata");

                                                        b = b + 1;
                                                    }

                                                    break;
                                                }


                                            case "2":           //Cancella una canzone
                                                {
                                                    int b = 0;          //Constatore
                                                    string cerca = default(string);
                                                    Console.Write("Inserisci il codice di una canzone da eliminare:  ");
                                                    cerca = Console.ReadLine();

                                                    while (b < num)
                                                    {
                                                        Console.Clear();

                                                        if (cerca == playlist[x].eleCanzoni[b].codice)
                                                        {
                                                            playlist[x].eleCanzoni[b] = playlist[x].eleCanzoni[f - 1];
                                                            Console.WriteLine("Canzone eliminata correttamente");

                                                            f = f - 1;

                                                            break;
                                                        }

                                                        else
                                                            Console.WriteLine("Nessuna traccia trovata");

                                                        b = b + 1;
                                                    }

                                                    break;
                                                }

                                            case "0":
                                                {
                                                    break;
                                                }

                                            default:
                                                {
                                                    Console.WriteLine("Comando errato");

                                                    break;
                                                }
                                        }

                                    } while (scelta.KeyChar.ToString() != "0");

                                    break;
                                }

                                x = x + 1;
                            }


                            break;
                        }


                    case "u":           //Non fa niente
                        {
                            break;
                        }


                    default:            //Default
                        {
                            Console.WriteLine("Comando errato");

                            break;
                        }

                }

                if (scelta.KeyChar.ToString() != "0" && scelta.KeyChar.ToString() != "u")
                {
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey(true);
                }           //Premi un tasto per continuare

            } while (scelta.KeyChar.ToString() != "u");
        }
    }
}

using System;
namespace ProvaVerifica1
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

        static void Main(string[] args)
        {           
            //Varaibili
            Canzone[] elenco = new Canzone[100];            //Contiene tutte le canzoni
            int num = 0;        //Numero di canzoni
            ConsoleKeyInfo scelta = default(ConsoleKeyInfo);
            string[] genere = new string[30];           //Contiene i generi
            int y = 0;          //Numero di generi


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
                Console.WriteLine("[5] Cancella una categoria");
                Console.WriteLine("[6] Calcola la media di prezzo di un genere");
                Console.WriteLine("[7] Prodotto più costoso");
                Console.WriteLine("[8] Prodotto più costoso\n");

                Console.WriteLine("[U] Esci");

                scelta = Console.ReadKey(true);

                Console.Clear();
                switch(scelta.KeyChar.ToString())
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
                               
                                    while (a<y)         // Mantieni un elenco di generi
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

                            while(x < num)
                            {
                                Console.Clear();

                                if (string.Compare(cerca, elenco[x].codice)==0)          //Se trova un prodotto. (cerca == elenco[x].codice)
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

                                        switch(scelta.KeyChar.ToString())
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
                                                    int a = 0;
                                                    int n = 0;
                                                    
                                                    Console.Write($"Inserisci il genere della canzone, prima era {elenco[x].genere}:  ");
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
                                        elenco[x] = elenco[num-1];
                                
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
                            int nc = 0;

                            string categoria = default(String);

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
                                    elenco[x] = elenco[num - 1];
                                    num = num - 1;
                                    nc += 1;
                                }
                                else
                                x = x + 1;
                            }

                            if (nc == 0)         //Controlla che la categoria esista
                                Console.WriteLine("La categoria selezionata non esiste!");

                            if (nc >0)
                            {                             
                                Console.WriteLine($"{nc} prodotti eliminati correttamente");

                                x = 0;
                                while (x<y)
                                {
                                    if (genere[x] == categoria)
                                    {
                                        genere[x] = genere[y - 1];
                                        break;
                                    }
                                    x += 1;
                                }
                            }

                            break;
                        }


                    case "6":           //Media
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
                                if (string.Compare(elenco[x].genere,categoria) ==0)          //elenco[x].genere == categoria
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


                    case "7":           //Prezzo più alto
                        {
                            decimal pre = default;          //Contiene il prezzo più alto al momento
                            int b = 0;
                            x = 0;

                            while (x<num)
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


                    case "8":           //Prezzo più basso
                        {
                            decimal pre = elenco[x].prezzo;
                            int b = 0;

                            while (x < num)
                            {
                                if (pre > elenco[x].prezzo)         //Controlla se il prezzo è minore lo aggiorna
                                {
                                    pre = elenco[x].prezzo;
                                    b = x;          //numero del prodotto con prezzo maggiore
                                }

                                x = x + 1;
                            } 

                                Console.WriteLine($"La canzone con il prezzo più basso è {elenco[b].nome} che costa {pre}");

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

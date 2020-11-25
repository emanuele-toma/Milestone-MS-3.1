using System;

namespace Esercizio_traccia_audio
{
    class Program
    {
        public struct Traccia
        {
            public string codice;
            public string titolo;
            public string nomeFile;
            public int durata;
            public string genere;
            public decimal prezzo;
        }

        static void Main()
        {
            Traccia[] listaTracce = new Traccia[1000];
            int num = default;
            bool quit = default;

            num = 0;
            listaTracce[num].codice = "tr1";
            listaTracce[num].titolo = "traccia1";
            listaTracce[num].nomeFile = "traccia1.mp4";
            listaTracce[num].durata = 50;
            listaTracce[num].genere = "rock";
            listaTracce[num].prezzo = 400;
            num++;
            listaTracce[num].codice = "tr2";
            listaTracce[num].titolo = "traccia2";
            listaTracce[num].nomeFile = "traccia2.mp4";
            listaTracce[num].durata = 90;
            listaTracce[num].genere = "rock";
            listaTracce[num].prezzo = 100;
            num++;
            listaTracce[num].codice = "tr3";
            listaTracce[num].titolo = "traccia3";
            listaTracce[num].nomeFile = "traccia3.mp4";
            listaTracce[num].durata = 300;
            listaTracce[num].genere = "pop";
            listaTracce[num].prezzo = 1000;
            num++;
            listaTracce[num].codice = "tr4";
            listaTracce[num].titolo = "traccia4";
            listaTracce[num].nomeFile = "traccia4.mp4";
            listaTracce[num].durata = 20;
            listaTracce[num].genere = "pop";
            listaTracce[num].prezzo = 400;
            num++;

            do
            {
                int scelta = default;

                Console.Clear();
                Console.WriteLine("################################");
                Console.WriteLine("#             Menù             #");
                Console.WriteLine("################################");
                Console.WriteLine("#                              #");
                Console.WriteLine("# 1) Aggiungi traccia          #");
                Console.WriteLine("# 2) Modifica traccia          #");
                Console.WriteLine("# 3) Mostra tracce             #");
                Console.WriteLine("# 4) Cancella tracce           #");
                Console.WriteLine("# 5) Prezzo medio tracce       #");
                Console.WriteLine("#                              #");
                Console.WriteLine("################################");
                Console.WriteLine("#  0) Esci                     #");
                Console.WriteLine("################################");
                scelta = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                Console.Clear();

                switch (scelta)
                {
                    case 0:
                        {
                            quit = true;
                            break;
                        }
                    case 1:
                        {
                            do
                            {
                                string codice = default;
                                int x = default;
                                bool trovato = default;

                                Console.WriteLine("################################");
                                Console.Write("Codice traccia: ");
                                codice = Console.ReadLine();

                                while (x < num)
                                {
                                    if (listaTracce[x].codice == codice)
                                    {
                                        trovato = true;
                                        Console.WriteLine("Questo codice è già stato utilizzato");
                                        break;
                                    }
                                    x++;
                                }
                                if (trovato) break;

                                Console.Write("Titolo traccia: ");
                                listaTracce[num].titolo = Console.ReadLine();
                                Console.Write("Nome file traccia: ");
                                listaTracce[num].nomeFile = Console.ReadLine();
                                Console.Write("Durata traccia in secondi: ");
                                listaTracce[num].durata = int.Parse(Console.ReadLine());
                                Console.Write("Genere traccia: ");
                                listaTracce[num].genere = Console.ReadLine();
                                Console.Write("Prezzo traccia: ");
                                listaTracce[num].prezzo = Decimal.Parse(Console.ReadLine());
                                Console.WriteLine("################################");
                                num++;
                                Console.WriteLine("Aggiungere un altra traccia? [S/N]");
                            } while (Console.ReadKey(true).KeyChar == 's');
                            break;
                        }
                    case 2:
                        {
                            string inputStr = default;
                            int x = default;
                            bool trovato = default;
                            Console.Write("Inserisci il codice della traccia da modificare: ");
                            inputStr = Console.ReadLine();
                            while (x < num && !trovato)
                            {
                                if (listaTracce[x].codice == inputStr)
                                {
                                    trovato = true;
                                    break;
                                }
                                x++;
                            }

                            if (trovato)
                            {
                                Console.WriteLine("################################");
                                Console.WriteLine($"Codice: {listaTracce[x].codice}");
                                Console.WriteLine($"Titolo: {listaTracce[x].titolo}");
                                Console.WriteLine($"File  : {listaTracce[x].nomeFile}");
                                Console.WriteLine($"Durata: {listaTracce[x].durata}");
                                Console.WriteLine($"Genere: {listaTracce[x].genere}");
                                Console.WriteLine($"Prezzo: {listaTracce[x].prezzo}");
                                Console.WriteLine("################################");
                                Console.WriteLine("Vuoi modificare questa traccia? [S/N]");
                                if (Console.ReadKey(true).KeyChar == 's')
                                {
                                    Console.WriteLine("################################");
                                    Console.Write("Codice: ");
                                    listaTracce[x].codice = Console.ReadLine();
                                    Console.Write("Titolo: ");
                                    listaTracce[x].titolo = Console.ReadLine();
                                    Console.Write("File  : ");
                                    listaTracce[x].nomeFile = Console.ReadLine();
                                    Console.Write("Durata: ");
                                    listaTracce[x].durata = int.Parse(Console.ReadLine());
                                    Console.Write("Genere: ");
                                    listaTracce[x].genere = Console.ReadLine();
                                    Console.Write("Prezzo: ");
                                    listaTracce[x].prezzo = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("################################");
                                    Console.WriteLine("Traccia modificata con successo");
                                    break;
                                }
                            }
                            Console.WriteLine("Nessuna traccia trovata con codice " + inputStr);
                            break;
                        }
                    case 3:
                        {
                            int x = default;
                            while (x < num)
                            {
                                Console.WriteLine("################################");
                                Console.WriteLine($"Codice: {listaTracce[x].codice}");
                                Console.WriteLine($"Titolo: {listaTracce[x].titolo}");
                                Console.WriteLine($"Durata: {listaTracce[x].durata} secondi");
                                Console.WriteLine($"Prezzo: {listaTracce[x].prezzo} euro");
                                x++;
                            }
                            Console.WriteLine("################################");
                            break;
                        }
                    case 4:
                        {
                            int inputInt = default, x = default;
                            Console.Write("Cancellazione tracce, inserisci la durata minima delle tracce: ");
                            inputInt = int.Parse(Console.ReadLine());
                            while (x < num)
                            {
                                if (listaTracce[x].durata < inputInt)
                                {
                                    listaTracce[x] = listaTracce[num-1];
                                    num--;
                                }
                                x++;
                            }
                            Console.WriteLine("Cancellate tutte le tracce con durata inferiore a " + inputInt + " secondi");
                            break;
                        }
                    case 5:
                        {
                            string inputStr = default;
                            int x = default, y = default;
                            decimal media = default;
                            Console.Write("Inserisci la categoria delle tracce per cui calcolare la media: ");
                            inputStr = Console.ReadLine();
                            while (x < num)
                            {
                                if (listaTracce[x].genere == inputStr)
                                {
                                    media += listaTracce[x].prezzo;
                                    y++;
                                }
                                x++;
                            }

                            if (y == 0)
                            {
                                Console.WriteLine("Nessuna traccia trovata...");
                                break;
                            }
                            media /= y;
                            Console.WriteLine($"La media dei prezzi delle tracce nella categoria {inputStr} è di {media} euro");
                            break;
                        }
                }
                if (!quit)
                {
                    Console.Write("\nPremi un tasto per tornare al menù...");
                    Console.ReadKey();
                }

            } while (!quit);
        }
    }
}

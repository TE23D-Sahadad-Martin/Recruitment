

        string[] potentiellaRekryter = { "Anna", "Erik", "Maria", "David", "Sara", "Omar", "Lisa" };
        string[] rekryter = new string[3]; 

        int rekryteradeAntal = 0; 


        while (rekryteradeAntal < 3)
        {

            System.Console.WriteLine("Potentiella rekryter:");
            for (int i = 0; i < potentiellaRekryter.Length; i++)
            {
                if (potentiellaRekryter[i] != null)
                {
                    System.Console.WriteLine((i + 1) + ". " + potentiellaRekryter[i]);
                }
            }


            System.Console.WriteLine("\nAnge numret på personen du vill rekrytera:");
            int val = int.Parse(System.Console.ReadLine()) - 1;


            if (val >= 0 && val < potentiellaRekryter.Length && potentiellaRekryter[val] != null)
            {
                rekryter[rekryteradeAntal] = potentiellaRekryter[val];
                potentiellaRekryter[val] = null; 
                rekryteradeAntal++;

                System.Console.WriteLine("Du har rekryterat: " + rekryter[rekryteradeAntal - 1]);
            }
            else
            {
                System.Console.WriteLine("Ogiltigt val, försök igen.");
            }


            System.Console.WriteLine("\nRekryterade personer:");
            for (int i = 0; i < rekryteradeAntal; i++)
            {
                System.Console.WriteLine(rekryter[i]);
            }

            System.Console.WriteLine("\n");
        }

        System.Console.WriteLine("Du har rekryterat tre personer!");
        Console.ReadLine(); 
    



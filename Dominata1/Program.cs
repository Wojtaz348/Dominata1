using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj rozmiar listy:");
        int rozmiar = Convert.ToInt32(Console.ReadLine());
        List<int> lista = GenerujListe(rozmiar);

        Console.WriteLine("Dominanta listy:");
        int dominanta = ZnajdzDominanta(lista);

        Console.WriteLine($"Najczęściej występująca wartość: {dominanta}");

        Console.WriteLine("Wygenerowana lista liczb:");
        lista.ForEach(i => Console.Write(i + " "));
        Console.WriteLine();


    }

    static List<int> GenerujListe(int rozmiar)
    {
        Random random = new Random();
        List<int> lista = new List<int>();
        for (int i = 0; i < rozmiar; i++)
        {
            lista.Add(random.Next(1, 100));
        }
        return lista;
    }

    static int ZnajdzDominanta(List<int> lista)
    {
        if (lista == null || lista.Count == 0) return -1;

        int maxWystapienia = 0;
        int dominanta = lista[0];
        foreach (int element in lista)
        {
            int wystapienia = -1;
            foreach (int el in lista)
            {
                if (el == element) wystapienia++;
            }

            if (wystapienia > maxWystapienia)
            {
                maxWystapienia = wystapienia;
                dominanta = element;
            }
        }

        return dominanta;
    }
}




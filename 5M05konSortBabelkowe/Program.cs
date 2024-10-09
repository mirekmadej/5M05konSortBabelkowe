namespace _5M05konSortBabelkowe
{
    internal class Program
    {
        public static void wypiszTablice(int[] tablica)
        {
            foreach (int i in tablica)
                Console.Write($"{i}, ");
            Console.WriteLine();
        }
        public static void sortuj(int[] tab)
        {
            for(int j = 0; j < tab.Length; j++)
                for(int i = 0; i < tab.Length - 1 - j; i++)
                    if (tab[i] > tab[i+1])
                    {
                        int t = tab[i];
                        tab[i] = tab[i+1];
                        tab[i+1] = t;
                    }
        }
        static void Main(string[] args)
        {
            const int N = 100;
            int[] tablica = new int[N];


            Console.WriteLine("Program sortujący tablicę metodą babelkową");
            Console.WriteLine("podaj największą liczbę w tablicy: ");
            int maks = int.Parse(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < N; i++)
                tablica[i] = random.Next(0, maks + 1);
           
            Console.WriteLine("tablica nieposortowana:");
            wypiszTablice(tablica);
            Console.WriteLine("tablica posortowana:");
            sortuj(tablica);
            wypiszTablice(tablica);

        }
    }
}

using System;


namespace Algorithms
{   
    public class Program
    {
        public static void Main(string[] ags)
        {
            int[] array = { 1, 10, 30, 25, 400, 50, 11, 2, 0, 25 };

            Sort.Insertion(array);

            var index = Search.Binary(array, 10);

            Console.WriteLine(index);
        }
    }
}
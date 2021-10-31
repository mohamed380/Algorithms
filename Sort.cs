using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sort
    {
        public static void InsertionV1 (int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var j = i;

                for (int c = j-1; c >= 0; c--) 
                {
                    if(array[j] < array[c])
                    {
                        var temp = array[c];
                        array[c] = array[j]; 
                        array[j] = temp;
                        j--;
                    }
                }
            }
        }

        public static void Insertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var j = i - 1;
                var key = array[i];

                while (j >= 0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j--;
                }

                array[j+1] = key;
            }
        }


    }
}

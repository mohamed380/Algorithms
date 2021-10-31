using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Search
    {
       public static int Binary(int[] list, int needle)
        {
            var count = list.Length;
            var min = 0;
            var max = count - 1;
            var mid = 0;

            while (min <= max)
            {
                mid = (int) ( (max + min) / 2 );
                
                
                if ( list[mid] == needle )
                {
                    return mid;
                }

                if (list[mid] > needle)
                {
                    max = mid - 1; 
                }

               
                else{
                    min = mid + 1;
                }

            }

            return -1;
        }
    }
}

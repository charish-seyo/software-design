using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Order_Descending
{
    public class Sorter
    {
        private int[] numbers;
        public Sorter(int[] inputNumbers)
        {
            numbers = inputNumbers;
        }

        public void SortDescending()
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1]) 
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
        private void Swap(int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        public int[] GetSortedArray()
        {
            return numbers;
        }
    }
}

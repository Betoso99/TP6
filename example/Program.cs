using System;
using System.Linq;

namespace example
{
	class Program
	{
		static void Main(string[] args)
		{
            int[] array = new int[] { -1, 2, 3, -4, 5, 10 };

            array = MaxSuma(b);
            Console.WriteLine("The maximun sub array sum is: {0} \n" +
                              "The maximun subseuence sum is: {1}", array[0],array[1]);
        }
		
		static int[] MaxSuma(int[] arr)
		{
            int[] ArrSuma = new int[2];
            int max = arr[0];
            int current = max;

            for (int i = 1; i < arr.Length; i++)
            {
				if (arr[i] + current > arr[i])
				{
                    current = arr[i] + current;
                }
				else
				{
                    current = arr[i];
                }

                if (max < current)
				{
                    max = current;
                }
            }

            ArrSuma[0] = max;
            Array.Sort(arr);
            max = arr[0];
            current = max;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] + current > arr[i])
                {
                    current = arr[i] + current;
                }
                else
                {
                    current = arr[i];
                }

                if (max < current)
                {
                    max = current;
                }
            }
            
            ArrSuma[1] = max;
            return ArrSuma;
        }
    }
}

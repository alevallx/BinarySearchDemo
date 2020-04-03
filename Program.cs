using System;
using System.Diagnostics;
using System.Timers;

namespace BuscarNroEnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Posicion :"  + RetornaIndice(65));
        }

        static int RetornaIndice(int nroABuscar)
        {

            int[] arrNros = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arrNros[i] = i;
            }

            return BinarySearch(arrNros,nroABuscar);

        }

        static int BinarySearch(int[] arr , int val)
        {
            int ini = 0;
            int end = arr.Length - 1;

            while (ini <= end)
            {
                int mid = (ini + end) / 2;
                if (arr[mid] == val)
                {
                    return mid;
                }
                else if (val > arr[mid])
                {
                    ini = mid + 1;
                }
                else
                    end = mid - 1;

            }
            return -1;
        }
    }
}

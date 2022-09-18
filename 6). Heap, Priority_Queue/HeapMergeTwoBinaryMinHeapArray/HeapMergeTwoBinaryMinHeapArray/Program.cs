using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapMergeTwoBinaryMinHeapArray
{
    class Program
    {
        void swap(int[] arr, int first, int second)
        {
            int auxiliary = arr[first];
            arr[first] = arr[second];
            arr[second] = auxiliary;
        }
		int compare(int[] arr, int left, int right, int root, int size)
		{
			int location = -1;

			if (left < size && arr[left] < arr[root])
			{

				if (right < size && arr[right] < arr[left])
				{
					swap(arr, right, root);
					location = right;
				}
				else
				{
					swap(arr, left, root);
					location = left;
				}
			}
			else if (right < size && arr[right] < arr[root])
			{
				swap(arr, right, root);
				location = right;
			}
			return location;
		}
		void heap(int[] arr, int size, int root)
		{
			int left = 2 * root + 1;
			int right = 2 * root + 2;

			int next = compare(arr, left, right, root, size);

			if (next != -1)
			{
				heap(arr, size, next);
			}
		}
		void printData(int[] arr, int size)
		{
			Console.Write("\n");
			for (int i = 0; i < size; i++)
			{
				Console.Write("  " + arr[i] + " ");
			}
		}
		void merge(int[] arr, int size)
		{
			for (int i = (size / 2) - 1; i >= 0; i--)
			{
				heap(arr, size, i);
			}
		}

		static void Main(string[] args)
        {
			Program p = new Program();

			int[] heap1 = { 1, 5, 6, 9, 7, 8, 10 };
			int[] heap2 = { 3, 4, 5, 11 };

			int n = heap1.Length;
			int m = heap2.Length;

			int[] combine = new int[n + m];

			for (int i = 0; i < n; ++i)
			{
				combine[i] = heap1[i];
			}

			for (int i = 0; i < m; ++i)
			{
				combine[n + i] = heap2[i];
			}

			p.merge(combine, n+m);

			p.printData(combine, n+m);
		}
	}
}

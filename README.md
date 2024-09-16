# Questions on Arrays and Strings

## 1). Arrays
### Easy
1.1 Merge two sorted arrays 
[GeeksforGeeks](https://www.geeksforgeeks.org/merge-two-sorted-arrays/)

```csharp
using System;

public class GfG {

    // Merge ar1[0..n1-1] and ar2[0..n2-1] into ar3
    public static void MergeArrays(int[] ar1, int[] ar2, int[] ar3) {
        int i = 0, j = 0, k = 0;
        int n1 = ar1.Length;
        int n2 = ar2.Length;

        while (i < n1 && j < n2) {
          
            // Pick smaller of the two current elements and move ahead in the array of the picked element
            if (ar1[i] < ar2[j])
                ar3[k++] = ar1[i++];
            else
                ar3[k++] = ar2[j++];
        }

        // if there are remaining elements of the first array, move them
        while (i < n1)
            ar3[k++] = ar1[i++];

        // Else if there are remaining elements of the second array, move them
        while (j < n2)
            ar3[k++] = ar2[j++];
    }

    // Driver code
    public static void Main() {
        int[] ar1 = {1, 3, 5, 7};
        int[] ar2 = {2, 4, 6, 8};
        int[] ar3 = new int[ar1.Length + ar2.Length];

        MergeArrays(ar1, ar2, ar3);

        foreach (int value in ar3)
            Console.Write(value + " ");
    }
}
```

1.2 Remove duplicates from an array
Text guide (Javarevisted)


1.3 Count the frequency of an element in an array
Text guide (GeeksforGeeks)


1.4 Two sum
Text guide (Codeburst)


1.5 Find the minimum (or maximum) element of an array
Text guide (Enjoy Algorithms)


1.6 Remove duplicates from sorted array
Text guide (Redquark)


1.7 Remove element in-place
Text guide (Redquark)


1.8 Search Insert Position
Text guide (GeeksforGeeks)


1.9 Maximum Subarray
Text guide (Wikipedia)


1.10 Plus One
Text guide (Medium/Punitkmryh)


1.11 Convert Sorted Array to Binary Search Tree (Arrays/Binary Trees)
Text guide (GeeksForGeeks)


1.12 Single Number
Text guide (Akhilpokle)


1.13 Count Primes
Text guide (GeeksForGeeks)


1.14 Contains Duplicate
Text guide (Medium/Punitkmryh)


1.15 Third Largest Number
Text guide (GeeksForGeeks)


1.16 Count Odd Even
Text guide (GeeksForGeeks)


### Medium
### Hard

## 2). Strings

### Easy


### Medium
### Hard


## Problems will come on these topics also
**Sorting, Searching, Two Pointers, Sliding Window, Top 'k' elements in Array, Backtracking, Divide and Conquer, List, Dictionary and HashSet**

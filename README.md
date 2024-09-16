# Questions on Arrays and Strings

## 1). Arrays
### Easy
**1.1 Merge two sorted arrays.** 
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

**1.2 Remove duplicates from an array.** 
[Leetcode](https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/) , 
[geeksforgeeks](https://www.geeksforgeeks.org/remove-duplicates-sorted-array/)

```csharp
// simple C# program to remove duplicates
using System;

class GfG {
    
    // Function to remove duplicate
    // elements This function returns 
    // new size of modified array.
    static int removeDuplicates(int []arr, int n)
    {
        
        if (n == 0 || n == 1)
            return n;
    
        // To store index of next
        // unique element
        int j = 0;

        // Maintaining another updated
        // index i.e. j
        for (int i = 0; i < n - 1; i++)
            if (arr[i] != arr[i + 1])
                arr[j++] = arr[i];
    
        arr[j++] = arr[n - 1];
    
        return j;
    }
    
    // Driver code
    public static void Main () 
    {
        int []arr = {1, 2, 2, 3, 4, 4,
                                 4, 5, 5};
        int n = arr.Length;
        
        n = removeDuplicates(arr, n);

        // Print updated array
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}
```

1.3 Count the frequency of an element in an array
[GeeksforGeeks](https://www.geeksforgeeks.org/counting-frequencies-of-array-elements/)

**Simple Solution**  
```csharp
// C# program to count frequencies of array items
using System;
 
class GFG
{
    public static void countFreq(int []arr, int n)
    {
        bool []visited = new bool[n];
     
        // Traverse through array elements and
        // count frequencies
        for (int i = 0; i < n; i++)
        {
     
            // Skip this element if already processed
            if (visited[i] == true)
                continue;
     
            // Count frequency
            int count = 1;
            for (int j = i + 1; j < n; j++) 
            {
                if (arr[i] == arr[j]) 
                {
                    visited[j] = true;
                    count++;
                }
            }
            Console.WriteLine(arr[i] + " " + count);
        }
    }
     
    // Driver code
    public static void Main(String []args)
    {
        int []arr = new int[]{ 10, 20, 20, 10, 10, 20, 5, 20 };
        int n = arr.Length;
        countFreq(arr, n);
    }
}
```

**Hashing**  

```csharp
// C# implementation of the approach
using System;
using System.Collections.Generic; 
 
class GFG
{
 
    static void countFreq(int []arr, int n)
    {
        Dictionary<int, int> mp = new Dictionary<int,int>();
 
        // Traverse through array elements and
        // count frequencies
        for (int i = 0; i < n; i++)
        {
            if (mp.ContainsKey(arr[i])) 
            {
                var val = mp[arr[i]];
                mp.Remove(arr[i]);
                mp.Add(arr[i], val + 1); 
            } 
            else
            {
                mp.Add(arr[i], 1);
            }
        }
         
        // Traverse through map and print frequencies
        foreach(KeyValuePair<int, int> entry in mp)
        {
            Console.WriteLine(entry.Key + " " + entry.Value);
        }
    }
 
    // Driver code
    public static void Main(String []args) 
    {
        int []arr = {10, 20, 20, 10, 10, 20, 5, 20};
        int n = arr.Length;
        countFreq(arr, n);
    }
}
```


1.4 Two sum
[geeksforgeeks]([Codeburst](https://www.geeksforgeeks.org/check-if-pair-with-given-sum-exists-in-array/))

**Sorting and Binary Search**
```csharp
using System;

class GfG {

    // Function to perform binary search
    static bool BinarySearch(int[] arr, int left, int right,
                             int target){
        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return true;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }

    // Function to check whether any pair exists
    // whose sum is equal to the given target value
    static bool TwoSum(int[] arr, int target){
        // Sort the array
        Array.Sort(arr);

        // Iterate through each element in the array
        for (int i = 0; i < arr.Length; i++) {
            int complement = target - arr[i];

            // Use binary search to find the complement
            if (BinarySearch(arr, i + 1, arr.Length - 1,
                             complement))
                return true;
        }
        // If no pair is found
        return false;
    }

    static void Main(){
        int[] arr = { 0, -1, 2, -3, 1 };
        int target = -2;

        // Call the TwoSum function and print the result
        if (TwoSum(arr, target)) {
            Console.WriteLine("true");
        }
        else {
            Console.WriteLine("false");
        }
    }
}
```

**Sorting and Two-Pointer Technique**
```csharp
using System;
using System.Linq;

class GfG {

    // Function to check whether any pair exists
    // whose sum is equal to the given target value
    static bool TwoSum(int[] arr, int target){
      
        // Sort the array
        Array.Sort(arr);

        int left = 0, right = arr.Length - 1;

        // Iterate while left pointer is less than right
        while (left < right) {
            int sum = arr[left] + arr[right];

            // Check if the sum matches the target
            if (sum == target)
                return true;
            else if (sum < target)
                left++; // Move left pointer to the right
            else
                right--; // Move right pointer to the left
        }
        // If no pair is found
        return false;
    }

    static void Main(){
        int[] arr = { 0, -1, 2, -3, 1 };
        int target = -2;

        // Call the TwoSum function and print the result
        if (TwoSum(arr, target))
            Console.WriteLine("true");
        else 
            Console.WriteLine("false");
    }
}
```

**Hash Set**
```csharp
using System;
using System.Collections.Generic;

class GfG {

    // Function to check whether any pair exists
    // whose sum is equal to the given target value
    static bool TwoSum(int[] arr, int target){

        // Create a HashSet to store the elements
        HashSet<int> set = new HashSet<int>();

        // Iterate through each element in the array
        for (int i = 0; i < arr.Length; i++) {

            // Calculate the complement that added to
            // arr[i], equals the target
            int complement = target - arr[i];

            // Check if the complement exists in the set
            if (set.Contains(complement))
                return true;

            // Add the current element to the set
            set.Add(arr[i]);
        }
        // If no pair is found
        return false;
    }

    static void Main(){
        int[] arr = { 0, -1, 2, -3, 1 };
        int target = -2;

        // Call the TwoSum function and print the result
        if (TwoSum(arr, target))
            Console.WriteLine("true");
        else 
            Console.WriteLine("false"); 
    }
}
```


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

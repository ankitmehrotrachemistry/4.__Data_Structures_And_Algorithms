# Questions on Arrays and Strings

## 1). Arrays

| Arrays Questions |
|----------|
|          |
|   [javarevisited](https://javarevisited.blogspot.com/2015/06/top-20-array-interview-questions-and-answers.html#axzz8mwGpFNbN)  |
|          |
| 1). find the missing number in integer array of 1 to 100 |  
| 2). find duplicate number on Integer array |  
| 3). check if array contains a number | 
| 4). find largest and smallest number in unsorted array | 
| 5). find all pairs on integer array whose sum is equal to given number |  
| 6). find repeated numbers in an array if it contains multiple duplicates |  
| 7). program to remove duplicates from array | 
| 8). sort an array in place using QuickSort algorithm | 
| 9). program to find intersection of two sorted arrays |  
| 10). There is an array with every element repeated twice except one. Find that element |  
| 11). find kth smallest element in unsorted array | 
| 12). find kth largest element in unsorted array | 
| 13). find common elements in three sorted array |  
| 14). find the first repeating element in an array of integers |  
| 15). find first non-repeating element in array of integers | 
| 16). find top two numbers from an integer array | 
| 17). find the smallest positive integer value that cannot be represented as sum of any subset of a given array | 
| 18). rearrange array in alternating positive and negative number | 
| 19). find if there is a sub array with sum equal to zero |  
| 20). Remove duplicates from array in place |  
| 21). remove a given element from array | 
| 22). merge sorted array | 
| 23). find sub array with maximum sum in an array of positive and negative number |  
| 24). find sub array with largest product in array of both positive and negative number |  
| 25). find length of longest consecutive sequence in array of integers | 
| 26). find minimum value in a rotated sorted array | 
| 27). Given an array of of size n and a number k, find all elements that appear more than n/k times | 
| 28). reverse array in place | 
| 29). array and linked list data structure |  
| 30). check if array contains a duplicate number |
|         |

### ============================ javarevisited ============================

#### 1). find the missing number in integer array of 1 to 100

```csharp
using System;

public class Program 
{
    public static int MissingNumber(int n, int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < n - 1; i++) {
            sum += arr[i];
        }

        int expectedSum = (n * (n + 1)) / 2;

        return expectedSum - sum;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 5 };
        int n = 5; 
        Console.WriteLine(MissingNumber(n, arr));
    }
}
```

|----------|
|          |
|  [w3resource](https://www.w3resource.com/java-exercises/array/index.php) |
|          |
| 1). sort a numeric array and a string array. |   
| 2). sum values of an array. |  
| 3). print the following grid. |  
| 4). calculate the average value of array elements |  
| 5). test if an array contains a specific value. |  
| 6). find the index of an array element. |  
| 7). remove a specific element from an array. |  
| 8). copy an array by iterating the array. |  
| 9). insert an element (specific position) into an array. |  
| 10). find the maximum and minimum value of an array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
| 1). sort a numeric array and a string array. |  
|          |
### ============================ w3resource ============================

|----------|
|          |
|  [interviewbit](https://www.interviewbit.com/array-interview-questions/) |
|          |
| 1). Maximum Number in an Array |  
|          |
### ============================ interviewbit ============================

|----------|
|          |
|   [igotanoffer](https://igotanoffer.com/blogs/tech/array-interview-questions)  |
|          |
| 1). Merge two sorted arrays | 
| 2). Maximum Number in an Array |  
| 3). Reverse an Array | 
| 4). Sum of all elements of an array |
|          |
### ============================ igotanoffer ============================

#### A). EASY

#### 1.1 Merge two sorted arrays.
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

#### 1.2 Remove duplicates from an array.
[Leetcode](https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/) , 
[geeksforgeeks](https://www.geeksforgeeks.org/remove-duplicates-sorted-array/)

```csharp
// simple C# program to remove duplicates
using System;

class GfG {

    // This function returns new size of modified array.
    static int removeDuplicates(int []arr, int n)
    {        
        if (n == 0 || n == 1)
            return n;
    
        // To store index of next unique element
        int j = 0;

        for (int i = 0; i < n - 1; i++)
            if (arr[i] != arr[i + 1])
                arr[j++] = arr[i];
    
        arr[j++] = arr[n - 1];
    
        return j;
    }
 
    public static void Main () 
    {
        int []arr = {1, 2, 2, 3, 4, 4, 4, 5, 5};
        int n = arr.Length;
        
        n = removeDuplicates(arr, n);

        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}
```

#### 1.3 Count the frequency of an element in an array
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


#### 1.4 Two sum
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


#### 1.5 Find the minimum (or maximum) element of an array
Text guide (Enjoy Algorithms)


#### 1.6 Remove duplicates from sorted array
**Brute Force (HashSet)**

```csharp
using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 1, 2, 2, 2, 3, 3 };
        int k = RemoveDuplicates(arr);
        Console.WriteLine("The array after removing duplicate elements is:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static int RemoveDuplicates(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            set.Add(arr[i]);
        }

        int k = set.Count;
        int j = 0;
        foreach (int x in set)
        {
            arr[j++] = x;
        }
        return k;
    }
}
```

**Two pointers**
 We can think of using two pointers ‘i’ and ‘j’, we move ‘j’ till we don't get a number arr[j] which is different from arr[i]. As we got a unique number we will increase the i pointer and update its value by arr[j]. 

<p align="center">
  <img src="https://github.com/user-attachments/assets/29acbe65-9032-4487-b513-12a2d4871957" width="600" height="450" />
</p>

```csharp
using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 1, 2, 2, 2, 3, 3 };
        int k = RemoveDuplicates(arr);
        Console.WriteLine("The array after removing duplicate elements is:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static int RemoveDuplicates(int[] arr)
    {
        int i = 0;
        for (int j = 1; j < arr.Length; j++)
        {
            if (arr[i] != arr[j])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        return i + 1;
    }
}
```

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


#### B). MEDIUM


#### C). HARD


## 2). Strings

#### A). EASY


#### B). MEDIUM


#### C). HARD


## Problems will come on these topics also
**Sorting, Searching, Two Pointers, Sliding Window, Top 'k' elements in Array, Backtracking, Divide and Conquer, List, Dictionary and HashSet**

# Questions on Arrays and Strings

### ============================ w3resource ============================

| Arrays Questions |
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
|          |

#### 1). sort a numeric array and a string array.

```csharp
using System;

public class Exercise1
{
    // The main method where the program execution starts.
    public static void Main(string[] args)
    {
        // Declare and initialize an integer array.
        int[] myArray1 = { 1789, 2035, 1899, 1456, 2013, 1458, 2458, 1254, 1472, 2365, 1456, 2165, 1457, 2456};

        // Declare and initialize a string array.
        string[] myArray2 = {"Java","Python", "PHP", "C#", "C Programming","C++"};

        // Print the original numeric array.
        Console.WriteLine("Original numeric array: " + string.Join(", ", myArray1));

        // Sort the numeric array using a custom bubble sort implementation.
        BubbleSort(myArray1);

        // Print the sorted numeric array.
        Console.WriteLine("Sorted numeric array: " + string.Join(", ", myArray1));

        // Print the original string array.
        Console.WriteLine("Original string array: " + string.Join(", ", myArray2));

        // Sort the string array using a custom bubble sort implementation.
        BubbleSort(myArray2);

        // Print the sorted string array.
        Console.WriteLine("Sorted string array: " + string.Join(", ", myArray2));
    }

    // Custom Bubble Sort for integer arrays.
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // If the current element is greater than the next, swap them.
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Custom Bubble Sort for string arrays.
    public static void BubbleSort(string[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare strings lexicographically and swap if necessary.
                if (string.Compare(array[j], array[j + 1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
```

#### 2). sum values of an array.

```csharp
using System;

public class Exercise2
{
    // The main method where the program execution starts.
    public static void Main(string[] args)
    {
        // Declare and initialize an integer array.
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Declare and initialize a variable to store the sum.
        int sum = 0;

        // Iterate over each element of the array using a foreach loop.
        foreach (int i in myArray)
        {
            // Add each element to the sum.
            sum += i;
        }

        // Print the sum of the array elements.
        Console.WriteLine("The sum is " + sum);
    }
}
```

#### 3). print the following grid.  

![image](https://github.com/user-attachments/assets/ba0175b8-dde8-4682-aad9-428b9e7ed41e)

```csharp
using System;

public class MainClass
{
    // The main method where the program execution starts.
    public static void Main(string[] args)
    {
        // Declare a two-dimensional integer array 'a' with dimensions 10x10.
        int[,] a = new int[10, 10];

        // Use nested loops to iterate over each row and column of the array.
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                // Check if the element is 0 and replace it with a dash (-).
                if (a[i, j] == 0)
                {
                    Console.Write($"-  ");
                }
                else
                {
                    Console.Write($"{a[i, j],2} ");
                }
            }
            // Move to the next line to represent a new row in the output.
            Console.WriteLine();
        }
    }
}
```

#### 4). calculate the average value of array elements

```csharp
using System;

public class Exercise4
{
    // The main method where the program execution starts.
    public static void Main(string[] args)
    {
        // Declare an integer array 'numbers' and initialize it with values.
        int[] numbers = new int[] { 20, 30, 25, 35, -16, 60, -100 };

        // Initialize a variable 'sum' to store the sum of array elements.
        int sum = 0;

        // Use a for loop to iterate over the elements of the 'numbers' array.
        for (int i = 0; i < numbers.Length; i++)
        {
            // Add the current element to the sum.
            sum += numbers[i];
        }

        // Calculate the average value by dividing the sum by the number of elements.
        double average = (double)sum / numbers.Length;

        // Print the calculated average value to the console.
        Console.WriteLine("Average value of the array elements is: " + average);
    }
}
```


#### 5). test if an array contains a specific value.

```csharp
using System;

public class Exercise5
{
    // Define a method 'Contains' that checks if an integer array 'arr' contains a given 'item'.
    public static bool Contains(int[] arr, int item)
    {
        // Iterate through each element 'n' in the array 'arr'.
        foreach (int n in arr)
        {
            // Check if 'item' is equal to the current element 'n'.
            if (item == n)
            {
                // If a match is found, return 'true'.
                return true;
            }
        }
        // If no match is found, return 'false'.
        return false;
    }

    // The main method where the program execution starts.
    public static void Main(string[] args)
    {
        // Declare an integer array 'myArray1' and initialize it with values.
        int[] myArray1 = {
            1789, 2035, 1899, 1456, 2013, 1458, 2458, 1254, 1472, 2365, 1456, 2265, 1457, 2456
        };

        // Check if the integer array 'myArray1' contains the item 2013 and print the result.
        Console.WriteLine(Contains(myArray1, 2013));

        // Check if the integer array 'myArray1' contains the item 2015 and print the result.
        Console.WriteLine(Contains(myArray1, 2015));
    }
}

```

#### 6). find the index of an array element.

```csharp

```


#### 7). remove a specific element from an array.

```csharp

```

#### 8). copy an array by iterating the array.

```csharp

```


#### 9). insert an element (specific position) into an array.

```csharp

```

#### 10). find the maximum and minimum value of an array.

```csharp

```

### ============================ javarevisited ============================

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
|         |

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


| Strings Questions |
|----------|
|          |
|   [javarevisited](https://javarevisited.blogspot.com/2015/01/top-20-string-coding-interview-question-programming-interview.html#axzz8nfGDfJoI)  |
|          |
| 1). Print duplicate characters from String |  
| 2). Check if two Strings are anagrams of each other |  

### ============================ interviewbit ============================

| Arrays Questions |
|----------|
|          |
|  [interviewbit](https://www.interviewbit.com/array-interview-questions/) |
|          |
| 1). Maximum Number in an Array |  
|          |

### ============================ igotanoffer ============================

| Arrays Questions |
|----------|
|   [igotanoffer](https://igotanoffer.com/blogs/tech/array-interview-questions)  |
|          |
|    **EASY**      |
|          |
| 1). Merge two sorted arrays | 
| 2). Maximum Number in an Array |  
| 3). Reverse an Array | 
| 4). Sum of all elements of an array |
|           |
|     **MEDIUM**     |
|           |
|     **HARD**     |
|           |


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

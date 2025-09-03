# Questions on Arrays and Strings

## 1). Arrays

| 🔹 Basic Traversal & Counting |
|----------|
| 1. Write a C# program to read and print elements of an array. Also print it using Recursion. |
| 2. Write a C# program to print all negative elements in an array. |
| 3. Write a C# program to find the sum of all array elements – using recursion. |
| 4. Write a C# program to find the maximum and minimum element in an array. Also print it using recursion. |
| 5. Write a C# program to find the second largest element in an array. |
| 6. Write a C# program to count the total number of even and odd elements in an array. |
| Sum of all the elements of the integer Array |
| Maximum Minimum Array |
| Count occurrences of each element in an array |
| Print frequency of all elements in the array also print the missing elements frequency as 0 |

#### 1. Write a C# program to read and print elements of an array

**Simple Approach**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 1000;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int N;

        Console.Write("Enter size of array: ");
        N = int.Parse(Console.ReadLine());

        Console.Write($"Enter {N} elements in the array: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + ", ");
        }
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of array: 5
Enter 5 elements in the array: 68
90
4
36
12

Elements in array are: 68, 90, 4, 36, 12,
```

**Using Recursion**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int N;

        Console.Write("Enter size of the array: ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements in the array: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements in the array: ");
        printArray(arr, 0, N);
    }

    static void printArray(int[] arr, int start, int len)
    {
        if (start >= len)
            return;

        Console.Write(arr[start] + ", ");
        printArray(arr, start + 1, len);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 5
Enter elements in the array: 
68
54
2
18
94
Elements in the array: 
68, 54, 2, 18, 94, 
```

#### 2. Write a C# program to print all negative elements in an array.

```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int N;

        Console.Write("Enter size of the array: ");
        N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements in the array: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nAll negative elements in the array are: ");
        for (int i = 0; i < N; i++)
        {
            if (arr[i] < 0)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 5
Enter elements in the array: 
-45
80
0
-78
-20

All negative elements in the array are: 
-45	-78	-20	
```

#### 3. Write a C# program to find the sum of all array elements.

**Simple Approach**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int n, sum = 0;

        Console.Write("Enter size of the array: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter {n} elements in the array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine($"Sum of all elements of array = {sum}");
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 4
Enter 4 elements in the array: 
45
-45
86
0
Sum of all elements of array = 86
```

**Using Recursion**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int N, sumOfArray;

        Console.Write("Enter size of the array: ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements in the array: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        sumOfArray = Sum(arr, 0, N);
        Console.WriteLine("Sum of array elements: " + sumOfArray);
    }

    static int Sum(int[] arr, int start, int len)
    {
        if (start >= len)
            return 0;

        return arr[start] + Sum(arr, start + 1, len);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 4
Enter elements in the array: 
-90
64
90
0
Sum of array elements: 64
```

#### 4. Write a C# program to find the maximum and minimum element in an array.

**Simple Approach**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int size, max, min;

        Console.Write("Enter size of the array: ");
        size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements in the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        max = arr[0];
        min = arr[0];

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("Maximum element = " + max);
        Console.WriteLine("Minimum element = " + min);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 5
Enter elements in the array: 
45
-80
-2
600
0
Maximum element = 600
Minimum element = -80
```

**Using Recursion**
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] array = new int[MAX_SIZE];
        int N, max, min;

        Console.Write("Enter size of the array: ");
        N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter {N} elements in the array: ");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        max = Maximum(array, 0, N);
        min = Minimum(array, 0, N);

        Console.WriteLine($"Minimum element in array = {min}");
        Console.WriteLine($"Maximum element in array = {max}");
    }
    static int Maximum(int[] array, int index, int len)
    {
        if (index >= len - 2)
        {
            return array[index] > array[index + 1] ? array[index] : array[index + 1];
        }
        int max = Maximum(array, index + 1, len);

        return array[index] > max ? array[index] : max;
    }
    static int Minimum(int[] array, int index, int len)
    {
        if (index >= len - 2)
        {
            return array[index] < array[index + 1] ? array[index] : array[index + 1];
        }
        int min = Minimum(array, index + 1, len);

        return array[index] < min ? array[index] : min;
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 5
Enter 5 elements in the array: 
90
-8
100
0
-72
Minimum element in array = -72
Maximum element in array = 100

```

#### 5. Write a C# program to find the second largest element in an array.
```csharp
using System;

class Program
{
    const int MAX_SIZE = 1000;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int size, max1, max2;

        Console.Write("Enter size of the array (1-1000): ");
        size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements in the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        max1 = max2 = int.MinValue;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if (arr[i] > max2 && arr[i] < max1)
            {
                max2 = arr[i];
            }
        }

        Console.WriteLine($"First largest = {max1}");
        Console.WriteLine($"Second largest = {max2}");
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array (1-1000): 5
Enter elements in the array: 
21
100
-8
2000
50
First largest = 2000
Second largest = 100
```

#### 6. Write a C# program to count the total number of even and odd elements in an array.
```csharp
using System;

class Program
{
    const int MAX_SIZE = 100;

    static void Main(string[] args)
    {
        int[] arr = new int[MAX_SIZE];
        int size, even = 0, odd = 0;

        Console.Write("Enter size of the array: ");
        size = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter {size} elements in the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        Console.WriteLine($"Total even elements: {even}");
        Console.WriteLine($"Total odd elements: {odd}");
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter size of the array: 6
Enter 6 elements in the array: 
90
83
98
5
-90
57
Total even elements: 3
Total odd elements: 3
```


| Arrays Questions - 2 |
|----------|
| 7. Write a C# program to count the total number of negative elements in an array. |
| 8. Write a C# program to copy all elements from one array to another array. |
| 9. Write a C# program to insert an element in an array. |
| 10. Write a C# program to delete an element from an array at a specified position. |
| 11. Write a C# program to count the frequency of each element in an array. |
| 12. Write a C# program to print all unique elements in an array. |

| Arrays Questions - 3 |
|----------|
| 13. Write a C# program to count the total number of duplicate elements in an array. |
| 14. Write a C# program to delete all duplicate elements from an array. |
| 15. Write a C# program to merge two arrays into a third array. |
| 16. Write a C# program to find the reverse of an array. |
| 17. Write a C# program to put even and odd elements of an array into two separate arrays. |
| 18. Write a C# program to search for an element in an array. |

| Arrays Questions - 4 |
|----------|
| 19. Write a C# program to sort array elements in ascending or descending order. |
| 20. Write a C# program to sort even and odd elements of an array separately. |
| 21. Write a C# program to left rotate an array. |
| 22. Write a C# program to right rotate an array. |



| Arrays Questions - 5 |
|----------|
|41. C# program to find the sum of all the elements of the integer Array.|
|42. C# program to search an Array for some given value.|
|43. C# program to perform Binary search in a sorted array.|
|44. C# program to rotate Array elements K number of times.|
|45. C# program to find the largest sum contiguous subarray.|

#### 41. C# program to find the sum of all the elements of the integer Array.
```csharp
using System;

class Program
{
    public static int SumArray(int[] arr)
    {
        int size = arr.Length;
        int total = 0;

        for (int index = 0; index < size; index++)
        {
            total += arr[index];
        }
        return total;
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Sum of values in array: " + SumArray(arr));
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Sum of values in array: 45
```

#### 42. C# program to search an Array for some given value.
```csharp
using System;

class Program
{
    public static int SequentialSearch(int[] arr, int size, int value)
    {
        for (int i = 0; i < size; i++)
        {
            if (value == arr[i])
                return i;
        }
        return -1;
    }

  public static void Main(string[] args)
   {
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    
    // Perform sequential search for the value 7
    Console.WriteLine("Index of value 7 using Sequential Search: " + SequentialSearch(arr, arr.Length, 7));
   }

}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Index of value 7 using Sequential Search: 6
```

#### 43. C# program to perform Binary search in a sorted array.
```csharp
using System;

class Program
{
  public static int BinarySearch(int[] arr, int size, int value)
{
    int low = 0;
    int high = size - 1;

    while (low <= high)
    {
        int mid = low + (high - low) / 2;

        if (arr[mid] == value)
        {
            return mid;
        }

        else if (arr[mid] < value)
        {
            low = mid + 1;
        }

        else
        {
            high = mid - 1;
        }
    }
    
    return -1;
 }

  public static void Main(string[] args)
   {
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    
    Console.WriteLine("Index of value 7 using Binary Search: " + BinarySearch(arr, arr.Length, 7));
   }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Index of value 7 using Binary Search: 6
```

#### 44. C# program to rotate Array elements K number of times.
```csharp
using System;

class Program
{
    public static void rotateArray(int[] a, int n, int k)
    {
        reverseArray(a, 0, k - 1);
        reverseArray(a, k, n - 1);
        reverseArray(a, 0, n - 1);
    }

    public static void reverseArray(int[] a, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }

    // Adding the printArray method
    public static void printArray(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        rotateArray(arr, arr.Length, 2);
        printArray(arr, arr.Length);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
3 4 5 6 1 2 
```

#### 45. C# program to find the largest sum contiguous subarray.
```csharp
using System;

class Program
{
    public static int MaxSubArraySum(int[] a, int size)
    {
        int maxSoFar = int.MinValue;
        int maxEndingHere = 0;

        for (int i = 0; i < size; i++)
        {
            maxEndingHere += a[i];

            if (maxSoFar < maxEndingHere)
            {
                maxSoFar = maxEndingHere;
            }
            if (maxEndingHere < 0)
            {
                maxEndingHere = 0;
            }
        }
        return maxSoFar;
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[] { 1, -2, 3, 4, -4, 6, -4, 3, 2 };
        Console.WriteLine("Max sub-array sum: " + MaxSubArraySum(arr, arr.Length));
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Max sub-array sum: 10
```

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 2). Strings

| Strings Questions - 1 |
|----------|
|1. C# program to find length of a string.|
|2. C# program to copy one string to another string.|
|3. C# program to concatenate two strings.|
|4. C# program to compare two strings.|
|5. C# program to convert lowercase string to uppercase.|
|6. C# program to convert uppercase string to lowercase.|

#### 1. C# program to find length of a string.
```csharp
using System;

public class Exercise2
{
    public static void Main()
    {
        string str;
        int len = 0;

        Console.Write("\n\nFind the length of a string:\n");
        Console.Write("---------------------------------\n");

        Console.Write("Input the string: ");
        str = Console.ReadLine();

        foreach (char chr in str)
        {
            len += 1;
        }

        Console.Write("Length of the string is: {0}\n\n", len);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Find the length of a string:
---------------------------------
Input the string: ankit mehrotra
Length of the string is: 14
```

#### 2. C# program to copy one string to another string.
```csharp
using System;

public class Exercise8  
{  
    public static void Main() 
    {
        string str1;
        int i, len;

        Console.Write("\n\nCopy one string into another string:\n");
        Console.Write("-----------------------------------------\n"); 	
        Console.Write("Input the string: ");
        str1 = Console.ReadLine();

        len = str1.Length;
        string[] str2 = new string[len];

        i = 0;
        while (i < len)
        {
            string tmp = str1[i].ToString(); 
            str2[i] = tmp; 
            i++; 
        }

        Console.Write("\nThe First string is: {0}\n", str1);
        Console.Write("The Second string is: {0}\n", string.Join("", str2)); 
        Console.Write("Number of characters copied: {0}\n\n", i); 
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Copy one string into another string:
-----------------------------------------
Input the string: ankit

The First string is: ankit
The Second string is: ankit
Number of characters copied: 5
```

#### 3. C# program to concatenate two strings.
```csharp
using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";

        char[] result = new char[str1.Length + str2.Length];

        // Copy characters from str1
        for (int i = 0; i < str1.Length; i++)
        {
            result[i] = str1[i];
        }

        // Copy characters from str2
        for (int i = 0; i < str2.Length; i++)
        {
            result[str1.Length + i] = str2[i];
        }

        // Convert char array to string
        string concatenatedString = new string(result);

        Console.WriteLine(concatenatedString);
    }
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
HelloWorld
```

#### 4. C# program to compare two strings.
```csharp
using System;    
public class StringExample    
    {    
        public static void Main(string[] args)    
        {    
            string s1 = "hello";    
            string s2 = "hello";    
            string s3 = "csharp";  
            string s4 = "mello";  
        
            Console.WriteLine(string.Compare(s1,s2));   
            Console.WriteLine(string.Compare(s2,s3));   
            Console.WriteLine(string.Compare(s3,s4));   
        }    
    }

𝐎𝐮𝐭𝐩𝐮𝐭 :
0
1
-1
```

#### 5. C# program to convert lowercase string to uppercase.
```csharp
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace LowerTOUpper  
{  
    class LowerTOUpper  
    {  
       public static String ConvertToUpperCase(String input)  
      {  
         String output = "";  
         for (int i = 0; i < input.Length; i++)  
         {  
            if (input[i] >= 'a' && input[i] <= 'z')  
            {  
               output += (char)(input[i] - 'a' + 'A');  
            }  
            else  
               output += input[i];  
         }  
         return output;  
      }  
   
      static void Main(string[] args)  
      {  
         System.Console.Write("Enter a string: ");  
         String input = System.Console.ReadLine();  
         input = ConvertToUpperCase(input);  
         System.Console.WriteLine("Converted String in Upper Case: " + input);  
         Console.ReadLine();  
      }  
    }  
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter a string: Ankit Mehrotra
Converted String in Upper Case: ANKIT MEHROTRA
```

#### 6. C# program to convert uppercase string to lowercase.
```csharp
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace UpperToLower  
{  
    class UpperToLower  
    {  
        public static String ConvertToLowerCase(String input)  
        {  
            String output = "";  
            for (int i = 0; i < input.Length; i++)  
            {  
                if (input[i] >= 'A' && input[i] <= 'Z')  
                {  
                    output += (char)(input[i] - 'A' + 'a'); 
                }  
                else  
                    output += input[i];
            }  
            return output;  
        }  
  
        static void Main(string[] args)  
        {  
            // Input from user
            System.Console.Write("Enter a string: ");  
            String input = System.Console.ReadLine();  
            
            input = ConvertToLowerCase(input);  
            
            System.Console.WriteLine("Converted String in Lower Case: " + input);  
            Console.ReadLine();  
        }  
    }  
}

𝐎𝐮𝐭𝐩𝐮𝐭 :
Enter a string: ankit Mehrotra
Converted String in Lower Case: ankit mehrotra
```


| Strings Questions - 2 |
|----------|
|7. C# program to toggle case of each character of a string.|
|8. C# program to find total number of alphabets, digits or special character in a string.|
|9. C# program to count total number of vowels and consonants in a string.|
|10. C# program to count total number of words in a string.|
|11. C# program to find reverse of a string.|
|12. C# program to check whether a string is palindrome or not.|

#### 7. C# program to toggle case of each character of a string.
```csharp
```


#### 8. C# program to find total number of alphabets, digits or special character in a string.
```csharp
```

#### 9. C# program to count total number of vowels and consonants in a string.
```csharp
```

#### 10. C# program to count total number of words in a string.
```csharp
```

#### 11. C# program to find reverse of a string.
```csharp
```

#### 12. C# program to check whether a string is palindrome or not.
```csharp
```



| Strings Questions - 3 |
|----------|
|13. C# program to reverse order of words in a given string.|
|14. C# program to find first occurrence of a character in a given string.|
|15. C# program to find last occurrence of a character in a given string.|
|16. C# program to search all occurrences of a character in given string.|
|17. C# program to count occurrences of a character in given string.|
|18. C# program to find highest frequency character in a string.|

#### 13. C# program to reverse order of words in a given string.
```csharp
```

#### 14. C# program to find first occurrence of a character in a given string.
```csharp
```

#### 15. C# program to find last occurrence of a character in a given string.
```csharp
```

#### 16. C# program to search all occurrences of a character in given string.
```csharp
```

#### 17. C# program to count occurrences of a character in given string.
```csharp
```

#### 18. C# program to find highest frequency character in a string.
```csharp
```


| Strings Questions - 4 |
|----------|
|19. C# program to find lowest frequency character in a string.|
|20. C# program to count frequency of each character in a string.|
|21. C# program to remove first occurrence of a character from string.|
|22. C# program to remove last occurrence of a character from string.|
|23. C# program to remove all occurrences of a character from string.|
|24. C# program to remove all repeated characters from a given string.|

#### 19. C# program to find lowest frequency character in a string.
```csharp
```

#### 20. C# program to count frequency of each character in a string.
```csharp
```

#### 21. C# program to remove first occurrence of a character from string.
```csharp
```

#### 22. C# program to remove last occurrence of a character from string.
```csharp
```

#### 23. C# program to remove all occurrences of a character from string.
```csharp
```

#### 24. C# program to remove all repeated characters from a given string.
```csharp
```


| Strings Questions - 5 |
|----------|
|25. C# program to replace first occurrence of a character with another in a string.|
|26. C# program to replace last occurrence of a character with another in a string.|
|27. C# program to replace all occurrences of a character with another in a string.|
|28. C# program to find first occurrence of a word in a given string.|
|29. C# program to find last occurrence of a word in a given string.|
|30. C# program to search all occurrences of a word in given string.|

#### 25. C# program to replace first occurrence of a character with another in a string.
```csharp
```

#### 26. C# program to replace last occurrence of a character with another in a string.
```csharp
```

#### 27. C# program to replace all occurrences of a character with another in a string.
```csharp
```

#### 28. C# program to find first occurrence of a word in a given string.
```csharp
```

#### 29. C# program to find last occurrence of a word in a given string.
```csharp
```

#### 30. C# program to search all occurrences of a word in given string.
```csharp
```


| Strings Questions - 6 |
|----------|
|31. C# program to count occurrences of a word in a given string.|
|32. C# program to remove first occurrence of a word from string.|
|33. C# program to remove last occurrence of a word in given string.|
|34. C# program to remove all occurrence of a word in given string.|
|35. C# program to trim leading white space characters from given string.|
|36. C# program to trim trailing white space characters from given string.|

#### 31. C# program to count occurrences of a word in a given string.
```csharp
```

#### 32. C# program to remove first occurrence of a word from string.
```csharp
```

#### 33. C# program to remove last occurrence of a word in given string.
```csharp
```

#### 34. C# program to remove all occurrence of a word in given string.
```csharp
```

 
#### 35. C# program to trim leading white space characters from given string.
```csharp
```

#### 36. C# program to trim trailing white space characters from given string.
```csharp
```


| Strings Questions - 7 |
|----------|
|37. C# program to trim both leading and trailing white space characters from given string.|
|38. C# program to remove all extra blank spaces from given string.|

#### 37. C# program to trim both leading and trailing white space characters from given string.
```csharp
```

#### 38. C# program to remove all extra blank spaces from given string.
```csharp
```


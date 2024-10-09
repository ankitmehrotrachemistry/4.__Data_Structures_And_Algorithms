# Questions on Arrays and Strings

## 1). Arrays

| Arrays Questions  |
|----------|
|          |  
| 1. Write a C# program to read and print elements of an array – using recursion. |
| 2. Write a C# program to print all negative elements in an array. |
| 3. Write a C# program to find the sum of all array elements – using recursion. |
| 4. Write a C# program to find the maximum and minimum element in an array – using recursion. |
| 5. Write a C# program to find the second largest element in an array. |
| 6. Write a C# program to count the total number of even and odd elements in an array. |
| 7. Write a C# program to count the total number of negative elements in an array. |
| 8. Write a C# program to copy all elements from one array to another array. |
| 9. Write a C# program to insert an element in an array. |
| 10. Write a C# program to delete an element from an array at a specified position. |
| 11. Write a C# program to count the frequency of each element in an array. |
| 12. Write a C# program to print all unique elements in an array. |
| 13. Write a C# program to count the total number of duplicate elements in an array. |
| 14. Write a C# program to delete all duplicate elements from an array. |
| 15. Write a C# program to merge two arrays into a third array. |
| 16. Write a C# program to find the reverse of an array. |
| 17. Write a C# program to put even and odd elements of an array into two separate arrays. |
| 18. Write a C# program to search for an element in an array. |
| 19. Write a C# program to sort array elements in ascending or descending order. |
| 20. Write a C# program to sort even and odd elements of an array separately. |
| 21. Write a C# program to left rotate an array. |
| 22. Write a C# program to right rotate an array. |



| Arrays Questions  |
|----------|
|          |  
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

| Strings Questions  |
|----------|
|          |  
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


|  |
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



| |
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


|   |
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


|   |
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


|   |
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


|   |
|----------|
|37. C# program to trim both leading and trailing white space characters from given string.|
|38. C# program to remove all extra blank spaces from given string.|
||

#### 37. C# program to trim both leading and trailing white space characters from given string.
```csharp
```

#### 38. C# program to remove all extra blank spaces from given string.
```csharp
```


## Problems will come on these topics also
**Sorting, Searching, Two Pointers, Sliding Window, Top 'k' elements in Array, Backtracking, Divide and Conquer, List, Dictionary and HashSet**

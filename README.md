# Questions on Arrays and Strings

## 1). Arrays


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
```

#### 5. C# program to convert lowercase string to uppercase.
```csharp
```

#### 6. C# program to convert uppercase string to lowercase.
```csharp
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

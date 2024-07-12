using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
			IDictionary<int, string> numberNames = new Dictionary<int, string>();
			numberNames.Add(1, "One");
			numberNames.Add(3, "Three");
			numberNames.Add(2, "Two");

			foreach (KeyValuePair<int, string> kvp in numberNames)
				 Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			var cities = new Dictionary<string, string>(){
			               {"UK","London, Manchester, Birmingham"},
			               {"USA","Chicago, New York, Washington"},
			               {"India","Mumbai, New Delhi, Pune"}
		               };

			foreach (var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		}
    }
}
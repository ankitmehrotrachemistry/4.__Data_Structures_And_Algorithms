using System;
using System.Collections.Generic;

namespace ListExample
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	class Program
    {
		public static void Main()
		{
			var primeNumbers = new List<int>();

			primeNumbers.Add(1);
			primeNumbers.Add(3);
			primeNumbers.Add(5);
			primeNumbers.Add(7);

			Console.WriteLine("No of elements: " + primeNumbers.Count);

			var cities = new List<string>();

			cities.Add("New York");
			cities.Add("London");
			cities.Add("Mumbai");
			cities.Add("Chicago");
			cities.Add(null); // null is allowed

			Console.WriteLine("No of elements: " + cities.Count);

			var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

			Console.WriteLine("No of elements: " + bigCities.Count);

			var students = new List<Student>() {
				new Student(){ Id = 1, Name="Bill"},
				new Student(){ Id = 2, Name="Steve"},
				new Student(){ Id = 3, Name="Ram"},
				new Student(){ Id = 4, Name="Abdul"}
			};

			Console.WriteLine("No of elements: " + students.Count);
		}
	}
}

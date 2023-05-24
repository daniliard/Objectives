using System;
using System.Linq;



class Program

{

    static void Main(string[] args)

    {

        double[] array = { 3, 0, 5, 9, 1, 0, 6, 0 };



        int countZero = array.Count(x => x == 0);

        Console.WriteLine($"Кiлькiсть елементiв масиву рiвних 0: {countZero}");



        double minElement = array.Min();

        int minIndex = Array.IndexOf(array, minElement);

        double sumAfterMin = array.Skip(minIndex + 1).Sum();

        Console.WriteLine($"Cумa елементiв масиву розташованих пiсля мiнiмального елемента ({minElement}): {sumAfterMin}");



        double[] sortedArray = array.OrderBy(x => Math.Abs(x)).ToArray();

        Console.WriteLine($"Eлементи масиву за зростанням модулiв елементiв: {string.Join(", ", sortedArray)}");

    }

}

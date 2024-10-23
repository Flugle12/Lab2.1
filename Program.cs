using System;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("First\n");

        void threeInput(out double a, out double b, out double c)
        {
            Console.WriteLine("Enter three double nums separetad by space: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length < 3)
            {
                throw new ArgumentException("Need to three nums");
            }
            if (!double.TryParse(parts[0], out a) || !double.TryParse(parts[1], out b) || !double.TryParse(parts[2], out c))
            {
                throw new ArgumentException("Need to nums");
            }
            else
            {
                a = double.Parse(parts[0]); b = double.Parse(parts[1]); c = double.Parse(parts[2]);
            }
        }

        try
        {
            double input1, input2, input3;
            threeInput(out input1, out input2, out input3);
            Console.WriteLine($"{input1}, {input2}, {input3}");

            Nine newNine = new Nine(input1, input2, input3), newNineCopy;
            Console.WriteLine("вектор: " + newNine);
            newNineCopy = newNine;

            Console.WriteLine("скопированный вектор: " + newNineCopy);
            newNineCopy.ToInt();
            Console.WriteLine("приведенный к целым: " + newNineCopy);

            Console.WriteLine("дочерный класс:");
            ExtendNine ExtendClass = new ExtendNine(input1, input2, input3);
            Console.WriteLine("Вектор дочернего класса: " + ExtendClass);
            ExtendClass.Normalize();
            Console.WriteLine("после нормализации: " + ExtendClass);
            //Console.WriteLine(ExtendClass);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

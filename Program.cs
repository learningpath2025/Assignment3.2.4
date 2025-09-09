namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] NumberArray = GetNumbers(GetCount());
            double total = CalculateTotal(NumberArray);
            double average = CalculateAverage(total, NumberArray.Length);
        }

        static int GetCount()
        {
            Console.Write("Enter the count of numbers: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static double[] GetNumbers(int count)
        {
            double[] NumberArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                NumberArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            return NumberArray;
        }

        static double CalculateTotal(double[] NumberArray)
        {
            double sum = 0;
            foreach (double number in NumberArray)
            {
                sum += number;
            }
            Console.WriteLine($"The total is: {sum}");
            return sum;
        }

        static double CalculateAverage(double total, int count)
        {
            double average = total / count;
            Console.WriteLine($"The average is: {average}");
            return average;
        }
    }
}

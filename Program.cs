using System.Text;

namespace lab1
{
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            //task1
            string firstName = "Євгеній";
            string lastName = "Боримський";
            int age = 17;

            string result = $"Мене звати {firstName} {lastName}, мені {age} років.";

            Console.WriteLine(result);
            Console.WriteLine("-------------------------");
            Console.ReadLine();

            //task2
            int a = 3;
            int b = 1;

            double result = (Math.Pow(a + b, 2f) - Math.Pow(a,2) + 2 * a * b) /  Math.Pow(b,2);

            Console.WriteLine(result);
            Console.WriteLine("-------------------------");

            //task3
            int number = int.Parse(Console.ReadLine());
            
            int reversed = number % 10 * 100 + number % 100 + number / 100;
            Console.WriteLine(reversed.);
            Console.Read();
        }
    }
}
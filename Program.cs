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

            Console.WriteLine($"Мене звати {firstName} {lastName}, мені {age} років.");
            Console.WriteLine("-------------------------");
            Console.Read();

            //task2
            int a = 3;
            int b = 1;

            double result = (Math.Pow((a+b), 2f) - Math.Pow(a,2) + 2*a*b) / Math.Pow(a,2);

            Console.Write(result);
            Console.WriteLine("-------------------------");
            Console.Read();

            //task3
            string number = Console.ReadLine();
            Console.WriteLine(number.Reverse());
        }
    }
}
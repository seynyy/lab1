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
            Console.ReadLine();

            //task2
            int a = 3;
            int b = 1;

            double result = (Math.Pow(a+b, 2f) - Math.Pow(a,2) + 2*a*b) / Math.Pow(a,2);

            Console.WriteLine(result);
            Console.WriteLine("-------------------------");

            //task3
            double number = Convert.ToDouble(Console.ReadLine());
 
            double first = number % 10;
            double second = (number % 100 - first)/10;
            double third = (number - second*10 - first)/100;
            
            string reversed = first.ToString()+second.ToString()+third.ToString();
            Console.WriteLine(reversed);
            Console.Read();
        }
    }
}
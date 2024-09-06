namespace lab1
{
    class Program {
        static void Main(string[] args) {
            //task1
            string firstName = "Євгеній";
            string lastName = "Боримський";
            int age = 17;

            Console.Write($"Мене звати {firstName} {lastName}, мені {age} років.");
            Console.Read();
            
            //task2
            int a = 3;
            int b = 1;

            float result = ((a+b)^2-a^2+2*a*b)/b^2;

            Console.Write(result);
            Console.Read();

            //task3
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number.ToString().Reverse());
        }
    }
}
namespace lab1
{
    class Program2 {
        static void Main(string[] args) {
            int a = 3;
            int b = 1;

            float result = ((a+b)^2-a^2+2*a*b)/b^2;

            Console.Write(result);
            Console.Read();
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {

        {
            //Add();
            //var result = Add2(20, 30);
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2) 
        {
            number1 = 30;
        return number1 + number2;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //  ForLoop();
        //  WhileLoop();
        // DoWhileLoop();
        // ForEachLoop();
        if (IsPrimeNumb(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }

    }
    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
        }
    }
    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 11);
    }
    int number = 100;
    private static int WhileLoop(int number)
    {

        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
        return number;
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished!");
    }
}
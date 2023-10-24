internal class Program
{
    private static void Main(string[] args)
    {
        //  Console.WriteLine("Hello, World!");
        //double number5 = 10.4;
        //decimal number6 = 10;
        //int number1 = 1;
        //long number2 = 9223372036854775807;
        //short number3 = 32767;
        //byte number4 = 255;
        //char character = 'A';
        //bool condition = false;
        //var number7 = 10;
        //Console.WriteLine("Number1 is {0}", number1);
        //Console.WriteLine("Number2 is {0}", number2);
        //Console.WriteLine("Number3 is {0}", number3);
        //Console.WriteLine("Number4 is {0}", number4);
        //Console.WriteLine("Number5 is {0}", number5);
        //Console.WriteLine("Character is : {0}", (int)character);

        var number = 11;
        //    if (number ==10)
        //    {
        //        Console.WriteLine("Number is 10");
        //    }
        //    else if (number==20)
        //    {
        //        Console.WriteLine("Number is 20");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Number is not 10 or 20");
        // }
        switch (number)
        {
            case 10:
                Console.WriteLine("Number is 10");
                break;
            case 20:
                Console.WriteLine("Number is 20");
                break;
            default:
                Console.WriteLine("Number is not 10 or 20");

                break;
        }
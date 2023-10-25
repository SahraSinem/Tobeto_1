internal class Program
{
    private static void Main(string[] args)
    {
        string city = "Ankara";
        // Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
        string city2 = "İstanbul";
       // string result = city + city2;
       Console.WriteLine(String.Format("{0} {1}",city,city2));
    }
}
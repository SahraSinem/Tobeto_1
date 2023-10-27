using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        IEat[] eats = new IEat[2]
        {
            new Manager(),
            new Worker(),
           
        };
        foreach (var person in eats) 
        {
            person.Eat();
            
        }
    }
    interface IWorker
    {
        
        public void Work();
    }

    interface IEat
    {
        public void Eat();
    }
    interface ISalary
    {
        public void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        { Console.WriteLine("ye"); }


        public void GetSalary()
        {
            Console.WriteLine("kazan");
        }

            public void Work()
        {
            Console.WriteLine("çalış");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("ye");
        }

        public void GetSalary()
        {
            Console.WriteLine("kazan");
        }

        public void Work()
        {
            Console.WriteLine("çalış");
        }
       
       
    }    
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("çalış");
        }
        
    }

}
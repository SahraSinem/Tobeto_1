using Interfaces;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        //   InterFacesIntro();
        // Demo();
        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
new SqlServerCustomerDal(),
new OracleCustomerDal(),
new MySqlCustomerDal(),
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

        Console.ReadLine();

    }

    private static void Demo()
    {
        CustomerManager customermanager = new CustomerManager();
        customermanager.Add(new OracleCustomerDal());
    }

    private static void InterFacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            Name = "Engin",
            Lastname = "Demiroğ",
            Address = "Ankara",


        };
        Student student = new Student
        {
            Id = 1,
            Name = "Derin",
            Lastname = "Demiroğ",
            Department = "Computer Sciences"

        };

        manager.Add(customer);
        manager.Add(student);
    }

    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Lastname { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }


    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }

    }
}
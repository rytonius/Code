
class Person
{
    public string Name;
    public int Age;
    public float Year;
    public Person(string name, int age, float year)
    {
        Name = name;
        Age = age;
        Year = year;
    }
    public static implicit operator int(Person p)   // Convert Person to int
    {
        return p.Age;
    }
    public static implicit operator Person(int i)   // Convert int to Person
    {
        return new Person("Nemo", i, 2010);   // Nemo is latin for No one
    }

    public static explicit operator float(Person p) {
        return p.Year;
    }
}

class Program
{
    static void Main()
    {
        Person bill = new Person("bill", 25, 2000);

        int age = bill; // Convert a person object to an int
        Console.WriteLine($"Person Info: { bill.Name}, {age}, {bill.Year}");

        Person anon = 35; // Convert an int to a Person object
        Console.WriteLine($"Person Info: {anon.Name}, {anon.Age}, {anon.Year}");

        float anontwo = (float)bill;
        Console.WriteLine($"Person Info: {bill.Name}, {bill.Age}, {anontwo}");


        WriteLine("\nIsAsOperator\n");
        Conversions.IsAsOperator IAO = new Conversions.IsAsOperator();

        IAO.Main();
    }

    private static void WriteLine(string v)
    {
        Console.WriteLine(v);
    }
}

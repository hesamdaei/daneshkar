// See https://aka.ms/new-console-template for more information
int age = 33;
const string wellcomeMessage = "Wellcome to C#";
Console.WriteLine("My name is hesam Age= "+age);
Console.WriteLine(wellcomeMessage);
Console.WriteLine();



public class Student
{
    private string name;
    private int age;

    // مقدار اولیه 
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // پراپرتی Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // پراپرتی Age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // متد Introduce
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    }
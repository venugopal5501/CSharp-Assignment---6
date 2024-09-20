using System;
class Person
{
    public string g;
    public Person()
    {

    }
    public Person(string g)
    {
        this.g = g;
    }
    public int SetAge(int n)
    {
        return n;
    }
}

class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("I'm going to class");
    }
    public int age;
    public Student(int age)
    {
        this.age = age;

    }
    public void ShowAge(string greet)
    {
        Console.WriteLine(greet);
        Console.WriteLine("My age is " + age + " years old");
    }
}

class Teacher : Person
{
    private string subject;
    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }
    int age;
    string greet;
    public Teacher(int age, string greet)
    {
        this.age = age;
        this.greet = greet;
    }
    public void Explain()
    {
        Console.WriteLine(greet);
        Console.WriteLine("My age is " + age);
        Console.WriteLine("I am going to handle " + Subject);
        Console.WriteLine("Explanation Begins");
    }
}

class StudentAndTeacherTest
{
    public static void Main(string[] args)
    {
        string h = "hello";
        Person p = new Person(h);
        Student s = new Student(21);
        Teacher t = new Teacher(30, "hello");
        t.Subject = "Tamil";
        s.SetAge(21);
        s.ShowAge("Good Morning");
        t.Explain();
    }
}
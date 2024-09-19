using System;
class Person
{
    // public string g;
    // public Person(string g)
    // {
    //     this.g = g;
    // }
    public int SetAge(int age)
    {
        // Console.WriteLine(g);
        return age;
    }
}

class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("I'm going to class");
    }
    public void ShowAge(int age)
    {
        Console.WriteLine("My age is " + age + " years old");
    }
}

class Teacher : Person
{
    // private string subject;
    public void Explain()
    {
        Console.WriteLine("Explanation Begins");
    }

}

class StudentAndTeacherTest
{
    public static void Main(string[] args)
    {
        // Person p = new Person("hello");
        Student s = new Student();
        Teacher t = new Teacher();
        s.SetAge(21);
        s.ShowAge(21);
    }
}
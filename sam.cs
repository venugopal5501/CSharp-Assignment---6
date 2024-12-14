// Code on Assembly1
using System;

namespace Assembly1 {
    public class Greet {
        protected internal string msg = "Hello"; // Accessible within the same assembly and derived classes
    }

    public class Program { // Changed to public to allow access from outside
        static void Main(string[] args) {
            Greet greet = new Greet();
            Console.WriteLine(greet.msg); // This works because it's within the same assembly
            Console.ReadLine();
        }
    }
}
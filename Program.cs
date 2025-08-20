
using System;  //means that we can use classes from the System namespace//

namespace HelloWorld //is used to organize your code, it and is a container for classes and other namespaces
{ //marks the beginning ad the end of a block of code 
    class Program //is a container(wadah/tempaat) for data and methods, which brings functionality to your program
                  //.Every line of code that runs is C# must be inside a class
    {
        static void Main(string[] args) //Any code inside its curly brackets will be executed.
        {
            Console.WriteLine("Hello World!"); //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print test.
        }
    }
}

//Every C# statement ends with a semicolon;
//C# is case-sensitive; "MyClass" and "myclasss" have different meaning 
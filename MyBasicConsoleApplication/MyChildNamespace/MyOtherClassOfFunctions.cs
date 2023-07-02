using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//In order to access anything from this namespace, you need to add "using MyBasicConsoleApplication.MyChildNamespace;"
namespace MyBasicConsoleApplication.MyChildNamespace
{
    public class MyOtherClassOfFunctions
    {
        //An alternate way of returning a value from a method is to use the "out" keyword.
        //This is extremely useful for when you need to return multiple things, such as a Try method.
        //
        //In this case, the bool return indicates if it has successfully generated a random number, and myIntValue is the number that has been randomly generated
        public bool TryGetARandomNumber(out int myIntValue)
        {
            //Try-Catch statements are extremely useful for when a specific piece of code may throw an error.
            //Instead of causing an error or outright crashing your application, it gracefully runs the code privded in the catch segment.
            //In the code below, it prints the error to the console, and returns false to state that it could not generate a random number.

            try
            {
                Random random = new Random();
                myIntValue = random.Next(0, 100);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating a random number:" +
                    $"\n{ex}");

                myIntValue = 0;
                return false;
            }
        }
    }

    public class MyCustomObject
    {
        //This is a constructor for MyCustomObject.
        //Whenever you create a new instance of an object, the constructor is called.
        //In this example, the constructor has 2 parameters that must be passed through to it.
        //These parameters then set information from the object itself, allowing us to access it later.
        public MyCustomObject(string name, short age)
        {
            Name = name;
            Age = age;
        }

        //This overrides the default ToString() method, allowing us to override what gets returned when you call ToString() on this object.
        public override string ToString()
        {
            return $"Hello, my name is {Name}, and i am {Age} years old";
        }

        public string Name;
        //short is just a smaller variant of int.
        //They function the same way, however it's maximum value is smaller than an int.
        //see https://learn.microsoft.com/en-us/cpp/cpp/data-type-ranges?view=msvc-170 for more information about data types and the maximum values.
        public short Age;
    }

    public class MySecondCustomObject
    {
        //Getters and Setters are ways for you to create custom handling for when someone gets the value of a variable, or sets the value of a variable.
        //In the example below, there is no way to set the value of OSVersion, however getting it runs a bit of code to return the version string.
        public string OSVersion
        {
            get
            {
                return Environment.OSVersion.VersionString;
            }
        }

        //In the example below, we are storing the datetime as a long of ticks.
        //The usage of a getter/setter here allows us to automatically convert the ticks to a DateTime object
        private long datetimeTicks;
        public DateTimeOffset DateTimeValue
        {
            get { return new DateTime(datetimeTicks);  }
            set { datetimeTicks = value.Ticks; }
        }

        //It could also be written as a method
        public string GetOSVersion()
        {
            return Environment.OSVersion.VersionString;
        }

        //This method exits the program.
        //void is the return type, as no information needs to be returned.
        public void ExitProgram()
        {
            //This exits the program, with 0 as the exit code (Incidating that there hasn't been an error)
            Environment.Exit(0);
        }
    }
}

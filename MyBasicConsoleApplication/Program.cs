using MyBasicConsoleApplication.MyChildNamespace;

namespace MyBasicConsoleApplication
{
    public class Program
    {
        /// <summary>
        /// This is the method that is first called when the program starts up.
        /// </summary>
        /// <param name="args">A list of launch arguments provided.</param>

        static void Main(string[] args)
        {
            //Simply prints Hello, World! to the console.
            Console.WriteLine("Hello, World!");

            //This creates a new instance of MyClassOfFunctions. Without this, we are unable to access non-static variables and methods that have been declared inside the class.
            MyClassOfFunctions myClassOfFunctions = new MyClassOfFunctions();

            //This prints what the current time is to the console.
            Console.WriteLine("The current time is: " + myClassOfFunctions.MyFunctionToGetTime());

            //The line above can also be written like the following
            //Console.WriteLine($"The current time is: {myClassOfFunctions.MyFunctionToGetTime()}");

            //This can be shortened by adding "using MyBasicConsoleApplication.MyChildNamespace;" to the top of the file.
            MyChildNamespace.MyOtherClassOfFunctions myOtherClassOfFunctions = new MyChildNamespace.MyOtherClassOfFunctions();

            //Generates a random number.
            //hasGeneratedValue indicates if it has successfully generated a random number.
            //myRandomnumber is the random number that it has generated.
            bool hasGeneratedValue = myOtherClassOfFunctions.TryGetARandomNumber(out int myRandomNumber);

            //With if statements, the curly brackets { } are not required if there is only a single line of code within the statement.
            //They have been added below for improved readability.
            if(hasGeneratedValue)
            {
                Console.WriteLine($"Random number generated: {myRandomNumber}");
            }

            //Creates a new instance of MyCustomObject, with "Dave" as the name, and 54 as the age.
            MyChildNamespace.MyCustomObject myCustomObject = new MyChildNamespace.MyCustomObject("Dave", 54);

            //Returns the ToString() response of MyCustomObject.
            Console.WriteLine(myCustomObject.ToString());


            MySecondCustomObject mySecondCustomObject = new MySecondCustomObject();
            Console.WriteLine("Current OS Version: " + mySecondCustomObject.OSVersion);

            mySecondCustomObject.DateTimeValue = DateTime.Now.AddMilliseconds(-Environment.TickCount64);

            Console.Write($"Uptime: " + mySecondCustomObject.DateTimeValue);

            //Prevents the code from continuing to execute until a key has been pressed.
            Console.ReadKey();

            mySecondCustomObject.ExitProgram();
        }
    }
}
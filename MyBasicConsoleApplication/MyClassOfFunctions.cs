using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///Namespace of the code. Think of this as basically a giant folder for how you would access your code. It is automatically generated from your project name and any subfolders it is in.
///Things can automatically access anything within it's own namespace.
namespace MyBasicConsoleApplication
{
    public class MyClassOfFunctions
    {
        //The 3 following functions all do the exact same thing, just with slightly differeny syntax.

        /// <summary>
        /// A very basic function to return the current <see cref="DateTime">DateTime</see>.
        /// </summary>
        /// <returns>Currnt <see cref="DateTime">DateTime</see></returns>
        public DateTime MyFunctionToGetTime()
        {
            DateTime dateTime = MyPrivateFunctionToGetDateTime();

            return dateTime;
        }
        public DateTime MyAltFunctionToGetTime()
        {
            return MyPrivateFunctionToGetDateTime();
        }
        public DateTime MyOtherAltFunctionToGetTime() => MyPrivateFunctionToGetDateTime();


        //Same as above, the following 3 functions all again do the same thing, just with slightly differeny syntax.
        //As these are all private methods, they cannot be called from outside of this class.

        /// <summary>
        /// A very basic function to return the current <see cref="DateTime">DateTime</see>.
        /// </summary>
        /// <returns>Currnt <see cref="DateTime">DateTime</see></returns>
        private DateTime MyPrivateFunctionToGetDateTime()
        {
            DateTime dateTime = DateTime.Now;

            return dateTime;
        }
        private DateTime MyAltPrivateFunctionToGetDateTime()
        {
            return DateTime.Now;
        }
        private DateTime MyOtherAltPrivateFunctionToGetDateTime() => DateTime.Now;
    }
}

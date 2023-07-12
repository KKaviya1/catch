using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*byte myByte= 12;
            sbyte mySByte= 1;
            short mySShort = 12;
            int myInt = 12;
            long myLong = 12;
            double muDouble = 12.55;
            float myFloat = 10.5F;
            decimal myDecimal = 12;
            char myChar = 'A';
            string myString = " Our String";
            DateTime myDateTime = new DateTime(day: 12, month: 12, year: 2022);
            bool myBool = false;
*/
            try
            {
            byte ourByte;
            Console.WriteLine("enter a number");

            ourByte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("number is " + ourByte);
        }

        catch (FormatException ex)
        {
            Console.WriteLine("FormatException " +ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow Exception " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("error!!!" + ex.Message);
        }
        finally{
            Console.WriteLine("end of program !!!");
            Console.ReadKey();
        }
    }
}
}


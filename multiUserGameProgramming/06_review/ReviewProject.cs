// Amos Rains, ReviewProject, v1.0
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
            
            // Declaring and Assigning Variables 
            // Integer -- In C# the Max range for Intergers is -2,147,483,648 to 2,147,483,648
            int sum = 0;

            // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808
            // Long = 8 Bytes 
            long myLong = 1928742747247242904;
            // String 
            // 2-bytes PER CHARACTER
            // Must be in DOUBLE QUOTES " "


            string dadName = "Amos Rains III";

            // Character (Char)
            // Single character, in SINGLE QUOTES ' '
            // 2-Bytes 
            char myChar = 'M';

            // Boolean -- true / false
            // Boolean = 1 bit 


            bool result = false;
            //Float -- Stores up to 6-7 decimal digits. 

            float GPA = 3.79f;

            // Double -- Stores up to 15 decimal digits. 
            // Double = 8 Bytes 
            double myDouble = 9.12345678910234D;

            // Type Casting -- changing one date type to another.
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double 

            int myInt = 9;
            double thatDouble = myInt;
            Console.WriteLine(thatDouble);
            // EXPLICIT -- Must be done manually when going larger -> smaller 
            // double -> float -> long -> int -> char 
            double exampleDouble = 9.1234567890D;
            int theInt = (int) thatDouble;

            // Conversion Methods 
            // Convert.ToString() // String 
            string freeString = "Free the People";
        
            // Convert.ToDouble()  // Double
            double canDouble = 3.19412445455434D;

            // Convert.ToInt32()  // Interger
            int danInt = 555;

            // Convert.ToInt64()  // Long
            int fullLong = 1234;

            // Switch Statement
            int dayOfWeek = 5;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("The Day is Sunday.\n");
                    break;
                case 2:
                    Console.WriteLine("The Day is Monday.\n");
                    break;
                case 3:
                    Console.WriteLine("The Day is Tuesday.\n");
                    break;
                case 4:
                    Console.WriteLine("The Day is Wednesday.\n");
                    break;
                case 5:
                    Console.WriteLine("The Day is Thursday.\n");
                    break;
                case 6:
                    Console.WriteLine("The Day is Friday.\n");
                    break;
                case 7:
                    Console.WriteLine("The Day is Saturday.\n");
                    break;
                default:
                    Console.WriteLine("No Match found.\n");
                    break;
            }


        



        }
    }   
}

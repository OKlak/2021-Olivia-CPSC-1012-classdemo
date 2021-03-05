using System;

namespace feb22_demo
{
    class Program
    {
        //Main() is a method
        //special method
        //entry point into your program execution
        static void Main(string[] args)
        {
            /*
             * PROCESS
             * this program will demomstrate methods, menu looping and various styles of File Input/Output
             * 
             * create a post-loop (do/while) to handle the menu
                * the menu will have 3 options, one for each type of File I/O style
             * 
             *methods will be used to obtain the file name to be read for this program
                *the methods will have no incoming parameter, will return a string data type
             *
             *the reading an display of the file will be placed in a seperate method
                *method will have a string incoming parameter, will not return anything (void datatype)
                *the method will demonstrate error handling using Try/Catch/Final
             */


            string input;


            //post loop structure, used to control menu 
            do
            {
                Console.WriteLine("File I/O options: ");
                Console.WriteLine("a) Hard-coded file name");
                Console.WriteLine("b) Using Windows Environment (Desktopk, Documents, Downloads) path file name");
                Console.WriteLine("c) Using Openfile dialog to obtain file name");
                Console.WriteLine("x) Exit\n");

                Console.Write("Enter the menu option for File I/O");
                input = Console.ReadLine();
                switch(input.ToUpper())
                {
                    case "A":
                        {
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    case "C":
                        {
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($" {input} is not a valid menu option. Try again.");
                            break;
                        }
                }

            } while (input.ToUpper() != "X");


        }
        /*Methods
         * 
         *why
         *reduce code redundancy
         *break up your code into smaller managable pieces (modularization)
         *
         *where do methods go?
         *methods go into your program class
         *
         *Syntax for a method
         *acesstype returndatatype MethodName ([list of parameters])
         *{
         *coding block
         *}
         *
         *acesstype?
         *this is dependant on what is the Main acess type or if the class is Not the entry point to your entire application
         *could be public, private, internal, protected, ...
         *
         *returndatatype
         *Methods have been called by many names
         *methods have been called subroutines, functions, methods
         *no data to the calling statement; where as functions will return data to the calling statement
         *the return datatype must be  valid lanuguage datatype
         *the reutn datatype in C# that returns nothing is the keyword void
         *
         *MethodName
         *This is what the method is called
         *the method name is usually unique
         *the method names that are not unique are paird with their list of parameters to create a method signature.
         *the method signatuer Must be unique. this is referred to as overload methods
         *
         *What is a parameter?
         *datatype parametername
         *
         *what is a list of parameters? (optional)
         *datatype parametername, datatype parametername, ....
         */
        static string HardCodedFileName()
        {
            //setup a path name to the folder on your computer that contains the file to be read
            string Folder_Pathname = @"E:\GitHub\CPSC-1012\2021-Olivia-CPSC-1012-classdemo\";

            //concatenate a file name to the pathname
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";

            //BECAUSE the method indicates a returned datatype of string (anything but void) the method REQUIRES
            //a return xxx; statement
            return Full_Path_Filename;

        }
    }
}

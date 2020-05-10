using System;
using System.Linq;
using System.IO;

namespace C__first_parsing_assignment
{
  class Program
  {
   
    
    static void Main(string[] args)
    {
      bool Thisistheend = false;
      string filename = "";
      string userInput = "";
     
      while ( !Thisistheend ) {
        Console.WriteLine("Please type in an option:");
        userInput = Console.ReadLine();
        switch ( userInput ) {
          case "1":
            Console.WriteLine("Please enter an existing filename:");
            filename=Console.ReadLine();
            if ( !File.Exists( filename ) ) {
               Console.WriteLine( "Oops!!!No file found, to choose an existing file, kindly choose option 1." );
            }
            break;
          case "2":
            Console.WriteLine("Please enter the specific string to be removed or replaced from the file:");
            string stringToReplace = Console.ReadLine();
            if (File.Exists(filename)) {
              string readFileContent = File.ReadAllText(filename);
              string[] theText = readFileContent.Split(stringToReplace);
              string textDisplay ="";
              foreach ( string part in theText ) {
                textDisplay = textDisplay + part + " " ;
              }
              File.WriteAllText( filename, textDisplay );
            } else {
               Console.WriteLine( "Oops!!!No file found, to choose an existing file, kindly choose option 1." );
            }
            break;
          case "3":
            Thisistheend = true;
            Console.WriteLine("Sorry to see you go.This is the end");
            break;
          default:
            Console.WriteLine("Not a valid option chosen. Please choose from 1 to 3");
            
           Console.WriteLine("please insert an option from 1 to 3:");
           Console.WriteLine("1 is to input a filename.");
           Console.WriteLine("2 is to input a string to be accessed.");
            Console.WriteLine("3 is to exit the program.");;
            break;
        }
      }
    }
  }
}
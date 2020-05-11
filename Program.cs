using System;
using System.Linq;
using System.IO;
namespace parser_c__assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            bool endofinput = false;
            string fileString = "";
            string fileName = "";


            while (!endofinput)
            {
                Console.WriteLine("Enter the filename");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine(" Enter the Input");
                        fileName = Console.ReadLine();
                        if (!File.Exists(fileName))
                        {
                            System.Console.WriteLine("File name does not exist..");
                        }
                        break;
                    case "2":

                        Console.WriteLine("Enter a string:");
                        fileString = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            string fileContent = File.ReadAllText(fileName);
                            string[] fileText = fileContent.Split(fileString);
                            string showText = "";

                            foreach (string words in fileText)
                            {
                                showText = showText + words + " ";
                            }
                            File.WriteAllText(fileName, showText);
                        }
                        else
                        {
                            Console.WriteLine("Filename does not exist!! Enter option 1 to choose another filename.");
                        }
                        break;

                    case "3":
                        endofinput = true;
                        Console.WriteLine("Exiting the loop");
                        break;
                    default:
                        Console.WriteLine("Enter invalid entry choose another InputValue");
                        System.Console.WriteLine("Enter the Option: ");
                        System.Console.WriteLine("Enter the Input, press key number1");
                        System.Console.WriteLine("Enter the string , press key number 2");
                        System.Console.WriteLine("Exit from the file , press key number 3");
                        break;

                }

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace namesorted
{
    class MainClass
    {
        // Declare variables
        public string filePath;
        public List<string> names = new List<string>();

        public static void Main(string[] args)
        {
            // Specify when program has begun
            Console.WriteLine("start");

            // Specify filepath 
            string filePath = "/Users/jackson/Desktop/names"; // args[0] <- change to this

            // Apply functions
            MainClass nameGetter = new MainClass(filePath);
            nameGetter.readFile();
            nameGetter.SortNames();
            nameGetter.WriteToFile();

            // Alert user that program is complete
            Console.WriteLine("done");
        }

        // This is our constructor
        public MainClass(string filePath1)
        {
            filePath = filePath1;
        }

        // Function to read file
        public void readFile()
        {
            names = File.ReadAllLines(filePath).ToList();
        }

        // Function to sort names
        public void SortNames()
        {
            bool sorted = false;

            for (int column = 2; column >= 0; column--)
            {

                while (sorted == false)
                {
                    sorted = true;

                    for (int i = 1; i < names.Count; i++)
                    {

                        string[] tempArray2 = names[i].Split(' ');
                        string[] tempArray1 = names[i - 1].Split(' ');

                        // check to see if array one or two is higher ranked
                        int result = string.Compare(tempArray1[tempArray1.Length - column], tempArray2[tempArray2.Length - column]);

                        if (result == 1)
                        {
                            string tempString = names[i];
                            names[i] = names[i - 1];
                            names[i - 1] = tempString;
                            sorted = false;
                        }
                    }
                }
            }

            // sort by last name
            // start one item down the start and compare with the item above
            sorted = false;

            while (sorted == false)
            {
                sorted = true;

                for (int i = 1; i < names.Count; i++)
                {

                    string[] tempArray2 = names[i].Split(' ');
                    string[] tempArray1 = names[i - 1].Split(' ');

                    // check to see if array one or two is higher ranked
                    int result = string.Compare(tempArray1[tempArray1.Length - 1], tempArray2[tempArray2.Length - 1]);

                    if (result == 1)
                    {
                        string tempString = names[i];
                        names[i] = names[i - 1];
                        names[i - 1] = tempString;
                        sorted = false;
                    }
                }
            }
            // print sorted sorted names 
            Console.WriteLine("sorted names");
            names.ForEach(Console.WriteLine);
        }

        // Function to write to file
        public void WriteToFile()

        {
            // Write to file
            File.WriteAllLines("/Users/jackson/Desktop⁩", names);

        }
    }
}
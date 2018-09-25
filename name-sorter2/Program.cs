using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


/* 

SOLID FRAMEWORK
Single responsibility principle[6]
a class should have only a single responsibility(i.e.changes to only one part of the software's specification should be able to affect the specification of the class).
Open/closed principle[7]
"software entities … should be open for extension, but closed for modification."
Liskov substitution principle[8]
"objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." See also design by contract.
Interface segregation principle[9]
"many client-specific interfaces are better than one general-purpose interface."[4]
Dependency inversion principle[10]
one should "depend upon abstractions, [not] concretions."[4]
*/




namespace namesorted
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // specify when program has begun
            Console.WriteLine("start");

            // specify the path of the file to open. This is only temporary, will use arg in final program.
            string filePath = args[0];

            // append the txt file to a T list
            List<string> names = File.ReadAllLines(filePath).ToList();

            bool sorted = false;

            //// sort from first to last name
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
                    int result = string.Compare(tempArray1[tempArray1.Length-1], tempArray2[tempArray2.Length-1]);

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


            // Write to file
            File.WriteAllLines("sorted-names-list.txt", names);

            // Alert user that program is complete
            Console.WriteLine("done");
        }
    }
}


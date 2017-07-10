using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Scenario6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                Console.WriteLine("Would you like to read (R) or write (w) onto Customers.xml?");
                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "R" || choice == "r")
                {
                    readXML();
                    Console.WriteLine();
                }

                else if (choice == "W" || choice == "w")
                {
                    editXML();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Could not understand command.");
                    break;
                }

                Console.WriteLine("Do you want to run the program again? (y/n)");
                choice = Console.ReadLine();

            } while (choice == "Y" || choice == "y");

            Console.WriteLine();
            Console.WriteLine("End of program.");
        }

        static void readXML()
        {
            using (XmlReader reader = XmlReader.Create("Customers.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "CompanyName":
                                if (reader.Read())
                                {
                                    Console.Write("Company Name: {0}, ", reader.Value);
                                }
                                break;
                            case "Phone":
                                if (reader.Read())
                                {
                                    Console.WriteLine("Phone: {0}, ", reader.Value);
                                }
                                break;
                        }
                    }
                }

            }
        }

        static void editXML()
        {
            Console.WriteLine("What is the Customer ID of the customer you wish to add to the XML?");
            string customerID = Console.ReadLine();
            Console.WriteLine("\nWhat is the Company Name of the customer you wish to add to the XML?");
            string companyName = Console.ReadLine();
            Console.WriteLine("\nWhat is the Phone Number of the customer you wish to add to the XML?");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You have entered the following values:");
            Console.WriteLine();
            Console.WriteLine("Customer ID:{0}", customerID);
            Console.WriteLine("Company Name:{0}", companyName);
            Console.WriteLine("Phone Number:{0}", phoneNumber);
            Console.WriteLine();
            Console.WriteLine("Is this data correct? (y/n)");
            string choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
            {
                XDocument doc = XDocument.Load("Customers.xml");
                XElement customers = doc.Element("Customers");
                customers.Add(new XElement("Customer", new XAttribute("Id", customerID),
                              new XElement("CompanyName", companyName),
                              new XElement("Phone", phoneNumber)));
                doc.Save("Customers.xml");
            }
            else
            {
                Console.WriteLine("XML editing was terminated.");
            }
        }
    }
}

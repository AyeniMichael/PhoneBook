using System;
using System.Collections.Generic;

class PhoneBook
{
    public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>() {};
    
    static void Main()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("Would you like to save a Number? y/Y for yes & n/N for No");
        string reply = Console.ReadLine();
        if (reply == "Y" || reply == "y")
        {
            AddContact();
        }
        else
        {
            Console.WriteLine("Would you Like to Lookup a number? y/Y for yes & n/N for No");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                LookUpContact();
            }
            else
            {
                Console.WriteLine("Are you finished with the program? y/Y for yes & n/N for No");
                string feedback = Console.ReadLine();
                if (feedback == "y" || feedback == "Y")
                {
                    Console.WriteLine("Goodbye");
                } 
                else
                {
                    Main();
                }
            }
        }
    }

    static void AddContact()
    {
        Console.WriteLine("Enter contact name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter contact number:");
        string number = Console.ReadLine();

        if (phoneNumbers.ContainsKey(name))
        {
            Console.WriteLine("The contact already exist and the number is "+phoneNumbers[name]);
        }
        else
        {
            phoneNumbers.Add(name, number);
        }
        Main();
    }

    static void LookUpContact()
    {
        Console.WriteLine("Enter the contact name:");
        string contactName = Console.ReadLine();
        if (phoneNumbers.ContainsKey(contactName))
        {
            Console.WriteLine("The contact "+contactName+"'s number is "+phoneNumbers[contactName]);
        }
        else
        {
            Console.WriteLine("The contact does not exist");
        }
        Main();
    }
}
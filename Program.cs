using System;
using System.Diagnostics;

namespace MultiValueDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string command="",key = "",value = "";
            Console.WriteLine("Enter exit to quit");
            Console.WriteLine("Enter one of the following commands to perform the desired operation: ");
            PrintMenu();
            do
            {
                Console.WriteLine("Enter one of the menu commands to perform the desired operation: ");
                
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter Value");
                        value = Console.ReadLine();
                        var success = Commands.Add(key, value);
                        if(success) Console.WriteLine("Added");
                        break;
                    case "keys":
                        Commands.PrintKeys();
                        break;
                    case "memberexists":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter Value");
                        value = Console.ReadLine();
                        Console.WriteLine(Commands.MemberExists(key, value));
                        break;
                    case "allmembers":
                        Commands.PrintAllMembers();
                        break;
                    case "keyexists":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine(Commands.KeyExists(key));
                        break;
                    case "members":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Commands.PrintMembers(key);
                        break;
                    case "remove":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Console.WriteLine("Enter Value");
                        value = Console.ReadLine();
                        Commands.Remove(key, value);
                        break;
                    case "removeall":
                        Console.WriteLine("Enter Key");
                        key = Console.ReadLine();
                        Commands.RemoveAll(key);
                        break;
                    case "clear":
                        Commands.Clear();
                        break;
                    case "items":
                        Commands.Items();
                        break;
                    case "menu":
                        PrintMenu();
                        break;
                    default:
                        break;
                }
            } while (command != "exit");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Menu --> To display the menu ");
            Console.WriteLine("Add --> To Add an element to the dictionary ");
            Console.WriteLine("Keys --> To print all the elements in the dictionary ");
            Console.WriteLine("MemberExists --> To Check if the member exists in the dictionary for the given key");
            Console.WriteLine("AllMembers --> To print all the members in the dictionary ");
            Console.WriteLine("keyexists --> To check if the key exists in the dictionary ");
            Console.WriteLine("Members --> To print all the members in the dictionary ");
            Console.WriteLine("Remove --> To remove a member from the dictionary ");
            Console.WriteLine("RemoveAll --> To remove all the members for a key in the dictionary ");
            Console.WriteLine("Clear --> To remove all the keys and members from the dictionary ");
            Console.WriteLine("Items --> To print all the keys and the members in the dictionary ");
        }
    }
}

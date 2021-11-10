using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            bool decide = true;
            int n;
            Console.WriteLine("Welcome to Address Book.");
            AddressBook obj1 = new AddressBook(); //creating object

            while (decide)
            {

                Console.WriteLine("1.AddNewContact\n2.PrintContact\n3.EditContact\n4.DeleteContact\n5.Exit");
                Console.WriteLine("\nPlease Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Please enter how many contact you want to add");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            obj1.getContactDetails();
                            Console.WriteLine("\n");

                        }
                        break;
                    case 2:
                obj1.printDetails(); //printing data
                        break;
                    case 3:
                        obj1.editContact();
                      
                        break;

                    case 4:
                        obj1.removeContact();
                        break;

                    case 5:
                        decide = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter The Valid Data");
                        break;
                }
               


            }
           

            Console.ReadLine();

        }
    }
}

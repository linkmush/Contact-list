﻿using ConsoleApp.Models;

using ConsoleApp.Services;

public class ContactMenu
{
    private readonly ContactServices _contactServices = new ContactServices();

    public void ShowMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1. Add a user");
            Console.WriteLine("2. Show all contacts");
            Console.WriteLine("3. Exit");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowAddMenu();
                    break;
                case "2":
                    ShowAllMenu();
                    break;
                case "3":
                    goto Exit;
                default:
                    Console.WriteLine("Invalid option, please try again");
                    break;
            }

            Console.ReadKey();
        }

        Exit: // Exit för att avsluta loopen
        Console.WriteLine("Exiting..");
    }

    private void ShowAddMenu()
    {
        var user = new Contacts();

        Console.Clear();
        Console.WriteLine("Enter First Name:  ");
        user.FirstName = Console.ReadLine()!;

        Console.WriteLine("Enter Last Name:  ");
        user.LastName = Console.ReadLine()!;

        Console.WriteLine("Enter Email:  ");
        user.Email = Console.ReadLine()!;

        Console.WriteLine("Enter phone number:  ");
        user.PhoneNumber = Console.ReadLine()!;

        Console.WriteLine("Enter street name:  ");
        user.StreetName = Console.ReadLine()!;

        Console.WriteLine("Enter postal code:  ");
        user.PostalCode = Console.ReadLine()!;

        Console.WriteLine("Enter city:  ");
        user.City = Console.ReadLine()!;

        _contactServices.AddContactToList(user);

    }

    private void ShowAllMenu()
    {
        var users = _contactServices.GetUsersFromList();

        int count = 1;
        foreach (var user in users)
        {
            Console.WriteLine();
            Console.WriteLine($"{count}. ");
            Console.WriteLine($"{user.FirstName} {user.LastName} ");
            Console.WriteLine($"{user.Email} ");
            Console.WriteLine($"{user.PhoneNumber} ");
            Console.WriteLine($"{user.StreetName} ");
            Console.WriteLine($"{user.PostalCode} ");
            Console.WriteLine($"{user.City} ");
            Console.WriteLine();

            count++;
        }
    }
}

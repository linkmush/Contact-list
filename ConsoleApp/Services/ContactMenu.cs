using ConsoleApp.Enums;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;

using ConsoleApp.Services;
using System;

public interface IContactMenu
{
    void ShowMainMenu();
}

public class ContactMenu : IContactMenu
{
    private readonly IContactService _contactService = new ContactServices();

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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again");
                    break;
            }

            Console.ReadKey();
        }

    }

    private void ShowAddMenu()
    {
        IContacts contacts = new Contacts();

        Console.Clear();
        Console.WriteLine("Enter First Name:  ");
        contacts.FirstName = Console.ReadLine()!;

        Console.WriteLine("Enter Last Name:  ");
        contacts.LastName = Console.ReadLine()!;

        Console.WriteLine("Enter Email:  ");
        contacts.ContactInformation.Email = Console.ReadLine()!;

        Console.WriteLine("Enter phone number:  ");
        contacts.ContactInformation.PhoneNumber = Console.ReadLine()!;

        Console.WriteLine("Enter street name:  ");
        contacts.ContactAddress.StreetName = Console.ReadLine()!;

        Console.WriteLine("Enter postal code:  ");
        contacts.ContactAddress.PostalCode = Console.ReadLine()!;

        Console.WriteLine("Enter city:  ");
        contacts.ContactAddress.City = Console.ReadLine()!;

        var res = _contactService.AddContactToList(contacts);

        switch (res.Status)
        {
            case ServiceStatus.SUCCESSED:
                Console.WriteLine("The contact was added successfully");
                break;

            case ServiceStatus.ALREADY_EXIST:
                Console.WriteLine("The contact already exist");
                break;

            case ServiceStatus.FAILED:
                Console.WriteLine("Error when trying to add contact");
                Console.WriteLine("See error message :: " + res.Result.ToString());
                break;
        }

    }

    private void ShowAllMenu()
    {
        var result = _contactService.GetContactsFromList();

        if (result.Status == ServiceStatus.SUCCESSED)
        {
            var users = result.Result as List<Contacts>;

            if (users != null && users.Any())
            {
                int count = 1;
                foreach (var user in users)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{count}. ");
                    Console.WriteLine($"{user.FirstName} {user.LastName} ");
                    Console.WriteLine($"{user.ContactInformation.Email} ");
                    Console.WriteLine($"{user.ContactInformation.PhoneNumber} ");
                    Console.WriteLine($"{user.ContactAddress.StreetName} ");
                    Console.WriteLine($"{user.ContactAddress.PostalCode} ");
                    Console.WriteLine($"{user.ContactAddress.City} ");
                    Console.WriteLine();

                    count++;
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }
        else
        {
            Console.WriteLine("Failed to retrieve contacts.");
        }
    }
}

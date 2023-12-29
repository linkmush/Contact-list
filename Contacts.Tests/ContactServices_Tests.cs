using ClassLibrary.Shared.Enums;
using ClassLibrary.Shared.Interfaces;
using Models = ClassLibrary.Shared.Models;
using ClassLibrary.Shared.Services;
using Moq;

namespace contacts.Tests;

public class ContactServices_Tests
{
    [Fact]
    public void AddToList_ShouldAddContactToList_ThenReturnSuccessed()
    {
        // Arrange
        IContacts contacts = new Models.Contacts
        {
            FirstName = "Oskar",
            LastName = "Lindqvist",
            ContactInformation = new Models.ContactInformation { Email = "oskar@domain.com", PhoneNumber = "0701956489" },
            ContactAddress = new Models.ContactAddress { StreetName = "hittapågatan 123", PostalCode = "12345", City = "Göteborg" }
        };

        var MockFileService = new Mock<IFileService>();
        IContactService contactService = new ContactServices(MockFileService.Object);

        // Act
        IServiceResult serviceResult = contactService.AddContactToList(contacts);

        // Assert
        Assert.Equal(ServiceStatus.SUCCESSED, serviceResult.Status);
    }

    [Fact]

    public void GetAllFromList_ShouldGetAllContactsFromList_ThenReturnListOfContacts()
    {
        // Arrange

        var mockFileService = new Mock<IFileService>();
        IContactService contactService = new ContactServices(mockFileService.Object);
        IContacts contacts = new Models.Contacts
        {
            FirstName = "Oskar",
            LastName = "Lindqvist",
            ContactInformation = new Models.ContactInformation { Email = "oskar@domain.com", PhoneNumber = "0701956489" },
            ContactAddress = new Models.ContactAddress { StreetName = "hittapågatan 123", PostalCode = "12345", City = "Göteborg" }
        };
        contactService.AddContactToList(contacts);

        // Act
        IServiceResult serviceResult = contactService.GetContactsFromList();

        // Assert
        Assert.NotNull(serviceResult);
        Assert.Equal(ServiceStatus.SUCCESSED, serviceResult.Status);
    }
}

using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Models.Responses;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ConsoleApp.Services;

public class ContactServices : IContactService
{
    private List<IContacts> _contacts = [];
    private readonly FileService _fileService = new FileService(@"C:\Projects\Contact-list\content.json");

    IServiceResult IContactService.AddContactToList(IContacts contacts)
    {
        IServiceResult response = new ServiceResult();

        try
        {
            if (!_contacts.Any(x => x.ContactInformation.Email == contacts.ContactInformation.Email))
            {
                _contacts.Add(contacts);
                _fileService.SaveContentToFile(JsonConvert.SerializeObject(_contacts, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects }));
                response.Status = Enums.ServiceStatus.SUCCESSED;
            }
            else
            {
                response.Status = Enums.ServiceStatus.ALREADY_EXIST;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    IServiceResult IContactService.DeleteContactFromList()
    {
        IServiceResult response = new ServiceResult();

        try
        {

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    IServiceResult IContactService.GetContactFromList(string email)
    {
        IServiceResult response = new ServiceResult();

        try
        {
            var content = _fileService.GetContentFromFile();
            if (!string.IsNullOrEmpty(content))
            {
                _contacts = JsonConvert.DeserializeObject<List<IContacts>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects })!;

                var contact = _contacts.FirstOrDefault(x => x.ContactInformation.Email == email);

                if (contact != null)
                {
                    response.Status = Enums.ServiceStatus.SUCCESSED;
                    response.Result = contact;
                }
                else
                {
                    response.Status = Enums.ServiceStatus.NOT_FOUND;
                    response.Result = "Contact not found.";
                }
            }

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    IServiceResult IContactService.GetContactsFromList()
    {
        IServiceResult response = new ServiceResult();

        try
        {
            var content = _fileService.GetContentFromFile();
            if (!string.IsNullOrEmpty(content))
            {
                _contacts = JsonConvert.DeserializeObject<List<IContacts>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects })!;
                response.Status = Enums.ServiceStatus.SUCCESSED;
                response.Result = _contacts;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }

    IServiceResult IContactService.UpdateContactInList()
    {
        IServiceResult response = new ServiceResult();

        try
        {

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceStatus.FAILED;
            response.Result = ex.Message;
        }

        return response;
    }
}
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Models.Responses;
using System.Diagnostics;

namespace ConsoleApp.Services;

public class ContactServices : IContactService
{
    private static readonly List<IContacts> _contacts = [];

    IServiceResult IContactService.AddContactToList(IContacts contacts)
    {
        IServiceResult response = new ServiceResult();

        try
        {
            if (!_contacts.Any(x => x.ContactInformation.Email == contacts.ContactInformation.Email))
            {
                _contacts.Add(contacts);
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

    IServiceResult IContactService.GetContactFromList()
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

    IServiceResult IContactService.GetContactsFromList()
    {
        IServiceResult response = new ServiceResult();

        try
        {
            response.Status = Enums.ServiceStatus.SUCCESSED;
            response.Result = _contacts.Cast<Contacts>().ToList();
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

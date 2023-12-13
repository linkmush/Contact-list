using ClassLibrary.Shared.Interfaces;

namespace ClassLibrary.Shared.Interface
{
    public interface IFileService
    {
        string GetContentFromFile();
        bool SaveContentToFile(string content);
        bool UpdateContactListToFile(List<IContacts> contacts);

    }
}

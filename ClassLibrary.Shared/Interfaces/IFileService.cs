namespace ClassLibrary.Shared.Interfaces;

public interface IFileService
{
    /// <summary>
    /// Get content as string from a filepath.
    /// </summary>
    /// <param name="filepath">Enter the filepath with extension (eg. C:\Projects\Contact-list\content.json)</param>
    /// <returns>Returns file content as string if file exists, or returns null.</returns>
    string GetContentFromFile();

    /// <summary>
    /// Save contact to a filepath.
    /// </summary>
    /// <param name="filepath">Enter the filepath with extension (eg. C:\Projects\Contact-list\content.json)</param>
    /// <param name="content">Enter the contact as a string.</param>
    /// <returns>Returns success if true, if failed return failed.</returns>
    bool SaveContentToFile(string content);

    /// <summary>
    /// Remove contact from file and then updates the json file/list.
    /// </summary>
    /// <param name="filepath">Enter the filepath with extension (eg. C:\Projects\Contact-list\content.json)</param>
    /// <param name="contacts">Enter the contact as a string.</param>
    /// <returns>Returns success if contact was deleted, if failed return failed.</returns>
    bool UpdateContactListToFile(List<IContacts> contacts);
}

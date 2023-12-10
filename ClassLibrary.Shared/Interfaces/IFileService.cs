namespace ClassLibrary.Shared.Interface
{
    public interface IFileService
    {
        string GetContentFromFile();
        bool SaveContentToFile(string content);
    }
}

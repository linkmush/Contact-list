namespace ConsoleApp.Interface
{
    public interface IFileService
    {
        string GetContentFromFile();
        bool SaveContentToFile(string content);
    }
}

﻿using ClassLibrary.Shared.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ClassLibrary.Shared.Services;

public class FileService(string filepath) : IFileService
{
    private readonly string _filepath = filepath;

    public bool SaveContentToFile(string content)
    {
        try
        {
            using (var sw = new StreamWriter(_filepath))
            {
                sw.WriteLine(content);
            }

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public string GetContentFromFile()
    {
        try
        {
            if (File.Exists(_filepath))
            {
                using var sr = new StreamReader(_filepath);
                return sr.ReadToEnd();
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public bool UpdateContactListToFile(List<IContacts> contacts)
    {
        try
        {
            var serializedContacts = JsonConvert.SerializeObject(contacts, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects });

            using (var sw = new StreamWriter(_filepath))
            {
                sw.Write(serializedContacts);
            }

            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}


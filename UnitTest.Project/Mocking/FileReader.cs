using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitProject.Mocking
{
    public interface IFileReader
    {
        string Read(string path);
    }
    public class FileReader: IFileReader
    {
        public string Read(string path)
        {
           return File.ReadAllText(path);
        }
    }
}

using pr1f.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pr1f.Services
{
    public class FileService<T> : IFileReader<T>, IFileWriter<T> where T : class
    {
        public T ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(json);
            }

            return default;
        }

        public void WriteToFile(string filePath, T content)
        {
            if (File.Exists(filePath))
            {
                var json = JsonSerializer.Serialize(content);
                File.WriteAllText(filePath, json);
            }
            else
            {
                File.Create(filePath).Close();
                WriteToFile(filePath, content);
            }
        }
    }
}

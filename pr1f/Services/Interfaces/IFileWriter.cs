using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services.Interfaces
{
    public interface IFileWriter<T> where T : class
    {
        void WriteToFile(string filePath, T content);
    }
}

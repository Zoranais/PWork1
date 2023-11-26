using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services.Interfaces
{
    public interface IFileReader<T> where T : class
    {
        T ReadFromFile(string path);
    }
}

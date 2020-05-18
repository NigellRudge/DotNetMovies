using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Services
{
    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Search(string searchTerm);
    }
}

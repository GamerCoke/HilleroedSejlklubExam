using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;

namespace HSLibrary.Interfaces
{
    public interface IBlogRepository
    {
        int Count {  get; }
        void Add(Blog blog);
        void Remove(int id);
        Blog Get(int id);
        List<Blog> GetAll();
        List<Blog> GetAllOnDate(DateOnly Date);
    }
}

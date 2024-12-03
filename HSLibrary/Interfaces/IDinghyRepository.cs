using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;

namespace HSLibrary.Interfaces
{
    public interface IDinghyRepository
    {
        int Count { get; }
        void Add(Dinghy dinghy);
        void Remove(int id);
        Dinghy Get(int id);
        List<Dinghy> GetAll();
        List<Dinghy> GetAllNeedingRepairs();
        List<Dinghy> GetAllBooked();
        List<Dinghy> GetAllUnbooked();
        List<Dinghy> GetAllOfModel(string model);
    }
}

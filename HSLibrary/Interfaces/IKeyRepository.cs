﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;

namespace HSLibrary.Interfaces
{
    public interface IKeyRepository
    {
        int Count { get; }
        void Add(Key key);
        void Remove(int id);
        Key Get(int id);
        List<Key> GetAll();
        List<Key> GetAllAssigned();
        List<Key> GetAllUnassigned();
        List<Key> GetAllAssignedToMember(Member member);
    }
}

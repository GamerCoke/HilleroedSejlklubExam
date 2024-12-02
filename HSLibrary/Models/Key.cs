﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Models
{
    public class Key
    {
        private static int _count = 0;
        private Member _assignedMember;
        public int Id { get; }
        public Member AssignedMember
        {
            get
            {
                return _assignedMember;
            }
        }
        public bool IsAssigned
        {
            get
            {
                return _assignedMember != null;
            }
        }
        public Key()
        {
            Id = _count++;
            _assignedMember = null;
        }
        public void AssignMember(Member member)
        {
            _assignedMember = member;
        }
        public void UnassignMember()
        {
            _assignedMember = null;
        }
        public override string ToString()
        {
            return $"Key #{Id} | AssignedToMember: {_assignedMember.Name}";
        }
    }
}

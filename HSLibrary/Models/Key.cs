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
        private KeyType _keyType;
        private Member _assignedMember;
        public int Id { get; }
        public Member Member
        {
            get
            {
                return _assignedMember;
            }
        }
        public KeyType KeyType
        {
            get
            {
                return _keyType;
            }
        }
        public Key(KeyType keyType)
        {
            Id = _count++;
            _keyType = keyType;
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
            return $"Key #{Id} | KeyType: {_keyType} | AssignedToMember: {_assignedMember}";
        }
    }
}

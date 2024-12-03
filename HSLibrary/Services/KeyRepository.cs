using HSLibrary.Interfaces;
using HSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Services
{
    public class KeyRepository : IKeyRepository
    {
        Dictionary<int, Key> _keys;
        public int Count
        {
            get
            {
                return _keys.Count;
            }
        }
        public KeyRepository()
        {
            _keys = new Dictionary<int, Key>();
        }

        public void Add(Key key)
        {
            _keys.Add(key.Id, key);
        }

        public Key Get(int id)
        {
            return _keys[id];
        }

        public List<Key> GetAll()
        {
            List<Key> keys = new List<Key>();
            foreach (Key key in _keys.Values)
            {
                keys.Add(key);
            }
            return keys;
        }

        public List<Key> GetAllAssigned()
        {
            List<Key> keys = new List<Key>();
            foreach (Key key in _keys.Values)
            {
                if(key.IsAssigned) keys.Add(key);
            }
            return keys;
        }

        public List<Key> GetAllAssignedToMember(Member member)
        {
            List<Key> keys = new List<Key>();
            foreach (Key key in _keys.Values)
            {
                if (key.AssignedMember == member) keys.Add(key);
            }
            return keys;
        }

        public List<Key> GetAllOfType(KeyType keyType)
        {

            List<Key> keys = new List<Key>();
            foreach (Key key in _keys.Values)
            {
                if (key.KeyType == keyType) keys.Add(key);
            }
            return keys;
        }

        public List<Key> GetAllUnassigned()
        {
            List<Key> keys = new List<Key>();
            foreach (Key key in _keys.Values)
            {
                if (!key.IsAssigned) keys.Add(key);
            }
            return keys;
        }

        public void Remove(int id)
        {
            _keys.Remove(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Models
{
    public class Member
    {
        private static int _count = 0;
        public int Id { get; }
        public string Name { get; set; }

        public Member()
        {
            Id = _count++;
        }
    }
}

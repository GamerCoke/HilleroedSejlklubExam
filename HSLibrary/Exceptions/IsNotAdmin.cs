using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;

namespace HSLibrary.Exceptions
{
    public class IsNotAdmin : Exception
    {
        private Member _member;
        public IsNotAdmin(Member member)
        {
            _member = member;
        }
        public override string ToString()
        {
            return $"Brugeren {_member.Name} er ikke admin";
        }
    }
}

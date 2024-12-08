using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HSLibrary.Models
{
    public class Team
    {
        private static int _count = 0;

        public int Id { get; }
        public Member Trainer { get;}
        public Participants Participants { get;}

        public Team(Member trainer, Participants participants)
        {
            Id = _count++;
            Trainer = trainer;
            Participants = participants;
        }
        public override string ToString()
        {
            return $"Hold ID: {Id} - Træner: {Trainer} - Holdmedlemmer: {Participants}";
        }
    }
}

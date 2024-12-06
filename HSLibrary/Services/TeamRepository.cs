using HSLibrary.Interfaces;
using HSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Services
{
    internal class TeamRepository : ITeamRepository
    {
        Dictionary<int, Team> _teams;
        public int Count 
        { 
            get 
            { 
                return _teams.Count; 
            } 
        }

        public TeamRepository()
        {
            _teams = new Dictionary<int, Team>();
        }

        public void Add(Team team)
        {
            _teams.Add(team.Id, team);
        }

        public Team Get(int id)
        {
            return _teams[id];
        }

        public List<Team> GetAll()
        {
           return _teams.Values.ToList();
        }

        public List<Team> GetAllByMember(Member member) //måske by trainer?
        {
            List<Event> list = new List<Event>();
            foreach (Team team in _teams.Values)
            {
                if (team.Trainer == member) list.Add(team);
            }
            return list;
        }

        public void Remove(int id)
        {
            _teams.Remove(id);
        }
    }
}

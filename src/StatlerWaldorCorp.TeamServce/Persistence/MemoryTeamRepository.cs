using System;
using System.Collections.Generic;
using System.Linq;
using StatlerWaldorCorp.TeamServce.Models;

namespace  StatlerWaldorCorp.TeamServce.Persistence
{
    public class MemoryTeamRepository : ITeamRepository
    {
        protected ICollection<Team> teams;

        public MemoryTeamRepository()
        {
            if(teams == null){
                teams = new List<Team>();
            }
        }

        public MemoryTeamRepository(ICollection<Team> teams)
        {
           this.teams = teams; 
        }
        public IEnumerable<Team> List()
        {
            return teams;
        }

        public Team Get(Guid id)
        {
            return teams.FirstOrDefault(t=>t.ID == id);
        }

        public Team Add(Team team)
        {
               teams.Add(team);
               return team;
        }

        public Team Update(Team team)
        {
            Team updatedTeam = this.Delete(team.ID);
            if(updatedTeam != null) {
                updatedTeam = this.Add(team);
            }
            return updatedTeam;
        }

        public Team Delete(Guid id)
        {
        var q = teams.Where(t => t.ID == id);
        Team team = null;

            if(q.Count() > 0) {
                team = q.First();
                teams.Remove(team);
            }
            return team;
        }
    }
}
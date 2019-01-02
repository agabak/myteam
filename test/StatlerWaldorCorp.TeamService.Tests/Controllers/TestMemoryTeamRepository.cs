using System;
using System.Collections.Generic;
using StatlerWaldorCorp.TeamServce.Models;
using StatlerWaldorCorp.TeamServce.Persistence;

namespace StatlerWaldorCorp.TeamServce.Tests.Controllers
{
    public class TestMemoryTeamRepository : MemoryTeamRepository
    {
        public TestMemoryTeamRepository():base(CreateInitialFake())
        {
            
        }

        private static ICollection<Team> CreateInitialFake()
        {
            var teams = new List<Team>();
            teams.Add(new Team("one"));
            teams.Add(new Team("two"));
            return teams;
        }
    }
}
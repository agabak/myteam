using Xunit;
using StatlerWaldorCorp.TeamServce.Models;
using System.Collections.Generic;
using StatlerWaldorCorp.TeamServce.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace StatlerWaldorCorp.TeamServce.Tests.Controllers
{

    public class TeamControllerTest
    {
       
        [Fact]
       public void  QueryTeamListReturnCollectTeams()
       {
            TeamController controller = new TeamController(new TestMemoryTeamRepository());
            var rawTeams = (IEnumerable<Team>)(controller.GetAllTeams() as ObjectResult).Value;
            List<Team> teams = new List<Team>(rawTeams);
            Assert.Equal(teams.Count, 2);
            Assert.Equal(teams[0].Name, "one");
            Assert.Equal(teams[1].Name,"two");
       }

       [Fact]
       public  void CreateTeamAddToList()
       {
           TeamController controller = new TeamController(new TestMemoryTeamRepository());
             var teams = (IEnumerable<Team>)(controller.GetAllTeams() as ObjectResult).Value;
             List<Team> original = new List<Team>(teams);

             Team t = new Team("Sample");
             var result =   controller.CreateTeam(t);

             var newTeamRaw = (IEnumerable<Team>)( controller.GetAllTeams() as ObjectResult).Value;

             List<Team> newTeams = new List<Team>(newTeamRaw);

             Assert.Equal(newTeams.Count, original.Count + 1);

             var sampleTeam = newTeams.FirstOrDefault(target => target.Name == "Sample");

             Assert.NotNull(sampleTeam);
       }
    }
}

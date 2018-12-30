using Xunit;
using StatlerWaldorCorp.TeamServce.Models;
using System.Collections.Generic;
using StatlerWaldorCorp.TeamServce.Controllers;

namespace StatlerWaldorCorp.TeamServce.Tests.Controllers
{

    public class TeamControllerTest
    {
       TeamController controller = new TeamController();
        [Fact]
       public void  QueryTeamListReturnCollectTeams()
       {
            
            List<Team> teams = new List<Team>(controller.GetAllTeams());

            Assert.Equal(teams.Count, 2);
       }
    }
}

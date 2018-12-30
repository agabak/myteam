using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorCorp.TeamServce.Models;

namespace StatlerWaldorCorp.TeamServce.Controllers
{ 
    public class TeamController:Controller
    {
        
        public TeamController()
        {
            
        }

        public IEnumerable<Team>  GetAllTeams()
        {
            return new Team[] {new Team("one"), new Team("two")};
        }
    }
}
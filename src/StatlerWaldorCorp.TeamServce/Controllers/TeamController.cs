using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorCorp.TeamServce.Models;
using StatlerWaldorCorp.TeamServce.Persistence;

namespace StatlerWaldorCorp.TeamServce.Controllers
{ 
    public class TeamController:Controller
    {
        
        ITeamRepository repository;
        public TeamController(ITeamRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public virtual IActionResult  GetAllTeams()
        {
            return this.Ok(repository.List());
        }

        [HttpPost]
        public  virtual IActionResult CreateTeam(Team team)
        {
             repository.Add(team);
              return this.Created($"/teams/{team.ID}", value: team);
        }
    }
}
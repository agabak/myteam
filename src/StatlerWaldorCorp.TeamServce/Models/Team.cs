using System;
using  System.Collections.Generic;

namespace StatlerWaldorCorp.TeamServce.Models
{
    public class Team 
    {

        public string Name { get; set; }
        public Guid ID { get; set; }
        public ICollection<Member> members  {get; set;}

        public Team() => this.members = new List<Member>();
        public Team(string name) : this() => this.Name = name;
        public Team(string name, Guid id): this(name) => this.ID = id;

        public override string ToString() => this.Name;
    }
}
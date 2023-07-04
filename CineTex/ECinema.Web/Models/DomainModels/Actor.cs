using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECinema.Web.Models.DomainModels
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public string AboutActor { get; set; }
        public virtual ICollection<ActorsInMovies> ActorsInMovies { get; set; }
    }
}

using Core.Entities.Abstracts;
using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Character : Entity<int>
    {
        public string? Url { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Species { get; set; }
        public string? Type { get; set; }
        public string? Gender { get; set; }
        public string? Image { get; set; }
        //public Location Location { get; set; }
        //public ICollection<string>? Episode { get; set; }
    }
}

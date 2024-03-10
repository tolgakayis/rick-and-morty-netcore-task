using Core.Entities.Abstracts;
using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Episode : Entity<int>
    {
        public string? Url { get; set; }
        public string? Name { get; set; }
        public string? Air_Date { get; set; }
        public string? EpisodeCode { get; set; }
        //public ICollection<string>? Characters { get; set; }
    }
}

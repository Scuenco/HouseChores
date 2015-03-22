using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseChores.Model
{
    public class Bedroom
    {
        public string Chores { get; set; }
        public Bedroom() { }
        public Bedroom(string chores)
        {
            this.Chores = chores;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseChores.Model
{
    public class Kitchen
    {
        public string Chores { get; set; }
        public Kitchen() { }
        public Kitchen(string chores) 
        {
            this.Chores = chores;        
        }    
    }
}

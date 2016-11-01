using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class State
    {
        public State()
        { }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
    }
}

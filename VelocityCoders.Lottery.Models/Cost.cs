using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class Cost
    {
        public Cost()
        {
        }

        public int CostId { get; set; }
        public int GameId { get; set; }
        public int CostAmount { get; set; }
    }
}

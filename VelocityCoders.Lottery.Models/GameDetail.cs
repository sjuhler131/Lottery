using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class GameDetail
    {
        public GameDetail()
        {
        }

        public int GameDetailId { get; set; }
        public int GameId { get; set; }
        public string Match { get; set; }
        public string Odds { get; set; }
        public string Prize { get; set; }
    }
}

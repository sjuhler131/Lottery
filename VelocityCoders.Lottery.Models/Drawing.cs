using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class Drawing
    {
        public Drawing()
        {
        }

        public int DrawingId { get; set; }
        public int GameId { get; set; }
        public DateTime DrawingDate { get; set; }
        public string Jackpot { get; set; }
        public string Multiplier { get; set; }
    }
}

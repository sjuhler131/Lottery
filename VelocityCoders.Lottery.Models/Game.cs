using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class Game
    {
        public Game()
        {
        }

        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public string HowToPlay { get; set; }

    }
}

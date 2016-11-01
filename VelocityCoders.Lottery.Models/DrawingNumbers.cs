using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
   public class DrawingNumbers
    {
        public DrawingNumbers()
        {
        }

        public int DrawingNumbersId { get; set; }
        public int BallTypeId { get; set; }
        public int DrawingId { get; set; }
        public int Number { get; set; }
    }
}

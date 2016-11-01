using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class BallType
    {
        public BallType(string ballTypeName)
        {
            this.BallTypeName = ballTypeName;
        }

        public BallType()
        {
        }

        public int BallTypeId { get; set; }
        public string BallTypeName { get; set; }
        public int Sequence { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.Lottery.Models
{
    public class WhereToPlay
    {
        public WhereToPlay()
        { }

        public int WhereToPlayId { get; set; }
        public int GameId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string AddressName { get; set; }
        public int AddressNumber { get; set; }
        public string Street01 { get; set; }
        public string Street02 { get; set; }
        public int ZipCode { get; set; }
        public int ZipCodePlusFour { get; set; }
    }
}

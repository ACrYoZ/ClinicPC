using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class ChiefCounts
    {
        public string Chief { get; set; }
    }
    public class CountChief
    {
        public List<ChiefCounts> doctors { get; set; }
        public int success { get; set; }
    }

    public class countposition2
    {
        public string Oculist { get; set; }
    }

    public class CountOculist
    {
        public List<countposition2> doctors { get; set; }
        public int success { get; set; }
    }


    public class countposition3
    {
        public string Surgeon { get; set; }
    }

    public class CountSurgeon
    {
        public List<countposition3> doctors { get; set; }
        public int success { get; set; }
    }
}

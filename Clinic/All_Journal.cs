using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class All_Journal
    {
        public string date { get; set; }
        public string passed { get; set; }
        public string annotation { get; set; }
        public string patient { get; set; }
        public string doctor { get; set; }
    }
    public class AllRadixObject
    {
        public List<Journal> journal { get; set; }
        public int success { get; set; }
    }
}

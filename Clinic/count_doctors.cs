using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class count_doctors
    {
        public string Doctors { get; set; }
    }
    public class CountDoctors
    {
        public List<count_doctors> doctors { get; set; }
        public int success { get; set; }
    }

}

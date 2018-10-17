using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class count_patient
    {
        public string Patient { get; set; }
    }
    public class CountPatients
    {
        public List<count_patient> patients { get; set; }
        public int success { get; set; }
    }
}

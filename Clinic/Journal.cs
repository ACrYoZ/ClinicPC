using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Journal
    {
        public string date { get; set; }
        public string passed { get; set; }
        public string annotation { get; set; }
        public string patient { get; set; }
        public string doctor { get; set; }

        public string date_v2 {get { return date.Substring(0, date.Length - 3); } }
        public string search { get { return patient.Substring(0, DataValue.TextSearch.Length); } }
    }
    public class RadixObject
    {
        public ObservableCollection<Journal> journal { get; set; }
        public int success { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Userdiagnosi
    {
        public string medication { get; set; }
        public string diagnosis { get; set; }
        public string Patient { get; set; }
    }

    public class DiagnosisObject
    {
        public ObservableCollection<Userdiagnosi> userdiagnosis { get; set; }
        public int success { get; set; }
    }
}

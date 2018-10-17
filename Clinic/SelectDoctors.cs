using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
        public class DoctorSel
        {
            public string surname { get; set; }
            public string name { get; set; }
            public string patronymic { get; set; }
            public string fio { get { return surname + " " + name + " " + patronymic; } }
    }

        public class SelObject
        {
            public ObservableCollection<DoctorSel> doctors { get; set; }
            public int success { get; set; }
        }
    
}

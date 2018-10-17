using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class DoctorsLoad
    {
        public string about { get; set; }
        public string content { get; set; }
        public string login { get; set; }
        public string _id { get; set; }

    }

    public class LoadDoctorsObject
    {
        public ObservableCollection<DoctorsLoad> doctors { get; set; }

        public int success { get; set; }
    }
}

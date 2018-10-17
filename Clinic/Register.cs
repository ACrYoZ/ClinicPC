using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
   public class Register
    {
        public string id { get; set; }
        public string dateTime { get; set; }
        public string patientName { get; set; }
        public string doctorName { get; set; }
        public string position { get; set; }
        public string parlor { get; set; }
        public string passportNumber { get; set; }
        public string annotation { get; set; }

        public string date_v2 { get { return dateTime.Substring(0, dateTime.Length - 3); } }
    }

    public class RegisterObject
    {
        public ObservableCollection<Register> register { get; set; }
        public int success { get; set; }
    }
}


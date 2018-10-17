using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Clinic
{
    public class Doctor 
    {
        public string doctorsId { get; set; }
        public string passport { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public string parlor { get; set; }

        public string search { get { return surname.Substring(0, DataValue.TextSearch.Length); } }
      

    }
    
    public class RootObject
    {
        public ObservableCollection<Doctor> doctors{ get; set; }
        public int success { get; set; }
    }
}

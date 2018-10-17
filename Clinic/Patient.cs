using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient
    {
        public string userId { get; set; }
        public string login { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string dateTime { get; set; }
        public string adress { get; set; }
        public string age { get; set; }
        public string passportNumber { get; set; }
        public string phone { get; set; }
        public string countDisagree { get; set; }
        public string diagnosis { get; set; }
        public string doctorId { get; set; }
        public string medication { get; set; }
        public string fio { get { return surname + " " + name + " " + patronymic; } }
        public string search { get { return surname.Substring(0, DataValue.TextSearch.Length); } }
    }
    public class RadicalObject
    {
        public ObservableCollection<Patient> patients { get; set; }
        public int success { get; set; }
    }
}

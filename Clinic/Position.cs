using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Position
    {
        public string position_name { get; set; }
    }

    public class PositionObject
    {
        public ObservableCollection<Position> positions { get; set; }
        public int success { get; set; }
    }

}

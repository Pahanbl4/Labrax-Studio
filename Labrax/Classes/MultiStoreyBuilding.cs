using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrax_Studio.Classes
{
   public class MultiStoreyBuilding:PrefabBuilding
    {
        public bool Elevator;
        public MultiStoreyBuilding()
        {
            Elevator = true;
            Columns = 50;
            Crossbars = 100;
            TypeName = "neboscreb";
            PanelsForExternalWalls = 32;
            PanelsForInteriorWalls = 23;
            PlatesOfOverlap = 12;
            Doors = 433;
            Windows =2342;
        }
    }
}

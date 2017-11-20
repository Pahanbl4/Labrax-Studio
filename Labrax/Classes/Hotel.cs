using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrax_Studio.Classes
{
  public  class Hotel: FramelessBuilding
    {
        public bool Pool;
        public Hotel()
        {
            TypeName = "Hotel zara";
            PanelsForExternalWalls = 3;
            PanelsForInteriorWalls = 2;
            PlatesOfOverlap = 3;
            Doors = 3;
            Windows = 2;
            TransversePartitions = 10;
            Pool = true;
        }
    }
}

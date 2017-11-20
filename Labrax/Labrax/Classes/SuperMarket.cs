using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrax_Studio.Classes
{
    public class SuperMarket : FramelessBuilding
    {
        public bool esescalator;
        public SuperMarket()
        {
            TypeName = "ashan";
            PanelsForExternalWalls = 3;
            PanelsForInteriorWalls = 2;
            PlatesOfOverlap = 3;
            Doors = 3;
            Windows = 2;
            TransversePartitions = 10;
            esescalator = true;
        }
    }
}

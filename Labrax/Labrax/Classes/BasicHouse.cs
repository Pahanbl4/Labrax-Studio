using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labrax_Studio.Interfaces;

namespace Labrax_Studio.Classes
{
    public class BasicHouse : IBasicHouse
    {
        public string TypeName { get ; protected set; }
        public int PanelsForExternalWalls { get ; protected set; }
        public int PanelsForInteriorWalls { get ;protected set ; }
        public int PlatesOfOverlap { get; protected set; }
        public int Doors { get; protected set; }
        public int Windows { get;protected set; }

       
    }
}

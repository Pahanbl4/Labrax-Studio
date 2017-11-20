using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrax_Studio.Interfaces
{
   public interface IBasicHouse
    {
        string TypeName { get; }
        int PanelsForExternalWalls { get; }
        int PanelsForInteriorWalls { get;  }
        int PlatesOfOverlap { get; }
        int Doors { get;  }
        int Windows { get; }
    }
}

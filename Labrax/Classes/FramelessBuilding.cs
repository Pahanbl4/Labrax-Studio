using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labrax_Studio.Interfaces;

namespace Labrax_Studio.Classes
{
    public class FramelessBuilding :BasicHouse, IFramelessBuilding
    {
        public int TransversePartitions { get;set; }
        public FramelessBuilding()
        { }

        public FramelessBuilding(string typeName, int panelsForExternalWalls, int panelsForInteriorWalls, int platesOfOverlap, int doors, int windows,int transversePartitions ) 
            
        {
          TypeName = typeName;
          PanelsForExternalWalls = panelsForExternalWalls;
          PanelsForInteriorWalls = panelsForInteriorWalls;
          PlatesOfOverlap = platesOfOverlap;
          Doors = doors;
          Windows = windows;
          TransversePartitions = transversePartitions;
        }
    }
}

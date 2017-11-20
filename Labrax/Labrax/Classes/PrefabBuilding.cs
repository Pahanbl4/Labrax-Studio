using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labrax_Studio.Interfaces;

namespace Labrax_Studio.Classes
{
    public class PrefabBuilding :BasicHouse, IPrefabBuilding
    {
        public int Columns { get;protected set; }
        public int Crossbars { get ;protected set ; }

        public PrefabBuilding()
        { }

        public PrefabBuilding(int columns,int crossbars, string typeName, int panelsForExternalWalls, int panelsForInteriorWalls, int platesOfOverlap, int doors, int windows) 
           
        {
            Columns = columns;
            Crossbars = crossbars;
            TypeName = typeName;
            PanelsForExternalWalls = panelsForExternalWalls;
            PanelsForInteriorWalls = panelsForInteriorWalls;
            PlatesOfOverlap = platesOfOverlap;
            Doors = doors;
            Windows = windows;

        }
    }
}

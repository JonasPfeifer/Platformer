using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Level
    {
        List<PhysicalObject> physicalObjectList = new List<PhysicalObject>();       
        Player player = new Player(98, 350, 25, 25, global::Platformer.Properties.Resources.rabe_laufen_l1);
        public Level()
        {
            physicalObjectList.Add(new PhysicalObject(0, 400, 10, 10000, System.Drawing.Color.Black));  
            physicalObjectList.Add(new PhysicalObject(200, 370, 25, 225, System.Drawing.Color.Black));
            physicalObjectList.Add(new PhysicalObject(50, 390, 25, 25, System.Drawing.Color.Black));
            physicalObjectList.Add(new Coin(150, 350, 25, 25, System.Drawing.Color.Yellow));
            physicalObjectList.Add(new Coin(450, 375, 25, 25, System.Drawing.Color.Yellow));
            physicalObjectList.Add(new Goal(650, 375, 25, 25, System.Drawing.Color.Magenta));
        }
        public List<PhysicalObject> getphysicalObjectList() { return physicalObjectList; }
        public void setphysicalObjectList(List<PhysicalObject> physicalObjectList) { this.physicalObjectList = physicalObjectList; }
        public Player getplayer() { return player; }
    }
}

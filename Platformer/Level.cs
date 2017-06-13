using Platformer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Level
    {
        List<PhysicalObject> physicalObjectList = new List<PhysicalObject>();
        Ground ground;
        Player player;
        public Level()
        {
            player = new Player(45, 0, global::Platformer.Properties.Resources.move);
            ground = new Ground(0, 304, global::Platformer.Properties.Resources.ground1);
            physicalObjectList.Add(ground);
            physicalObjectList.Add(new Obstacles(166, 231,  global::Platformer.Properties.Resources.s_1));
            //physicalObjectList.Add(new Obstacles(773, 259,  global::Platformer.Properties.Resources.r_1));
            //physicalObjectList.Add(new Obstacles(473, 259, global::Platformer.Properties.Resources.r_1));
            physicalObjectList.Add(new Obstacles(473, 231, global::Platformer.Properties.Resources.r_1));
            
            
            physicalObjectList.Add(new Obstacles(888, 207,  global::Platformer.Properties.Resources.s_2));
            physicalObjectList.Add(new Obstacles(988, 137,  global::Platformer.Properties.Resources.s_3));
            physicalObjectList.Add(new Obstacles(1311, 228,global::Platformer.Properties.Resources.ag_1));
            physicalObjectList.Add(new Obstacles(1401, 164, global::Platformer.Properties.Resources.ag_2));
            physicalObjectList.Add(new Obstacles(1497, 93,  global::Platformer.Properties.Resources.ag_3));
            physicalObjectList.Add(new Obstacles(1713, 186, global::Platformer.Properties.Resources.ag_4));
            physicalObjectList.Add(new Obstacles(2315, 259, global::Platformer.Properties.Resources.r_2));
            physicalObjectList.Add(new Obstacles(2837, 243, global::Platformer.Properties.Resources.pfg_0));
            physicalObjectList.Add(new Obstacles(3562, 258, global::Platformer.Properties.Resources.pfg_1));
            physicalObjectList.Add(new Obstacles(3668, 228, global::Platformer.Properties.Resources.pfg_2));
            physicalObjectList.Add(new Obstacles(3768, 258, global::Platformer.Properties.Resources.pfg_3));
            
            /* with w and h
            physicalObjectList.Add(new Obstacles(166, 231, 79, 71, global::Platformer.Properties.Resources.s_1));
            physicalObjectList.Add(new Obstacles(773, 259, 66, 127, global::Platformer.Properties.Resources.r_1));
            physicalObjectList.Add(new Obstacles(888, 207, 105, 94, global::Platformer.Properties.Resources.s_2));
            physicalObjectList.Add(new Obstacles(988, 137, 174, 188, global::Platformer.Properties.Resources.s_3));
            physicalObjectList.Add(new Obstacles(1311, 228, 38, 78, global::Platformer.Properties.Resources.ag_1));
            physicalObjectList.Add(new Obstacles(1401, 164, 38, 78, global::Platformer.Properties.Resources.ag_2));
            physicalObjectList.Add(new Obstacles(1497, 93, 39, 205, global::Platformer.Properties.Resources.ag_3));
            physicalObjectList.Add(new Obstacles(1713, 186, 39, 78, global::Platformer.Properties.Resources.ag_4));
            physicalObjectList.Add(new Obstacles(2315, 259, 66, 127, global::Platformer.Properties.Resources.r_2));
            physicalObjectList.Add(new Obstacles(2837, 243, 39, 165, global::Platformer.Properties.Resources.pfg_0));
            physicalObjectList.Add(new Obstacles(3562, 258, 38, 78, global::Platformer.Properties.Resources.pfg_1));
            physicalObjectList.Add(new Obstacles(3668, 228, 38, 78, global::Platformer.Properties.Resources.pfg_2));
            physicalObjectList.Add(new Obstacles(3768, 258, 38, 78, global::Platformer.Properties.Resources.pfg_3));
            */
        }
        public List<PhysicalObject> getphysicalObjectList() { return physicalObjectList; }
        public void setphysicalObjectList(List<PhysicalObject> physicalObjectList) { this.physicalObjectList = physicalObjectList; }
        public Player getplayer() { return player; }
        public Ground getGround()
        {
            return ground;
        }
    }
}

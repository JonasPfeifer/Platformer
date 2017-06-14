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
            player = new Player(45, 0,48,64, global::Platformer.Properties.Resources.animated_2);
            ground = new Ground(0, 304, global::Platformer.Properties.Resources.ground1);
            physicalObjectList.Add(ground);

            //Goal
            //physicalObjectList.Add(new Goal(6776, -54, global::Platformer.Properties.Resources.winning_pill));

            //Pitfalls
            physicalObjectList.Add(new Goal(2818, 243, global::Platformer.Properties.Resources.pitfall_3));
            physicalObjectList.Add(new Goal(3522, 243, global::Platformer.Properties.Resources.pitfall_1));

            //Obstacles
            physicalObjectList.Add(new Obstacles(166, 231,  global::Platformer.Properties.Resources.s_1));
            physicalObjectList.Add(new Obstacles(473, 251, global::Platformer.Properties.Resources.r_1));
            physicalObjectList.Add(new Obstacles(888, 207,  global::Platformer.Properties.Resources.s_2));
            physicalObjectList.Add(new Obstacles(988, 137,  global::Platformer.Properties.Resources.s_3));
            physicalObjectList.Add(new Obstacles(1311, 228,global::Platformer.Properties.Resources.ag_1));
            physicalObjectList.Add(new Obstacles(1401, 164, global::Platformer.Properties.Resources.ag_2));
            physicalObjectList.Add(new Obstacles(1497, 93,  global::Platformer.Properties.Resources.ag_3));
            physicalObjectList.Add(new Obstacles(1713, 186, global::Platformer.Properties.Resources.ag_4));
            physicalObjectList.Add(new Obstacles(2315, 259, global::Platformer.Properties.Resources.r_2));
            physicalObjectList.Add(new Obstacles(2837, 230, global::Platformer.Properties.Resources.pfg_0));
            physicalObjectList.Add(new Obstacles(3562, 258, global::Platformer.Properties.Resources.pfg_1));
            physicalObjectList.Add(new Obstacles(3668, 228, global::Platformer.Properties.Resources.pfg_2));
            physicalObjectList.Add(new Obstacles(3768, 258, global::Platformer.Properties.Resources.pfg_3));
            physicalObjectList.Add(new Obstacles(6794, 89, global::Platformer.Properties.Resources.crystal));
            physicalObjectList.Add(new Obstacles(6701,224 , global::Platformer.Properties.Resources.ag_12));
            physicalObjectList.Add(new Obstacles(6021,224 , global::Platformer.Properties.Resources.ag_11));
            physicalObjectList.Add(new Obstacles(5901,160 , global::Platformer.Properties.Resources.ag_10));
            physicalObjectList.Add(new Obstacles(5662,89 , global::Platformer.Properties.Resources.ag_9));
            physicalObjectList.Add(new Obstacles(5551,103 , global::Platformer.Properties.Resources.ag_8));
            physicalObjectList.Add(new Obstacles(5313,89 , global::Platformer.Properties.Resources.ag_7));
            physicalObjectList.Add(new Obstacles(5217,160 , global::Platformer.Properties.Resources.ag_6));
            physicalObjectList.Add(new Obstacles(5112,224 , global::Platformer.Properties.Resources.ag_5));

            //Coin
            physicalObjectList.Add(new Coin(6398, 261, global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6368,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6338,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6308,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6278,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6248,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6218,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6188,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6158,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(4611,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(4581,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(4551,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(4521,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(4491,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3317,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3287,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3257,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3227,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3197,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2943,195 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2913,195 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2883,195 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2853,195 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2597,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2567,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2537,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2507,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2177,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2147,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2117,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2087,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2057,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(2027,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1997,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1967,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1937,261 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6724,189 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(6044,189 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5924,126 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5752,4 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5782,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5752,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5722,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5812,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5782,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5752,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5722,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5692,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5574,70 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5402,4 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5432,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5402,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5372,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5462,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5432,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5402,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5372,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5342,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5240,127 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(5136,189 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3786,219 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3684,188 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(3580,220 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1740,153 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1579,4 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1609,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1579,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1549,32 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1639,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1609,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1579,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1549,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1519,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1417,129 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1328,192 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1255,243 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1236,201 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1208,166 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1169,142 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1106,103 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(1045,60 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(984,103 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(910,161 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(812,111 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(566,161 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(514,161 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(462,161 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(222,197 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(181,163 , global::Platformer.Properties.Resources._1));
            physicalObjectList.Add(new Coin(142,198 , global::Platformer.Properties.Resources._1));
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

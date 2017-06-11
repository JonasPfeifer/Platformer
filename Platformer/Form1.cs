using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        List<PhysicalObject> physicalObjectList;
        Level level;
        Player player;
        int gforce = 2;
        int ax = 0;
        int ay = 2;
        int offsetx;
    
        int punkte;
        public Form1()

        {
            level = new Level();
            physicalObjectList = level.getphysicalObjectList();
            player = level.getplayer();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            Player posPlayer = new Player(player.getx() + ax, player.gety() + ay, player.geth(), player.getw());
            int tmpax = ax;
            int tmpay = ay;
            if (playerIsEndOfLevel(posPlayer))
            {
                tmpax = 0;
                tmpay = 0;
            }
            else if (playerIsOutOfLevel(posPlayer))
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                foreach (PhysicalObject listobject in physicalObjectList)
                {

                    if ((isPlayerBetweenObjectY(listobject, posPlayer) && isPlayerBetweenObjectX(listobject, posPlayer)))
                    {
                        tmpay = 0;
                        if (!isPlayerBetweenObjectX(listobject, player))
                        {
                            tmpax = 0;
                        }
                        if (listobject.gettypeOfPhysicalObject().Equals("Coin"))
                        {
                            punkte++;
                            this.score.Text = "Punkte: " + punkte;
                            physicalObjectList.Remove(listobject);
                            break;
                        }else if (listobject.gettypeOfPhysicalObject().Equals("Goal"))
                        {
                            System.Windows.Forms.Application.Exit();
                            break;
                        }
                    }
                }
            }
            //player.Location = new Point(player.Location.X + tmpax, player.Location.Y + tmpay);
            //player.setx(  ( player.getx() + tmpax ) );
            //player.sety( ( player.gety() + tmpay ) );
            player.setx((player.getx() + 2));
            player.sety((player.gety() + 2));

            if (ay < gforce)
            {
                ay++;
            }
            offsetx += tmpax;
            moveLevel();
            
        }
        private bool playerIsEndOfLevel(Player player)
        {
            return (player.getx() <= 0 || player.gety() <= 0);
            
        }
        private bool playerIsOutOfLevel(Player player)
        {
            return (player.gety()-(player.geth()/2) > screen.Bottom);

        }
        private bool isPlayerBetweenObjectX(PhysicalObject listobject, Player player)
        {
            return leftColliding(listobject, player) && rightColliding(listobject, player);
        }
        private bool isPlayerBetweenObjectY(PhysicalObject listobject, Player player)
        {
            return (bottomTopColliding(player, listobject) && bottomTopColliding(listobject, player));
        }
        private bool bottomTopColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return player.getbottom() > listobject.gettop();
        }
        private bool leftColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return (player.getleft() + (player.getw() / 2)) > listobject.getleft();
        }
        private bool rightColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return (player.getright() - (player.getw() / 2)) < listobject.getright();
        }
        
       void moveLevel()
        {
            
            using (Graphics g = Graphics.FromImage(stage))
            {
                g.DrawImage(global::Platformer.Properties.Resources.background_export_72dpi, 0, 0);
                foreach (PhysicalObject obstacle in this.physicalObjectList)
                {
                    if (obstacle.getx() < player.getx() + screen.Width  && obstacle.getx() > player.getx() - screen.Width )
                    {
                        obstacle.draw(g, offsetx);
                    }

                }
                level.getGround().draw(g);
                level.getplayer().draw(g);
                this.screen.CreateGraphics().DrawImage(stage, 0, 0);
            }
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A) 
            {
                ax = -2;
            }
            if (e.KeyCode == Keys.D) 
            {
                ax = 2;
                
            }
            if (e.KeyCode == Keys.Space)
            {
                ay = -10;
            }

        }
    }
}


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
        //List<PhysicalObject> physicalObjectList;
        Level level;
        Player player;
        int gforce = 15;
        int ax = 0;
        int ay = 2;
        int offsetx;
        int playermovementtox;
        int punkte;
        
        public Form1()

        {
            level = new Level();
            //physicalObjectList = level.getphysicalObjectList();
            player = level.getplayer();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Player posPlayer = new Player(player.getx() + ax, player.gety() + ay,player.getBackground());
            //Player posPlayer = player;
            int tmpax = ax;
            int tmpay = ay;
            int tmpposx = player.getx();

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
                foreach (PhysicalObject listobject in level.getphysicalObjectList())
                {
                    

                    //if ((isPlayerBetweenObjectY(listobject, posPlayer) && isPlayerBetweenObjectX(listobject, posPlayer)))
                    if (isPlayerBetweenObjectY(listobject, posPlayer)) {
                        if (isPlayerBetweenObjectX(listobject, posPlayer))
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
                                level.getphysicalObjectList().Remove(listobject);
                                break;
                            } else if (listobject.gettypeOfPhysicalObject().Equals("Goal"))
                            {
                                System.Windows.Forms.Application.Exit();
                                break;
                            }
                        }
                    }
                }
               }
            //player.Location = new Point(player.Location.X + tmpax, player.Location.Y + tmpay);
            player.setx( ( player.getx() + tmpax ) );
            player.sety( ( player.gety() + tmpay ) );
            //player.setx((player.getx()));
            //player.sety((player.gety()));

            if (ay < gforce)
            {
                ay++;
            }
            playermovementtox = tmpposx - player.getx();
            //playermovementtox += (tmpposx - (player.getx() + tmpax));
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
            // return (player.getleft() + (player.getw() / 2)) > listobject.getleft();
            return (player.getright() > listobject.getleft());
        }
        private bool rightColliding(PhysicalObject listobject, PhysicalObject player)
        {
            //return (player.getright() - (player.getw() / 2)) > listobject.getright();
            return player.getleft() < listobject.getright();
        }
        
       void moveLevel()
        {
            
            using (Graphics g = Graphics.FromImage(stage))
            {
                g.DrawImage(global::Platformer.Properties.Resources.background_export_72dpi, 0, 0, 7000, 412);
                foreach (PhysicalObject obstacle in level.getphysicalObjectList())
                {
                    if (!obstacle.gettypeOfPhysicalObject().Equals("Ground"))
                    {
                        if (obstacle.getx() < player.getx() + screen.Width && obstacle.getx() > player.getx() - screen.Width)
                        {
                            obstacle.draw(g, playermovementtox);
                        }
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
                ax = -1;
            }
            if (e.KeyCode == Keys.D) 
            {
                ax = 1;   
            }
            if (e.KeyCode == Keys.Space)
            {
                ay = -10;
                //ay = - 2;
            }

        }
    }
}


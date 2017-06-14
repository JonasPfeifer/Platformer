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
        Level level;
        Player player;
        int gforce = 2;
        int ax = 0;
        int ay = 2;
        int playermovementtox;
        int punkte;
        int backroundcount;
        
        public Form1()

        {
            level = new Level();
            player = level.getplayer();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Player posPlayer = new Player(player.getx() + ax, player.gety() + ay,player.geth(), player.getw(),player.getBackground());
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
                    if (isPlayerBetweenObjectY(listobject, posPlayer)) {
                        if (isPlayerBetweenObjectX(listobject, posPlayer))
                        {
                             tmpay = 0;
                            if (!leftColliding(listobject, player) && tmpax<0)
                            {
                                tmpax = 0;
                            }
                            if (!rightColliding(listobject, player))
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
            if (!(player.getx() > screen.Width / 2))
            { 
                player.setx((player.getx() + tmpax));
            }else
            {
                tmpax *= 2 ;
            }
            
            player.sety( ( player.gety() + tmpay ) );
            if (ay < gforce)
            {
                ay++;
            }
            playermovementtox = tmpposx - (player.getx() + tmpax);
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
            return leftColliding(listobject, player) || rightColliding(listobject, player);
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
            return player.getright() > listobject.getleft() && player.getright() < listobject.getright();
        }
        private bool rightColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return player.getleft() < listobject.getright() && player.getleft() > listobject.getleft();
        }
        
       void moveLevel()
        {
            
            using (Graphics g = Graphics.FromImage(stage))
            {
                //g.DrawImage(global::Platformer.Properties.Resources.background_export_72dpi, 0, 0, 7000, 412);
                g.DrawImage(moveScrollingTexture(playermovementtox, global::Platformer.Properties.Resources.background_export_72dpi), 0, 0, screen.Width, screen.Height);
                level.getGround().draw(g, playermovementtox);
                foreach (PhysicalObject obstacle in level.getphysicalObjectList())
                {
                    if (!obstacle.gettypeOfPhysicalObject().Equals("Ground"))
                    {
                            obstacle.draw(g, playermovementtox);
                    }
                }
                
                player.draw(g);
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
            }

        }
        public Bitmap moveScrollingTexture(int playermovementtox,Bitmap background)
        {
            if (0 > backroundcount - playermovementtox || (backroundcount - playermovementtox)+screen.Width > background.Width)
            {
                backroundcount = 1;
            }
            else
            {
                backroundcount -= playermovementtox;

            }
            return background.Clone(new System.Drawing.Rectangle(backroundcount, 0, screen.Width, screen.Height), background.PixelFormat);
            //g.DrawImage(CroppedImage, 0, y, 790, 108);

        }
    }
}


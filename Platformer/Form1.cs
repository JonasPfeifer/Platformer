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
        int ax = 2;
        int ay = 2;

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
            Player posPlayer = new Player(player.Location.X + ax, player.Location.Y + ay, player.Height, player.Width);
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
                            listobject.Visible = false;
                            this.score.Text = "Punkte: " + punkte;
                            physicalObjectList.Remove(listobject);
                            this.screen.Controls.Remove(listobject);
                            break;
                        }else if (listobject.gettypeOfPhysicalObject().Equals("Goal"))
                        {
                            System.Windows.Forms.Application.Exit();
                            break;
                        }
                    }
                }
            }
            player.Location = new Point(player.Location.X + tmpax, player.Location.Y + tmpay);
            if (ay < gforce)
            {
                ay++;
            }
            foreach (PhysicalObject listobject in physicalObjectList)
            {
                listobject.Location = new Point(listobject.Location.X - ( tmpax * 2 ), listobject.Location.Y);
            }
        }
        private bool playerIsEndOfLevel(Player player)
        {
            return (player.Location.X <= 0 || player.Location.Y <= 0);
            
        }
        private bool playerIsOutOfLevel(Player player)
        {
            return (player.Bottom > screen.Bottom);

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
            return player.Bottom > listobject.Top;
        }
        private bool leftColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return (player.Left + (player.Width / 2)) > listobject.Left;
        }
        private bool rightColliding(PhysicalObject listobject, PhysicalObject player)
        {
            return (player.Right - (player.Width / 2)) < listobject.Right;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)    //Wenn die Taste D gedrückt wird, wird das Objekt Panel1 auf der WinForm verschoben
            {
                ax = -2;
                player.BackgroundImage = Platformer.Properties.Resources.rabe_links;
            }
            if (e.KeyCode == Keys.D)    //gleiche bei A, nur nach links
            {
                ax = 2;
                player.BackgroundImage = Platformer.Properties.Resources.rabe_rechts;
            }
            if (e.KeyCode == Keys.Space)
            {
                ay = -10;
            }

        }
    }
}


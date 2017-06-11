using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Platformer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            
            this.components = new System.ComponentModel.Container();
            this.screen = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.block = new System.Windows.Forms.PictureBox();
            //this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);            
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            foreach(PhysicalObject physicalobject in physicalObjectList)
            {
                this.screen.Controls.Add(physicalobject);
            }
            this.screen.Controls.Add(player);
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.Controls.Add(this.score);
            this.screen.Controls.Add(this.block);
            //this.screen.Controls.Add(this.panel1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(784, 412);
            this.screen.TabIndex = 0;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(21, 16);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(53, 13);
            this.score.TabIndex = 3;
            this.score.Text = "Punkte: 0";
            // 
            // block
            //
            /* 
            this.block.BackgroundImage = global::Platformer.Properties.Resources.Erdblock;
            this.block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.block.Location = new System.Drawing.Point(271, 330);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(236, 46);
            this.block.TabIndex = 1;
            this.block.TabStop = false;
            this.block.Click += new System.EventHandler(this.block_Click);
            */
            // 
            // panel1
            // 
            /*this.panel1.BackgroundImage = global::Platformer.Properties.Resources.rabe_laufen_l1;
            this.panel1.Location = new System.Drawing.Point(98, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);*/
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
           
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.ResumeLayout(false);

        }

     
        #endregion

        private System.Windows.Forms.Panel screen;
        //private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.Label score;
    }
}


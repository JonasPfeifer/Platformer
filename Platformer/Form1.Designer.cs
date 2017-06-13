using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);            
            this.screen.SuspendLayout();

            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Controls.Add(this.score);

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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
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
            this.ResumeLayout(false);
            this.DoubleBuffered = true;
        }
        
        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        Bitmap stage = new Bitmap(784, 412);

    }
}


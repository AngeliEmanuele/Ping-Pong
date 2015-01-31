using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double speed; // velocità della pallina
        double angle; // angolo in gradi traiettoria della pallina
        double leftReal; // dove è la palllina veramente
        double topReal;
        
    
        public Form1()
        {
            InitializeComponent();
          // situazione di partenza della pallina
            speed = 5;
            angle = 165;
            leftReal = pnlBall.Left;
            topReal = pnlBall.Top;

        }
                
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

      
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            double pz = pnlLeft.Height / 5;
            double rz = pnlRight.Height / 5;
            
            bool punto = false;
            
            double radianti = Math.PI * angle / 180.0;

            double l = leftReal + speed * Math.Cos(radianti);
            double t = topReal + speed * Math.Sin(radianti);
            double b = t + PnlBall.Height;
            
            
            int x = pnlRight.Left;

            int y = pnlRight.Top;

            int a = pnlLeft.Left;

            int c = pnlLeft.Top;

            if (((l + PnlBall.Width) >= x) &&
               ((t + PnlBall.Height) >= y) &&
               (t <= pnlRight.Bottom)
                )
                {
                if ((t <= (pnlRight.Top + 3 * rz)) && (b >= (pnlRight.Top + 2 * rz)))
                    angle = 180 - angle;
                else if ((t <= (pnlRight.Top + 2 * rz)) && (b >= (pnlRight.Top + 1 * rz)))
                    angle = 180 - angle - 2;
                else if ((t <= (pnlRight.Top + 4 * rz)) && (b >= (pnlRight.Top + 3 * rz)))
                    angle = 180 - angle + 2;
                else if ((t <= (pnlRight.Top + 1 * rz)) && (b >= (pnlRight.Top + 0 * rz)))
                    angle = 180 - angle - 5;
                else if ((t <= (pnlRight.Top + 5 * rz)) && (b >= (pnlRight.Top + 4 * rz)))
                    angle = 180 - angle + 5;
                else
                    angle = 180 - angle;
                }

            else if ((l <= pnlLeft.Right) &&
                    ((t + PnlBall.Height) >= c) &&
                    (t <= pnlLeft.Bottom)
                     )
                    {
                        if ((t <= (pnlLeft.Top + 3*pz)) && (b >= (pnlLeft.Top + 2*pz)))
                            angle = 180 - angle;
                        else if ((t <= (pnlLeft.Top + 2*pz)) && (b >= (pnlLeft.Top + 1*pz)))
                            angle = 180 - angle -2;
                        else if ((t <= (pnlLeft.Top + 4*pz)) && (b >= (pnlLeft.Top + 3*pz)))
                            angle = 180 - angle + 2;
                        else if ((t <= (pnlLeft.Top + 1*pz)) && (b >= (pnlLeft.Top + 0*pz)))
                            angle = 180 - angle -5;
                        else if ((t <= (pnlLeft.Top + 5*pz)) && (b >= (pnlLeft.Top + 4*pz)))
                            angle = 180 - angle +5;
                        else
                            angle = 180 - angle;
                    }


            else if (l <= 0)
            {
                punti2++;
                punto = true;
            }
            else if ((l + PnlBall.Width) >= pnlGioco.Width)
            {
                punti1++;
                punto = true;
            }


            else if ((t <= 0) ||
                    ((t + PnlBall.Height) >= pnlGioco.Height)
                    )
                angle = 360 - angle;

            if (angle < 0)
                angle = 360 + angle;

            radianti = Math.PI * angle / 180.0;
           
            leftReal = leftReal + speed * Math.Cos(radianti);
            topReal = topReal + speed * Math.Sin(radianti);

            PnlBall.Left = (int)Math.Round(leftReal);
            PnlBall.Top = (int)Math.Round(topReal);


            if (punto)
            {
                timer1.Enabled = false;
                PnlBall.Visible = false;
                label1.Text = punti1.ToString();
                label2.Text = punti2.ToString();
                PnlBall.Left = (pnlGioco.Width / 2) - (PnlBall.Width / 2);
                PnlBall.Top = (pnlGioco.Height / 2) - (PnlBall.Height / 2);
                leftReal = PnlBall.Left;
                topReal = PnlBall.Top;
                pnlLeft.Top = (pnlGioco.Height / 2) - (pnlLeft.Height / 2);
                pnlRight.Top = (pnlGioco.Height / 2) - (pnlLeft.Height / 2);
                speed = 3;
                angle = -angle;
                PnlBall.Visible = true;
                timer1.Enabled = true;

            }
         }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
                pnlRight.Top = pnlRight.Top - inc;
            if (e.KeyCode == Keys.L)
                pnlRight.Top = pnlRight.Top + inc;

            if (e.KeyCode == Keys.A)
                pnlLeft.Top = pnlLeft.Top - inc;
            if (e.KeyCode == Keys.Z)
                pnlLeft.Top = pnlLeft.Top + inc;
        }   
        
        private void Pausa(object sender, EventArgs e)
        {
            timer.Enabled = false;
 
        } 
    }
  }
  


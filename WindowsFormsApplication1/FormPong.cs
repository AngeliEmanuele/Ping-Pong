using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
 {
  public partial class frmPong : Form
  {
  double speed; // velocità della pallina
  double angle; // angolo (in gradi) traiettoria della pallina
  double leftReal; // dove è la palllina veramente
  double topReal;
 
  int incPadle; // incremento racchetta
 
  int puntiOne, puntiTwo;
  
  public frmPong()
  {
  InitializeComponent();
 
  incPadle = 30;
 
  InizializeSet();
 
  }
 
  private void InizializeSet()
  {
  puntiOne = 0;
  puntiTwo = 0;
  InizializeGame();
  }
 
  private void InizializeGame()
  {
  // situazione di partenza della pallina
  lblPuntiOne.Text = puntiOne.ToString();
  lblPuntiTwo.Text = puntiTwo.ToString();
 
  speed = 18;
  angle = 180;
 
  pnlBall.Left = pnlPong.Width / 2;
  pnlBall.Top = pnlPong.Height / 2;
 
  leftReal = pnlBall.Left;
  topReal = pnlBall.Top;
 
  pnlPadleLeft.Top = (pnlPong.Height / 2) - (pnlPadleLeft.Height /2);
  pnlPadleRight.Top = pnlPadleLeft.Top;
 
  }
 
 //Bottone per l'avvio
  private void button1_Click(object sender, EventArgs e)
  {
  timer.Enabled = true;
  }
  //Bottone per mettere in pausa
   private void Pausa(object sender, EventArgs e)
  {
  timer.Enabled = false;
 
  }
 
  private void pnlBall_Paint(object sender, PaintEventArgs e)
  {
 
  }
 
  private void pnlPadleLeft_Paint(object sender, PaintEventArgs e)
  {
  }
  
  private void timer_Tick(object sender, EventArgs e)
  {
  double pz = pnlPadleLeft.Height / 5;
 
  bool punto = false;
  // trasformo i gradi in radianti
  double radius = Math.PI * angle / 180.0;
  // dove dovrebbe andare la pallina?
  double l = leftReal + speed * Math.Cos(radius);
  double t = topReal + speed * Math.Sin(radius);
  double b = t + pnlBall.Height;
 
  // è andata a sbattere?...rimbalzo (cambio angolo)
  if ((l <= pnlPadleLeft.Right) && (b >= pnlPadleLeft.Top) && (t <= pnlPadleLeft.Bottom))
  {
  if ((t <= (pnlPadleLeft.Top + 1*pz)) && (b >= (pnlPadleLeft.Top + 0*pz)))
  angle = 180 - angle - 5;
  else if ((t <= (pnlPadleLeft.Top + 2*pz)) && (b >= (pnlPadleLeft.Top + 1*pz)))
  angle = 180 - angle - 2;
  else if ((t <= (pnlPadleLeft.Top + 3*pz)) && (b >= (pnlPadleLeft.Top + 2*pz)))
  angle = 180 - angle;
  else if ((t <= (pnlPadleLeft.Top + 4*pz)) && (b >= (pnlPadleLeft.Top + 3*pz)))
  angle = 180 - angle + 2;
  else if ((t <= (pnlPadleLeft.Top + 5*pz)) && (b >= (pnlPadleLeft.Top + 4*pz)))
  angle = 180 - angle + 5;
  else
  angle = 180 - angle;
 
  }
  else if (((l + pnlBall.Width) >= pnlPadleRight.Right) && (b >= pnlPadleRight.Top) && (t <= pnlPadleRight.Bottom))
    {
  angle = 180 - angle;
  }
  else if (l <= 0)
   {
  punto = true;
  puntiTwo++;
  }
  else if ((l + pnlBall.Width) >= pnlPong.Width)
  {
  punto = true;
  puntiOne++;
 }
 else if ((t <= 0) || ((t + pnlBall.Height) >= pnlPong.Height))
  angle = 360 - angle;
 
  if (angle < 0)
  angle = 360 + angle;
 
  // calcolo la posizione reale della pallina
  radius = Math.PI * angle / 180.0;
  leftReal = leftReal + speed * Math.Cos(radius);
  topReal = topReal + speed * Math.Sin(radius);

  // sposto la pallina grafica
  pnlBall.Left = (int)Math.Round(leftReal);
  pnlBall.Top = (int)Math.Round(topReal);
 
  if (punto)
  {
  timer.Enabled = false;
  pnlBall.Visible = false;
 
  InizializeGame();
 
  pnlBall.Visible = true;
  }
 
  }
  
  private void frmPong_KeyDown(object sender, KeyEventArgs e)
  {
  // MessageBox.Show("down " + e.KeyCode.ToString());
  if (e.KeyCode == Keys.PageUp)
  {
  pnlPadleRight.Top = pnlPadleRight.Top - incPadle;
  if (pnlPadleRight.Top <= 0)
  pnlPadleRight.Top = 1;
  }
  if (e.KeyCode == Keys.PageDown)
  {
  pnlPadleRight.Top = pnlPadleRight.Top + incPadle;
   if (pnlPadleRight.Bottom > pnlPong.Height)
  pnlPadleRight.Top = pnlPong.Height - pnlPadleRight.Height;
  }
 
  if (e.KeyCode == Keys.W)
  {
  pnlPadleLeft.Top = pnlPadleLeft.Top - incPadle;
  if (pnlPadleLeft.Top <= 0)
 pnlPadleLeft.Top = 1;
  }
  if (e.KeyCode == Keys.S)
  {
  pnlPadleLeft.Top = pnlPadleLeft.Top + incPadle;
  if (pnlPadleLeft.Bottom > pnlPong.Height)
  pnlPadleLeft.Top = pnlPong.Height - pnlPadleLeft.Height;
  }
  }
  
  
  
  
  
  
  
  
  
  
  }
 }

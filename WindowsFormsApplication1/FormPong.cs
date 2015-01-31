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
  
  
  
  
  
  
  
  
  
  
  
  }
 }

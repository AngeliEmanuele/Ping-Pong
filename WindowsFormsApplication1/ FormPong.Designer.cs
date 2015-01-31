namespace Pong
{
    partial class frmPong
    {
      private System.ComponentModel.IContainer components = null;
 
        protected override void Dispose(bool disposing)
        {
          if (disposing && (components != null))
          {
              components.Dispose();
          }
        base.Dispose(disposing);
        }
        private void InitializeComponent()
  {
      this.components = new System.ComponentModel.Container();
      this.pnlPong = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.Play = new System.Windows.Forms.Button();
      this.pnlBall = new System.Windows.Forms.Panel();
      this.pnlPadleRight = new System.Windows.Forms.Panel();
      this.pnlPadleLeft = new System.Windows.Forms.Panel();
      this.lblPuntiOne = new System.Windows.Forms.Label();
      this.lblPuntiTwo = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.pnlPong.SuspendLayout();
      this.SuspendLayout();
      //
      // pnlPong
      //
      this.pnlPong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlPong.BackColor = System.Drawing.Color.Black;
      this.pnlPong.Controls.Add(this.button1);
      this.pnlPong.Controls.Add(this.Play);
      this.pnlPong.Controls.Add(this.pnlBall);
      this.pnlPong.Controls.Add(this.pnlPadleRight);
      this.pnlPong.Controls.Add(this.pnlPadleLeft);
      this.pnlPong.Controls.Add(this.lblPuntiOne);
      this.pnlPong.Controls.Add(this.lblPuntiTwo);
      this.pnlPong.Location = new System.Drawing.Point(1, 2);
      this.pnlPong.Name = "pnlPong";
      this.pnlPong.Size = new System.Drawing.Size(679, 315);
      this.pnlPong.TabIndex = 0;
      //
      // button1
      //
      this.button1.Location = new System.Drawing.Point(360, 49);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Pausa";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Pausa);
      //
      // Play
      //
      this.Play.Location = new System.Drawing.Point(212, 49);
      this.Play.Name = "Play";
      this.Play.Size = new System.Drawing.Size(75, 23);
      this.Play.TabIndex = 3;
      this.Play.Text = "Play";
      this.Play.UseVisualStyleBackColor = true;
      this.Play.Click += new System.EventHandler(this.button1_Click);
      //
      // pnlBall
      //
      this.pnlBall.BackColor = System.Drawing.Color.Plum;
      this.pnlBall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnlBall.Location = new System.Drawing.Point(483, 239);
      this.pnlBall.Name = "pnlBall";
      this.pnlBall.Size = new System.Drawing.Size(18, 19);
      this.pnlBall.TabIndex = 2;
      this.pnlBall.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBall_Paint);
      //
      // pnlPadleRight
      //
      this.pnlPadleRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.pnlPadleRight.BackColor = System.Drawing.Color.SpringGreen;
      this.pnlPadleRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnlPadleRight.Location = new System.Drawing.Point(644, 122);
      this.pnlPadleRight.Name = "pnlPadleRight";
      this.pnlPadleRight.Size = new System.Drawing.Size(14, 100);
      this.pnlPadleRight.TabIndex = 1;
      //
      // pnlPadleLeft
      //
      this.pnlPadleLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.pnlPadleLeft.BackColor = System.Drawing.Color.SpringGreen;
      this.pnlPadleLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnlPadleLeft.Location = new System.Drawing.Point(23, 120);
      this.pnlPadleLeft.Name = "pnlPadleLeft";
      this.pnlPadleLeft.Size = new System.Drawing.Size(14, 100);
      this.pnlPadleLeft.TabIndex = 0;
      this.pnlPadleLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPadleLeft_Paint);
      //
      // lblPuntiOne
      //
      this.lblPuntiOne.AutoSize = true;
      this.lblPuntiOne.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPuntiOne.ForeColor = System.Drawing.Color.White;
      this.lblPuntiOne.Location = new System.Drawing.Point(109, 15);
      this.lblPuntiOne.Name = "lblPuntiOne";
      this.lblPuntiOne.Size = new System.Drawing.Size(34, 39);
      this.lblPuntiOne.TabIndex = 4;
      this.lblPuntiOne.Text = "0";
      //
      // lblPuntiTwo
      //
      this.lblPuntiTwo.AutoSize = true;
      this.lblPuntiTwo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPuntiTwo.ForeColor = System.Drawing.Color.White;
      this.lblPuntiTwo.Location = new System.Drawing.Point(524, 15);
      this.lblPuntiTwo.Name = "lblPuntiTwo";
      this.lblPuntiTwo.Size = new System.Drawing.Size(34, 39);
      this.lblPuntiTwo.TabIndex = 5;
      this.lblPuntiTwo.Text = "0";
      //
      // timer
      //
      this.timer.Interval = 10;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      //
      // frmPong
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(677, 315);
      this.Controls.Add(this.pnlPong);
      this.KeyPreview = true;
      this.Name = "frmPong";
      this.Text = "Pong";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPong_KeyDown);
      this.pnlPong.ResumeLayout(false);
      this.pnlPong.PerformLayout();
      this.ResumeLayout(false);
     
      }
     
      #endregion
     
      private System.Windows.Forms.Panel pnlPong;
      private System.Windows.Forms.Button Play;
      private System.Windows.Forms.Panel pnlBall;
      private System.Windows.Forms.Panel pnlPadleRight;
      private System.Windows.Forms.Panel pnlPadleLeft;
      private System.Windows.Forms.Timer timer;
      private System.Windows.Forms.Label lblPuntiTwo;
      private System.Windows.Forms.Label lblPuntiOne;
      private System.Windows.Forms.Button button1;
    }
}

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
    }
}

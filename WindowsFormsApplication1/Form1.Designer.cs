﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGioco = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlBall = new System.Windows.Forms.Panel();
            this.pnlGioco.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlGioco
            // 
            this.pnlGioco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGioco.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlGioco.Controls.Add(this.label2);
            this.pnlGioco.Controls.Add(this.label1);
            this.pnlGioco.Controls.Add(this.pnlRight);
            this.pnlGioco.Controls.Add(this.pnlLeft);
            this.pnlGioco.Controls.Add(this.button1);
            this.pnlGioco.Controls.Add(this.PnlBall);
            this.pnlGioco.Location = new System.Drawing.Point(0, 0);
            this.pnlGioco.Name = "pnlGioco";
            this.pnlGioco.Size = new System.Drawing.Size(450, 350);
            this.pnlGioco.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(300, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlRight.Location = new System.Drawing.Point(400, 100);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(17, 100);
            this.pnlRight.TabIndex = 6;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlLeft.Location = new System.Drawing.Point(12, 124);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(17, 100);
            this.pnlLeft.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "on/off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlBall
            // 
            this.PnlBall.BackColor = System.Drawing.Color.Aqua;
            this.PnlBall.Location = new System.Drawing.Point(220, 124);
            this.PnlBall.Name = "PnlBall";
            this.PnlBall.Size = new System.Drawing.Size(25, 26);
            this.PnlBall.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnlGioco);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlGioco.ResumeLayout(false);
            this.pnlGioco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlGioco;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlBall;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


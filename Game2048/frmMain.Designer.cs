namespace Game2048
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.chkSoundEffect = new System.Windows.Forms.CheckBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblValue8 = new System.Windows.Forms.Label();
            this.lblValue7 = new System.Windows.Forms.Label();
            this.lblValue6 = new System.Windows.Forms.Label();
            this.lblValue5 = new System.Windows.Forms.Label();
            this.lblValue16 = new System.Windows.Forms.Label();
            this.lblValue15 = new System.Windows.Forms.Label();
            this.lblValue14 = new System.Windows.Forms.Label();
            this.lblValue13 = new System.Windows.Forms.Label();
            this.lblValue12 = new System.Windows.Forms.Label();
            this.lblValue11 = new System.Windows.Forms.Label();
            this.lblValue10 = new System.Windows.Forms.Label();
            this.lblValue9 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.chkSoundEffect);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 404);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pontuação";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblScore.Location = new System.Drawing.Point(0, 359);
            this.lblScore.Margin = new System.Windows.Forms.Padding(8);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(192, 45);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "999999";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSoundEffect
            // 
            this.chkSoundEffect.AutoSize = true;
            this.chkSoundEffect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSoundEffect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkSoundEffect.Location = new System.Drawing.Point(56, 121);
            this.chkSoundEffect.Margin = new System.Windows.Forms.Padding(4);
            this.chkSoundEffect.Name = "chkSoundEffect";
            this.chkSoundEffect.Size = new System.Drawing.Size(123, 25);
            this.chkSoundEffect.TabIndex = 1;
            this.chkSoundEffect.TabStop = false;
            this.chkSoundEffect.Text = "Efeito Sonoro";
            this.chkSoundEffect.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.Location = new System.Drawing.Point(15, 32);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(164, 67);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblValue1
            // 
            this.lblValue1.BackColor = System.Drawing.Color.Snow;
            this.lblValue1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue1.ForeColor = System.Drawing.Color.Black;
            this.lblValue1.Location = new System.Drawing.Point(224, 32);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(80, 80);
            this.lblValue1.TabIndex = 1;
            this.lblValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue2
            // 
            this.lblValue2.BackColor = System.Drawing.Color.LightGray;
            this.lblValue2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue2.ForeColor = System.Drawing.Color.Black;
            this.lblValue2.Location = new System.Drawing.Point(310, 32);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(80, 80);
            this.lblValue2.TabIndex = 2;
            this.lblValue2.Text = "2";
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue3
            // 
            this.lblValue3.BackColor = System.Drawing.Color.Gray;
            this.lblValue3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue3.ForeColor = System.Drawing.Color.Black;
            this.lblValue3.Location = new System.Drawing.Point(396, 32);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(80, 80);
            this.lblValue3.TabIndex = 3;
            this.lblValue3.Text = "4";
            this.lblValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue4
            // 
            this.lblValue4.BackColor = System.Drawing.Color.Orange;
            this.lblValue4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue4.ForeColor = System.Drawing.Color.Black;
            this.lblValue4.Location = new System.Drawing.Point(482, 32);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(80, 80);
            this.lblValue4.TabIndex = 4;
            this.lblValue4.Text = "8";
            this.lblValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue8
            // 
            this.lblValue8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblValue8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue8.ForeColor = System.Drawing.Color.Black;
            this.lblValue8.Location = new System.Drawing.Point(482, 118);
            this.lblValue8.Name = "lblValue8";
            this.lblValue8.Size = new System.Drawing.Size(80, 80);
            this.lblValue8.TabIndex = 8;
            this.lblValue8.Text = "128";
            this.lblValue8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue7
            // 
            this.lblValue7.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValue7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue7.ForeColor = System.Drawing.Color.Black;
            this.lblValue7.Location = new System.Drawing.Point(396, 118);
            this.lblValue7.Name = "lblValue7";
            this.lblValue7.Size = new System.Drawing.Size(80, 80);
            this.lblValue7.TabIndex = 7;
            this.lblValue7.Text = "64";
            this.lblValue7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue6
            // 
            this.lblValue6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblValue6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue6.ForeColor = System.Drawing.Color.Black;
            this.lblValue6.Location = new System.Drawing.Point(310, 118);
            this.lblValue6.Name = "lblValue6";
            this.lblValue6.Size = new System.Drawing.Size(80, 80);
            this.lblValue6.TabIndex = 6;
            this.lblValue6.Text = "32";
            this.lblValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue5
            // 
            this.lblValue5.BackColor = System.Drawing.Color.OrangeRed;
            this.lblValue5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue5.ForeColor = System.Drawing.Color.Black;
            this.lblValue5.Location = new System.Drawing.Point(224, 118);
            this.lblValue5.Name = "lblValue5";
            this.lblValue5.Size = new System.Drawing.Size(80, 80);
            this.lblValue5.TabIndex = 5;
            this.lblValue5.Text = "16";
            this.lblValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue16
            // 
            this.lblValue16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValue16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue16.ForeColor = System.Drawing.Color.Black;
            this.lblValue16.Location = new System.Drawing.Point(482, 289);
            this.lblValue16.Name = "lblValue16";
            this.lblValue16.Size = new System.Drawing.Size(80, 80);
            this.lblValue16.TabIndex = 16;
            this.lblValue16.Text = "2048";
            this.lblValue16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue15
            // 
            this.lblValue15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValue15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue15.ForeColor = System.Drawing.Color.Black;
            this.lblValue15.Location = new System.Drawing.Point(396, 289);
            this.lblValue15.Name = "lblValue15";
            this.lblValue15.Size = new System.Drawing.Size(80, 80);
            this.lblValue15.TabIndex = 15;
            this.lblValue15.Text = "2048";
            this.lblValue15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue14
            // 
            this.lblValue14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValue14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue14.ForeColor = System.Drawing.Color.Black;
            this.lblValue14.Location = new System.Drawing.Point(310, 289);
            this.lblValue14.Name = "lblValue14";
            this.lblValue14.Size = new System.Drawing.Size(80, 80);
            this.lblValue14.TabIndex = 14;
            this.lblValue14.Text = "2048";
            this.lblValue14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue13
            // 
            this.lblValue13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValue13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue13.ForeColor = System.Drawing.Color.Black;
            this.lblValue13.Location = new System.Drawing.Point(224, 289);
            this.lblValue13.Name = "lblValue13";
            this.lblValue13.Size = new System.Drawing.Size(80, 80);
            this.lblValue13.TabIndex = 13;
            this.lblValue13.Text = "2048";
            this.lblValue13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue12
            // 
            this.lblValue12.BackColor = System.Drawing.Color.ForestGreen;
            this.lblValue12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue12.ForeColor = System.Drawing.Color.Black;
            this.lblValue12.Location = new System.Drawing.Point(482, 203);
            this.lblValue12.Name = "lblValue12";
            this.lblValue12.Size = new System.Drawing.Size(80, 80);
            this.lblValue12.TabIndex = 12;
            this.lblValue12.Text = "2048";
            this.lblValue12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue11
            // 
            this.lblValue11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblValue11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue11.ForeColor = System.Drawing.Color.Black;
            this.lblValue11.Location = new System.Drawing.Point(396, 203);
            this.lblValue11.Name = "lblValue11";
            this.lblValue11.Size = new System.Drawing.Size(80, 80);
            this.lblValue11.TabIndex = 11;
            this.lblValue11.Text = "1024";
            this.lblValue11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue10
            // 
            this.lblValue10.BackColor = System.Drawing.Color.BlueViolet;
            this.lblValue10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue10.ForeColor = System.Drawing.Color.Black;
            this.lblValue10.Location = new System.Drawing.Point(310, 203);
            this.lblValue10.Name = "lblValue10";
            this.lblValue10.Size = new System.Drawing.Size(80, 80);
            this.lblValue10.TabIndex = 10;
            this.lblValue10.Text = "512";
            this.lblValue10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue9
            // 
            this.lblValue9.BackColor = System.Drawing.Color.MediumPurple;
            this.lblValue9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue9.ForeColor = System.Drawing.Color.Black;
            this.lblValue9.Location = new System.Drawing.Point(224, 203);
            this.lblValue9.Name = "lblValue9";
            this.lblValue9.Size = new System.Drawing.Size(80, 80);
            this.lblValue9.TabIndex = 9;
            this.lblValue9.Text = "256";
            this.lblValue9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(260, 171);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(264, 65);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Game Over";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(589, 404);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblValue16);
            this.Controls.Add(this.lblValue15);
            this.Controls.Add(this.lblValue14);
            this.Controls.Add(this.lblValue13);
            this.Controls.Add(this.lblValue12);
            this.Controls.Add(this.lblValue11);
            this.Controls.Add(this.lblValue10);
            this.Controls.Add(this.lblValue9);
            this.Controls.Add(this.lblValue8);
            this.Controls.Add(this.lblValue7);
            this.Controls.Add(this.lblValue6);
            this.Controls.Add(this.lblValue5);
            this.Controls.Add(this.lblValue4);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblScore;
        private Label label1;
        private CheckBox chkSoundEffect;
        private Button btnNewGame;
        private Label lblValue1;
        private Label lblValue2;
        private Label lblValue3;
        private Label lblValue4;
        private Label lblValue8;
        private Label lblValue7;
        private Label lblValue6;
        private Label lblValue5;
        private Label lblValue16;
        private Label lblValue15;
        private Label lblValue14;
        private Label lblValue13;
        private Label lblValue12;
        private Label lblValue11;
        private Label lblValue10;
        private Label lblValue9;
        private Label lblMessage;
    }
}
namespace HackatonMagic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPVJ1 = new System.Windows.Forms.Label();
            this.lblPVJ2 = new System.Windows.Forms.Label();
            this.btnMinusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ2 = new System.Windows.Forms.Button();
            this.btnMinusJ2 = new System.Windows.Forms.Button();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.lblDice6Value = new System.Windows.Forms.Label();
            this.lblDice20Value = new System.Windows.Forms.Label();
            this.lblDiceXValue = new System.Windows.Forms.Label();
            this.btnRoll6 = new System.Windows.Forms.Button();
            this.btnRoll20 = new System.Windows.Forms.Button();
            this.BtnRollX = new System.Windows.Forms.Button();
            this.txtDiceX = new System.Windows.Forms.TextBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPVJ1
            // 
            this.lblPVJ1.AutoSize = true;
            this.lblPVJ1.Location = new System.Drawing.Point(336, 25);
            this.lblPVJ1.Name = "lblPVJ1";
            this.lblPVJ1.Size = new System.Drawing.Size(24, 17);
            this.lblPVJ1.TabIndex = 0;
            this.lblPVJ1.Text = "20";
            // 
            // lblPVJ2
            // 
            this.lblPVJ2.AutoSize = true;
            this.lblPVJ2.Location = new System.Drawing.Point(605, 25);
            this.lblPVJ2.Name = "lblPVJ2";
            this.lblPVJ2.Size = new System.Drawing.Size(24, 17);
            this.lblPVJ2.TabIndex = 1;
            this.lblPVJ2.Text = "20";
            // 
            // btnMinusJ1
            // 
            this.btnMinusJ1.Location = new System.Drawing.Point(256, 22);
            this.btnMinusJ1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinusJ1.Name = "btnMinusJ1";
            this.btnMinusJ1.Size = new System.Drawing.Size(75, 23);
            this.btnMinusJ1.TabIndex = 2;
            this.btnMinusJ1.Text = "-";
            this.btnMinusJ1.UseVisualStyleBackColor = true;
            this.btnMinusJ1.Click += new System.EventHandler(this.btnMinusJ1_Click);
            // 
            // btnPlusJ1
            // 
            this.btnPlusJ1.Location = new System.Drawing.Point(367, 22);
            this.btnPlusJ1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlusJ1.Name = "btnPlusJ1";
            this.btnPlusJ1.Size = new System.Drawing.Size(75, 23);
            this.btnPlusJ1.TabIndex = 3;
            this.btnPlusJ1.Text = "+";
            this.btnPlusJ1.UseVisualStyleBackColor = true;
            this.btnPlusJ1.Click += new System.EventHandler(this.btnPlusJ1_Click);
            // 
            // btnPlusJ2
            // 
            this.btnPlusJ2.Location = new System.Drawing.Point(636, 22);
            this.btnPlusJ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlusJ2.Name = "btnPlusJ2";
            this.btnPlusJ2.Size = new System.Drawing.Size(75, 23);
            this.btnPlusJ2.TabIndex = 4;
            this.btnPlusJ2.Text = "+";
            this.btnPlusJ2.UseVisualStyleBackColor = true;
            this.btnPlusJ2.Click += new System.EventHandler(this.btnPlusJ2_Click);
            // 
            // btnMinusJ2
            // 
            this.btnMinusJ2.Location = new System.Drawing.Point(525, 22);
            this.btnMinusJ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinusJ2.Name = "btnMinusJ2";
            this.btnMinusJ2.Size = new System.Drawing.Size(75, 23);
            this.btnMinusJ2.TabIndex = 5;
            this.btnMinusJ2.Text = "-";
            this.btnMinusJ2.UseVisualStyleBackColor = true;
            this.btnMinusJ2.Click += new System.EventHandler(this.btnMinusJ2_Click);
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(255, 64);
            this.txtNameP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(185, 22);
            this.txtNameP1.TabIndex = 6;
            this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(524, 64);
            this.txtNameP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(185, 22);
            this.txtNameP2.TabIndex = 7;
            this.txtNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDice6Value
            // 
            this.lblDice6Value.AutoSize = true;
            this.lblDice6Value.Location = new System.Drawing.Point(364, 121);
            this.lblDice6Value.Name = "lblDice6Value";
            this.lblDice6Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice6Value.TabIndex = 11;
            this.lblDice6Value.Text = "-";
            // 
            // lblDice20Value
            // 
            this.lblDice20Value.AutoSize = true;
            this.lblDice20Value.Location = new System.Drawing.Point(364, 171);
            this.lblDice20Value.Name = "lblDice20Value";
            this.lblDice20Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice20Value.TabIndex = 12;
            this.lblDice20Value.Text = "-";
            // 
            // lblDiceXValue
            // 
            this.lblDiceXValue.AutoSize = true;
            this.lblDiceXValue.Location = new System.Drawing.Point(364, 223);
            this.lblDiceXValue.Name = "lblDiceXValue";
            this.lblDiceXValue.Size = new System.Drawing.Size(13, 17);
            this.lblDiceXValue.TabIndex = 13;
            this.lblDiceXValue.Text = "-";
            // 
            // btnRoll6
            // 
            this.btnRoll6.Location = new System.Drawing.Point(309, 117);
            this.btnRoll6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoll6.Name = "btnRoll6";
            this.btnRoll6.Size = new System.Drawing.Size(49, 23);
            this.btnRoll6.TabIndex = 14;
            this.btnRoll6.Text = "Roll";
            this.btnRoll6.UseVisualStyleBackColor = true;
            this.btnRoll6.Click += new System.EventHandler(this.btnRoll6_Click);
            // 
            // btnRoll20
            // 
            this.btnRoll20.Location = new System.Drawing.Point(309, 167);
            this.btnRoll20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoll20.Name = "btnRoll20";
            this.btnRoll20.Size = new System.Drawing.Size(49, 23);
            this.btnRoll20.TabIndex = 15;
            this.btnRoll20.Text = "Roll";
            this.btnRoll20.UseVisualStyleBackColor = true;
            // 
            // BtnRollX
            // 
            this.BtnRollX.Location = new System.Drawing.Point(309, 220);
            this.BtnRollX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRollX.Name = "BtnRollX";
            this.BtnRollX.Size = new System.Drawing.Size(49, 23);
            this.BtnRollX.TabIndex = 16;
            this.BtnRollX.Text = "Roll";
            this.BtnRollX.UseVisualStyleBackColor = true;
            // 
            // txtDiceX
            // 
            this.txtDiceX.Location = new System.Drawing.Point(259, 220);
            this.txtDiceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiceX.Name = "txtDiceX";
            this.txtDiceX.Size = new System.Drawing.Size(44, 22);
            this.txtDiceX.TabIndex = 17;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1000;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 22);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(103, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 17);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDiceX);
            this.Controls.Add(this.BtnRollX);
            this.Controls.Add(this.btnRoll20);
            this.Controls.Add(this.btnRoll6);
            this.Controls.Add(this.lblDiceXValue);
            this.Controls.Add(this.lblDice20Value);
            this.Controls.Add(this.lblDice6Value);
            this.Controls.Add(this.txtNameP2);
            this.Controls.Add(this.txtNameP1);
            this.Controls.Add(this.btnMinusJ2);
            this.Controls.Add(this.btnPlusJ2);
            this.Controls.Add(this.btnPlusJ1);
            this.Controls.Add(this.btnMinusJ1);
            this.Controls.Add(this.lblPVJ2);
            this.Controls.Add(this.lblPVJ1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hackaton Magic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPVJ1;
        private System.Windows.Forms.Label lblPVJ2;
        private System.Windows.Forms.Button btnMinusJ1;
        private System.Windows.Forms.Button btnPlusJ1;
        private System.Windows.Forms.Button btnPlusJ2;
        private System.Windows.Forms.Button btnMinusJ2;
        private System.Windows.Forms.TextBox txtNameP1;
        private System.Windows.Forms.TextBox txtNameP2;
        private System.Windows.Forms.Label lblDice6Value;
        private System.Windows.Forms.Label lblDice20Value;
        private System.Windows.Forms.Label lblDiceXValue;
        private System.Windows.Forms.Button btnRoll6;
        private System.Windows.Forms.Button btnRoll20;
        private System.Windows.Forms.Button BtnRollX;
        private System.Windows.Forms.TextBox txtDiceX;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
    }
}


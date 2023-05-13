namespace WindowsFormsApp1
{
    partial class FormControls
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
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxFunds = new System.Windows.Forms.TextBox();
            this.buttonFunds = new System.Windows.Forms.Button();
            this.buttonPremium = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.buttonAccountDelete = new System.Windows.Forms.Button();
            this.buttonAdv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.buttonSignOut.ForeColor = System.Drawing.Color.White;
            this.buttonSignOut.Location = new System.Drawing.Point(741, 438);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(135, 72);
            this.buttonSignOut.TabIndex = 0;
            this.buttonSignOut.Text = "SIGN OUT";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(840, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(44, 44);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxFunds
            // 
            this.textBoxFunds.Location = new System.Drawing.Point(192, 183);
            this.textBoxFunds.Name = "textBoxFunds";
            this.textBoxFunds.Size = new System.Drawing.Size(117, 22);
            this.textBoxFunds.TabIndex = 2;
            // 
            // buttonFunds
            // 
            this.buttonFunds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.buttonFunds.Location = new System.Drawing.Point(14, 171);
            this.buttonFunds.Name = "buttonFunds";
            this.buttonFunds.Size = new System.Drawing.Size(154, 45);
            this.buttonFunds.TabIndex = 3;
            this.buttonFunds.Text = "Add funds";
            this.buttonFunds.UseVisualStyleBackColor = false;
            this.buttonFunds.Click += new System.EventHandler(this.ButtonAddFunds_Click);
            // 
            // buttonPremium
            // 
            this.buttonPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.buttonPremium.Location = new System.Drawing.Point(659, 282);
            this.buttonPremium.Name = "buttonPremium";
            this.buttonPremium.Size = new System.Drawing.Size(214, 69);
            this.buttonPremium.TabIndex = 4;
            this.buttonPremium.Text = "PREMIUM (50$)";
            this.buttonPremium.UseVisualStyleBackColor = false;
            this.buttonPremium.Click += new System.EventHandler(this.ButtonPremium_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.buttonAddEvent.Location = new System.Drawing.Point(14, 281);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(180, 70);
            this.buttonAddEvent.TabIndex = 5;
            this.buttonAddEvent.Text = "ADD EVENT";
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.ButtonEventAdder_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(6, 80);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 38);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<---";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonAtt
            // 
            this.buttonAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.buttonAtt.Location = new System.Drawing.Point(226, 281);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(180, 70);
            this.buttonAtt.TabIndex = 7;
            this.buttonAtt.Text = "CHECK ATTENDING EVENTS";
            this.buttonAtt.UseVisualStyleBackColor = false;
            this.buttonAtt.Click += new System.EventHandler(this.ButtonAtt_Click);
            // 
            // buttonAccountDelete
            // 
            this.buttonAccountDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.buttonAccountDelete.ForeColor = System.Drawing.Color.White;
            this.buttonAccountDelete.Location = new System.Drawing.Point(12, 438);
            this.buttonAccountDelete.Name = "buttonAccountDelete";
            this.buttonAccountDelete.Size = new System.Drawing.Size(182, 72);
            this.buttonAccountDelete.TabIndex = 8;
            this.buttonAccountDelete.Text = "DELETE ACCOUNT";
            this.buttonAccountDelete.UseVisualStyleBackColor = false;
            this.buttonAccountDelete.Click += new System.EventHandler(this.ButtonAccountDelete_Click);
            // 
            // buttonAdv
            // 
            this.buttonAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))));
            this.buttonAdv.Location = new System.Drawing.Point(442, 281);
            this.buttonAdv.Name = "buttonAdv";
            this.buttonAdv.Size = new System.Drawing.Size(180, 70);
            this.buttonAdv.TabIndex = 9;
            this.buttonAdv.Text = "ADD ADVERTISEMENT";
            this.buttonAdv.UseVisualStyleBackColor = false;
            this.buttonAdv.Click += new System.EventHandler(this.ButtonAdv_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxMoney);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 73);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo_smol;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(73, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "SPORTS HOBBY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(308, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "User";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(357, 21);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(149, 22);
            this.textBoxUsername.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(522, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "$$";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(555, 21);
            this.textBoxMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.ReadOnly = true;
            this.textBoxMoney.Size = new System.Drawing.Size(112, 22);
            this.textBoxMoney.TabIndex = 18;
            // 
            // FormControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 551);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAdv);
            this.Controls.Add(this.buttonAccountDelete);
            this.Controls.Add(this.buttonAtt);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.buttonPremium);
            this.Controls.Add(this.buttonFunds);
            this.Controls.Add(this.textBoxFunds);
            this.Controls.Add(this.buttonSignOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormControls";
            this.Text = "Controls";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxFunds;
        private System.Windows.Forms.Button buttonFunds;
        private System.Windows.Forms.Button buttonPremium;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.Button buttonAccountDelete;
        private System.Windows.Forms.Button buttonAdv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMoney;
    }
}
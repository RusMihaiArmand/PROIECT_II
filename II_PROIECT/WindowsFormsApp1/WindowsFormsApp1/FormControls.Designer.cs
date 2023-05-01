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
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(683, 356);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(105, 48);
            this.buttonSignOut.TabIndex = 0;
            this.buttonSignOut.Text = "sign out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(740, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 38);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxFunds
            // 
            this.textBoxFunds.Location = new System.Drawing.Point(57, 129);
            this.textBoxFunds.Name = "textBoxFunds";
            this.textBoxFunds.Size = new System.Drawing.Size(117, 22);
            this.textBoxFunds.TabIndex = 2;
            // 
            // buttonFunds
            // 
            this.buttonFunds.Location = new System.Drawing.Point(198, 123);
            this.buttonFunds.Name = "buttonFunds";
            this.buttonFunds.Size = new System.Drawing.Size(154, 34);
            this.buttonFunds.TabIndex = 3;
            this.buttonFunds.Text = "Add funds";
            this.buttonFunds.UseVisualStyleBackColor = true;
            this.buttonFunds.Click += new System.EventHandler(this.buttonAddFunds_Click);
            // 
            // buttonPremium
            // 
            this.buttonPremium.BackColor = System.Drawing.Color.Lime;
            this.buttonPremium.Location = new System.Drawing.Point(518, 106);
            this.buttonPremium.Name = "buttonPremium";
            this.buttonPremium.Size = new System.Drawing.Size(214, 69);
            this.buttonPremium.TabIndex = 4;
            this.buttonPremium.Text = "PREMIUM (50$)";
            this.buttonPremium.UseVisualStyleBackColor = false;
            this.buttonPremium.Click += new System.EventHandler(this.buttonPremium_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(276, 243);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(180, 70);
            this.buttonAddEvent.TabIndex = 5;
            this.buttonAddEvent.Text = "ADD EVENT";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonEventAdder_Click);
            // 
            // FormControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.buttonPremium);
            this.Controls.Add(this.buttonFunds);
            this.Controls.Add(this.textBoxFunds);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSignOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormControls";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
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
    }
}
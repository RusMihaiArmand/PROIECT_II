namespace WindowsFormsApp1
{
    partial class FormMainMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AddPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlaces = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(255, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(877, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 443);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(89, 105);
            this.textBoxPriceMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceMin.TabIndex = 4;
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(89, 134);
            this.textBoxPriceMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceMax.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 54);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Min Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max Price";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(17, 192);
            this.checkBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(88, 21);
            this.checkBoxDate.TabIndex = 12;
            this.checkBoxDate.Text = "Any Date";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(499, 12);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(133, 22);
            this.textBoxUsername.TabIndex = 14;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(945, 10);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(88, 27);
            this.buttonSettings.TabIndex = 15;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "User";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "$$";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(715, 13);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.ReadOnly = true;
            this.textBoxMoney.Size = new System.Drawing.Size(100, 22);
            this.textBoxMoney.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(1087, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(17, 357);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(229, 82);
            this.AddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPicture.TabIndex = 20;
            this.AddPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(89, 328);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(157, 22);
            this.textBoxLocation.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Available Places";
            // 
            // textBoxPlaces
            // 
            this.textBoxPlaces.Location = new System.Drawing.Point(131, 275);
            this.textBoxPlaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlaces.Name = "textBoxPlaces";
            this.textBoxPlaces.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlaces.TabIndex = 24;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1144, 507);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPlaces);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.AddPicture);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainMenu";
            this.Text = "SPORTS HOBBY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox AddPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlaces;
    }
}


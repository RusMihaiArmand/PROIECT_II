namespace WindowsFormsApp1
{
    partial class FormEventPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAttend = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDateStart = new System.Windows.Forms.TextBox();
            this.textBoxDateEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTotalPlaces = new System.Windows.Forms.TextBox();
            this.textBoxAvailablePlaces = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCreator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(971, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 31);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAttend
            // 
            this.buttonAttend.Location = new System.Drawing.Point(601, 385);
            this.buttonAttend.Name = "buttonAttend";
            this.buttonAttend.Size = new System.Drawing.Size(311, 52);
            this.buttonAttend.TabIndex = 7;
            this.buttonAttend.Text = "ATTEND";
            this.buttonAttend.UseVisualStyleBackColor = true;
            this.buttonAttend.Click += new System.EventHandler(this.buttonAttend_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(482, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(111, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 322);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(227, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(12, 350);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ReadOnly = true;
            this.textBoxDesc.Size = new System.Drawing.Size(420, 192);
            this.textBoxDesc.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(553, 65);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(111, 22);
            this.textBoxPrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date";
            // 
            // textBoxDateStart
            // 
            this.textBoxDateStart.Location = new System.Drawing.Point(523, 114);
            this.textBoxDateStart.Name = "textBoxDateStart";
            this.textBoxDateStart.ReadOnly = true;
            this.textBoxDateStart.Size = new System.Drawing.Size(207, 22);
            this.textBoxDateStart.TabIndex = 14;
            // 
            // textBoxDateEnd
            // 
            this.textBoxDateEnd.Location = new System.Drawing.Point(781, 114);
            this.textBoxDateEnd.Name = "textBoxDateEnd";
            this.textBoxDateEnd.ReadOnly = true;
            this.textBoxDateEnd.Size = new System.Drawing.Size(218, 22);
            this.textBoxDateEnd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total places";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Available places";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(601, 172);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(111, 22);
            this.textBoxLocation.TabIndex = 20;
            // 
            // textBoxTotalPlaces
            // 
            this.textBoxTotalPlaces.Location = new System.Drawing.Point(601, 211);
            this.textBoxTotalPlaces.Name = "textBoxTotalPlaces";
            this.textBoxTotalPlaces.ReadOnly = true;
            this.textBoxTotalPlaces.Size = new System.Drawing.Size(111, 22);
            this.textBoxTotalPlaces.TabIndex = 21;
            // 
            // textBoxAvailablePlaces
            // 
            this.textBoxAvailablePlaces.Location = new System.Drawing.Point(601, 239);
            this.textBoxAvailablePlaces.Name = "textBoxAvailablePlaces";
            this.textBoxAvailablePlaces.ReadOnly = true;
            this.textBoxAvailablePlaces.Size = new System.Drawing.Size(111, 22);
            this.textBoxAvailablePlaces.TabIndex = 22;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(848, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "<---";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Creator";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.Location = new System.Drawing.Point(601, 293);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.ReadOnly = true;
            this.textBoxCreator.Size = new System.Drawing.Size(111, 22);
            this.textBoxCreator.TabIndex = 26;
            // 
            // FormEventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 581);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxCreator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAvailablePlaces);
            this.Controls.Add(this.textBoxTotalPlaces);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDateEnd);
            this.Controls.Add(this.textBoxDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAttend);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEventPage";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAttend;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDateStart;
        private System.Windows.Forms.TextBox textBoxDateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxTotalPlaces;
        private System.Windows.Forms.TextBox textBoxAvailablePlaces;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCreator;
    }
}
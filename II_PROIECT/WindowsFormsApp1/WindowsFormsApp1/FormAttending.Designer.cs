namespace WindowsFormsApp1
{
    partial class FormAttending
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRef = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCreator = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDEBUG = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxPhotoId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDateStart = new System.Windows.Forms.TextBox();
            this.textBoxDateEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.buttonExit.Location = new System.Drawing.Point(861, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(42, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "My events";
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(445, 407);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(75, 33);
            this.buttonRef.TabIndex = 81;
            this.buttonRef.Text = "Refresh";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(429, 284);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 116);
            this.listBox1.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "creator";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.Location = new System.Drawing.Point(142, 378);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.ReadOnly = true;
            this.textBoxCreator.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreator.TabIndex = 78;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(57, 168);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 17);
            this.Date.TabIndex = 74;
            this.Date.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "nr pers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "locatie";
            // 
            // textBoxDEBUG
            // 
            this.textBoxDEBUG.Location = new System.Drawing.Point(418, 486);
            this.textBoxDEBUG.Name = "textBoxDEBUG";
            this.textBoxDEBUG.ReadOnly = true;
            this.textBoxDEBUG.Size = new System.Drawing.Size(332, 22);
            this.textBoxDEBUG.TabIndex = 71;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(142, 350);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.ReadOnly = true;
            this.textBoxPeople.Size = new System.Drawing.Size(100, 22);
            this.textBoxPeople.TabIndex = 70;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(142, 312);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocation.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(418, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 63);
            this.buttonDelete.TabIndex = 64;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(418, 39);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(171, 63);
            this.buttonFind.TabIndex = 63;
            this.buttonFind.Text = "FIND";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxPhotoId
            // 
            this.textBoxPhotoId.Location = new System.Drawing.Point(142, 268);
            this.textBoxPhotoId.Name = "textBoxPhotoId";
            this.textBoxPhotoId.ReadOnly = true;
            this.textBoxPhotoId.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhotoId.TabIndex = 62;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(142, 229);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 61;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(142, 113);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ReadOnly = true;
            this.textBoxDesc.Size = new System.Drawing.Size(200, 46);
            this.textBoxDesc.TabIndex = 60;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(142, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 59;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(142, 57);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "id";
            // 
            // textBoxDateStart
            // 
            this.textBoxDateStart.Location = new System.Drawing.Point(142, 165);
            this.textBoxDateStart.Name = "textBoxDateStart";
            this.textBoxDateStart.ReadOnly = true;
            this.textBoxDateStart.Size = new System.Drawing.Size(200, 22);
            this.textBoxDateStart.TabIndex = 83;
            // 
            // textBoxDateEnd
            // 
            this.textBoxDateEnd.Location = new System.Drawing.Point(142, 201);
            this.textBoxDateEnd.Name = "textBoxDateEnd";
            this.textBoxDateEnd.ReadOnly = true;
            this.textBoxDateEnd.Size = new System.Drawing.Size(200, 22);
            this.textBoxDateEnd.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "WARNING: money will NOT be refunded";
            // 
            // FormAttending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 646);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDateEnd);
            this.Controls.Add(this.textBoxDateStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCreator);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDEBUG);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxPhotoId);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAttending";
            this.Text = "Attending";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCreator;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDEBUG;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxPhotoId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDateStart;
        private System.Windows.Forms.TextBox textBoxDateEnd;
        private System.Windows.Forms.Label label8;
    }
}
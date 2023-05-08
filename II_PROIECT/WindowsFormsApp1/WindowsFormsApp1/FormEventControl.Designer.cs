namespace WindowsFormsApp1
{
    partial class FormEventControl
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPhotoId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonImg = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonClrImg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCreator = new System.Windows.Forms.TextBox();
            this.textBoxDEBUG = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRef = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDelOld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(624, 157);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 70);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "photo";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(137, 49);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 23;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(137, 105);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 46);
            this.textBoxDesc.TabIndex = 24;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(137, 221);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 27;
            // 
            // textBoxPhotoId
            // 
            this.textBoxPhotoId.Location = new System.Drawing.Point(137, 260);
            this.textBoxPhotoId.Name = "textBoxPhotoId";
            this.textBoxPhotoId.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhotoId.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 63);
            this.button1.TabIndex = 29;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(624, 324);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 63);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(874, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 36);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonImg
            // 
            this.buttonImg.Location = new System.Drawing.Point(259, 523);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(101, 39);
            this.buttonImg.TabIndex = 33;
            this.buttonImg.Text = "Find Image";
            this.buttonImg.UseVisualStyleBackColor = true;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(137, 157);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerStart.TabIndex = 34;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(137, 193);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerEnd.TabIndex = 35;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(137, 304);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocation.TabIndex = 36;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(137, 342);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(100, 22);
            this.textBoxPeople.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "locatie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "nr pers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "End Date";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(624, 246);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(171, 70);
            this.buttonModify.TabIndex = 44;
            this.buttonModify.Text = "MODIFY";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClrImg
            // 
            this.buttonClrImg.Location = new System.Drawing.Point(259, 478);
            this.buttonClrImg.Name = "buttonClrImg";
            this.buttonClrImg.Size = new System.Drawing.Size(101, 32);
            this.buttonClrImg.TabIndex = 45;
            this.buttonClrImg.Text = "Clear image";
            this.buttonClrImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClrImg.UseVisualStyleBackColor = true;
            this.buttonClrImg.Click += new System.EventHandler(this.buttonClrImg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "creator";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.Location = new System.Drawing.Point(137, 370);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.ReadOnly = true;
            this.textBoxCreator.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreator.TabIndex = 46;
            // 
            // textBoxDEBUG
            // 
            this.textBoxDEBUG.Location = new System.Drawing.Point(413, 478);
            this.textBoxDEBUG.Name = "textBoxDEBUG";
            this.textBoxDEBUG.ReadOnly = true;
            this.textBoxDEBUG.Size = new System.Drawing.Size(332, 22);
            this.textBoxDEBUG.TabIndex = 38;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(29, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 48;
            this.buttonBack.Text = "<---";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(424, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 116);
            this.listBox1.TabIndex = 49;
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(440, 399);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(75, 33);
            this.buttonRef.TabIndex = 50;
            this.buttonRef.Text = "Refresh";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "My events";
            // 
            // buttonDelOld
            // 
            this.buttonDelOld.Location = new System.Drawing.Point(624, 412);
            this.buttonDelOld.Name = "buttonDelOld";
            this.buttonDelOld.Size = new System.Drawing.Size(171, 42);
            this.buttonDelOld.TabIndex = 52;
            this.buttonDelOld.Text = "DELETE OLD";
            this.buttonDelOld.UseVisualStyleBackColor = true;
            this.buttonDelOld.Click += new System.EventHandler(this.buttonDelOld_Click);
            // 
            // FormEventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 646);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDelOld);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCreator);
            this.Controls.Add(this.buttonClrImg);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDEBUG);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEventControl";
            this.Text = "Event Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxPhotoId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonClrImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCreator;
        private System.Windows.Forms.TextBox textBoxDEBUG;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDelOld;
    }
}
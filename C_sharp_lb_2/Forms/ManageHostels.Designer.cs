namespace Lab_2.Forms
{
    partial class ManageHostels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageHostels));
            this.tb_studNumber = new System.Windows.Forms.TextBox();
            this.lb_hostelID = new System.Windows.Forms.Label();
            this.tb_hostelID = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_delStudents = new System.Windows.Forms.Button();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.gb_studNumber = new System.Windows.Forms.GroupBox();
            this.gb_roomNumber = new System.Windows.Forms.GroupBox();
            this.tb_roomNumber = new System.Windows.Forms.TextBox();
            this.bt_delRooms = new System.Windows.Forms.Button();
            this.bt_addRooms = new System.Windows.Forms.Button();
            this.gb_stuffNumber = new System.Windows.Forms.GroupBox();
            this.tb_stuffNumber = new System.Windows.Forms.TextBox();
            this.bt_delStuff = new System.Windows.Forms.Button();
            this.bt_addStuff = new System.Windows.Forms.Button();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.gb_calcProfits = new System.Windows.Forms.GroupBox();
            this.bt_calcProfit = new System.Windows.Forms.Button();
            this.rb_month = new System.Windows.Forms.RadioButton();
            this.rb_6month = new System.Windows.Forms.RadioButton();
            this.gb_studNumber.SuspendLayout();
            this.gb_roomNumber.SuspendLayout();
            this.gb_stuffNumber.SuspendLayout();
            this.gb_calcProfits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_studNumber
            // 
            this.tb_studNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_studNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_studNumber.Location = new System.Drawing.Point(12, 44);
            this.tb_studNumber.Multiline = true;
            this.tb_studNumber.Name = "tb_studNumber";
            this.tb_studNumber.Size = new System.Drawing.Size(457, 57);
            this.tb_studNumber.TabIndex = 12;
            this.tb_studNumber.TextChanged += new System.EventHandler(this.tb_studNumber_TextChanged);
            // 
            // lb_hostelID
            // 
            this.lb_hostelID.AutoSize = true;
            this.lb_hostelID.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_hostelID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_hostelID.Location = new System.Drawing.Point(238, 26);
            this.lb_hostelID.Name = "lb_hostelID";
            this.lb_hostelID.Size = new System.Drawing.Size(245, 41);
            this.lb_hostelID.TabIndex = 11;
            this.lb_hostelID.Text = "Гуртожиток №";
            this.lb_hostelID.Click += new System.EventHandler(this.lb_hostelID_Click);
            // 
            // tb_hostelID
            // 
            this.tb_hostelID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hostelID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_hostelID.Location = new System.Drawing.Point(489, 15);
            this.tb_hostelID.Multiline = true;
            this.tb_hostelID.Name = "tb_hostelID";
            this.tb_hostelID.Size = new System.Drawing.Size(64, 52);
            this.tb_hostelID.TabIndex = 9;
            this.tb_hostelID.TextChanged += new System.EventHandler(this.tb_hostelID_TextChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(272, 653);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(200, 54);
            this.bt_Cancel.TabIndex = 16;
            this.bt_Cancel.Text = "Назад";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_addStudents
            // 
            this.bt_addStudents.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_addStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStudents.FlatAppearance.BorderSize = 0;
            this.bt_addStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStudents.ForeColor = System.Drawing.Color.Honeydew;
            this.bt_addStudents.Location = new System.Drawing.Point(12, 97);
            this.bt_addStudents.Name = "bt_addStudents";
            this.bt_addStudents.Size = new System.Drawing.Size(231, 46);
            this.bt_addStudents.TabIndex = 15;
            this.bt_addStudents.Text = "Додати ";
            this.bt_addStudents.UseVisualStyleBackColor = false;
            this.bt_addStudents.Click += new System.EventHandler(this.bt_addStudents_Click);
            // 
            // bt_delStudents
            // 
            this.bt_delStudents.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_delStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStudents.FlatAppearance.BorderSize = 0;
            this.bt_delStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStudents.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStudents.Location = new System.Drawing.Point(236, 97);
            this.bt_delStudents.Name = "bt_delStudents";
            this.bt_delStudents.Size = new System.Drawing.Size(233, 46);
            this.bt_delStudents.TabIndex = 17;
            this.bt_delStudents.Text = "Видалити";
            this.bt_delStudents.UseVisualStyleBackColor = false;
            this.bt_delStudents.Click += new System.EventHandler(this.bt_delStudents_Click);
            // 
            // bt_showInfo
            // 
            this.bt_showInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_showInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showInfo.FlatAppearance.BorderSize = 0;
            this.bt_showInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_showInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_showInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_showInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_showInfo.Location = new System.Drawing.Point(161, 70);
            this.bt_showInfo.Name = "bt_showInfo";
            this.bt_showInfo.Size = new System.Drawing.Size(457, 61);
            this.bt_showInfo.TabIndex = 23;
            this.bt_showInfo.Text = "Інформація";
            this.bt_showInfo.UseVisualStyleBackColor = false;
            this.bt_showInfo.Click += new System.EventHandler(this.bt_showInfo_Click);
            // 
            // gb_studNumber
            // 
            this.gb_studNumber.Controls.Add(this.tb_studNumber);
            this.gb_studNumber.Controls.Add(this.bt_delStudents);
            this.gb_studNumber.Controls.Add(this.bt_addStudents);
            this.gb_studNumber.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_studNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_studNumber.Location = new System.Drawing.Point(2, 135);
            this.gb_studNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_studNumber.Name = "gb_studNumber";
            this.gb_studNumber.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_studNumber.Size = new System.Drawing.Size(525, 156);
            this.gb_studNumber.TabIndex = 25;
            this.gb_studNumber.TabStop = false;
            this.gb_studNumber.Text = "           Кількість студентів";
            // 
            // gb_roomNumber
            // 
            this.gb_roomNumber.Controls.Add(this.tb_roomNumber);
            this.gb_roomNumber.Controls.Add(this.bt_delRooms);
            this.gb_roomNumber.Controls.Add(this.bt_addRooms);
            this.gb_roomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_roomNumber.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_roomNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_roomNumber.Location = new System.Drawing.Point(2, 295);
            this.gb_roomNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_roomNumber.Name = "gb_roomNumber";
            this.gb_roomNumber.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_roomNumber.Size = new System.Drawing.Size(523, 149);
            this.gb_roomNumber.TabIndex = 26;
            this.gb_roomNumber.TabStop = false;
            this.gb_roomNumber.Text = "            Кількість кімнат";
            this.gb_roomNumber.Enter += new System.EventHandler(this.gb_roomNumber_Enter);
            // 
            // tb_roomNumber
            // 
            this.tb_roomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_roomNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_roomNumber.Location = new System.Drawing.Point(13, 42);
            this.tb_roomNumber.Multiline = true;
            this.tb_roomNumber.Name = "tb_roomNumber";
            this.tb_roomNumber.Size = new System.Drawing.Size(456, 58);
            this.tb_roomNumber.TabIndex = 12;
            this.tb_roomNumber.TextChanged += new System.EventHandler(this.tb_roomNumber_TextChanged);
            // 
            // bt_delRooms
            // 
            this.bt_delRooms.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_delRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delRooms.FlatAppearance.BorderSize = 0;
            this.bt_delRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delRooms.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delRooms.Location = new System.Drawing.Point(236, 92);
            this.bt_delRooms.Name = "bt_delRooms";
            this.bt_delRooms.Size = new System.Drawing.Size(233, 46);
            this.bt_delRooms.TabIndex = 17;
            this.bt_delRooms.Text = "Видалити";
            this.bt_delRooms.UseVisualStyleBackColor = false;
            this.bt_delRooms.Click += new System.EventHandler(this.bt_delRooms_Click);
            // 
            // bt_addRooms
            // 
            this.bt_addRooms.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_addRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addRooms.FlatAppearance.BorderSize = 0;
            this.bt_addRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addRooms.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addRooms.ForeColor = System.Drawing.Color.MintCream;
            this.bt_addRooms.Location = new System.Drawing.Point(13, 92);
            this.bt_addRooms.Name = "bt_addRooms";
            this.bt_addRooms.Size = new System.Drawing.Size(230, 46);
            this.bt_addRooms.TabIndex = 15;
            this.bt_addRooms.Text = "Додати";
            this.bt_addRooms.UseVisualStyleBackColor = false;
            this.bt_addRooms.Click += new System.EventHandler(this.bt_addRooms_Click);
            // 
            // gb_stuffNumber
            // 
            this.gb_stuffNumber.Controls.Add(this.tb_stuffNumber);
            this.gb_stuffNumber.Controls.Add(this.bt_delStuff);
            this.gb_stuffNumber.Controls.Add(this.bt_addStuff);
            this.gb_stuffNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_stuffNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gb_stuffNumber.Location = new System.Drawing.Point(2, 452);
            this.gb_stuffNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_stuffNumber.Name = "gb_stuffNumber";
            this.gb_stuffNumber.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_stuffNumber.Size = new System.Drawing.Size(525, 163);
            this.gb_stuffNumber.TabIndex = 27;
            this.gb_stuffNumber.TabStop = false;
            this.gb_stuffNumber.Text = "        Кількість робітників";
            // 
            // tb_stuffNumber
            // 
            this.tb_stuffNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_stuffNumber.Location = new System.Drawing.Point(13, 44);
            this.tb_stuffNumber.Multiline = true;
            this.tb_stuffNumber.Name = "tb_stuffNumber";
            this.tb_stuffNumber.Size = new System.Drawing.Size(457, 58);
            this.tb_stuffNumber.TabIndex = 12;
            this.tb_stuffNumber.TextChanged += new System.EventHandler(this.tb_stuffNumber_TextChanged);
            // 
            // bt_delStuff
            // 
            this.bt_delStuff.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_delStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStuff.FlatAppearance.BorderSize = 0;
            this.bt_delStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStuff.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStuff.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStuff.Location = new System.Drawing.Point(236, 96);
            this.bt_delStuff.Name = "bt_delStuff";
            this.bt_delStuff.Size = new System.Drawing.Size(234, 49);
            this.bt_delStuff.TabIndex = 17;
            this.bt_delStuff.Text = "Видалити";
            this.bt_delStuff.UseVisualStyleBackColor = false;
            this.bt_delStuff.Click += new System.EventHandler(this.bt_delStuff_Click);
            // 
            // bt_addStuff
            // 
            this.bt_addStuff.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_addStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStuff.FlatAppearance.BorderSize = 0;
            this.bt_addStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStuff.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStuff.ForeColor = System.Drawing.Color.MintCream;
            this.bt_addStuff.Location = new System.Drawing.Point(13, 96);
            this.bt_addStuff.Name = "bt_addStuff";
            this.bt_addStuff.Size = new System.Drawing.Size(230, 49);
            this.bt_addStuff.TabIndex = 15;
            this.bt_addStuff.Text = "Додати";
            this.bt_addStuff.UseVisualStyleBackColor = false;
            this.bt_addStuff.Click += new System.EventHandler(this.bt_addStuff_Click);
            // 
            // rb_year
            // 
            this.rb_year.AutoSize = true;
            this.rb_year.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_year.Location = new System.Drawing.Point(15, 57);
            this.rb_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_year.Name = "rb_year";
            this.rb_year.Size = new System.Drawing.Size(103, 35);
            this.rb_year.TabIndex = 28;
            this.rb_year.TabStop = true;
            this.rb_year.Text = "За рік";
            this.rb_year.UseVisualStyleBackColor = true;
            // 
            // gb_calcProfits
            // 
            this.gb_calcProfits.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_calcProfits.Controls.Add(this.bt_calcProfit);
            this.gb_calcProfits.Controls.Add(this.rb_month);
            this.gb_calcProfits.Controls.Add(this.rb_6month);
            this.gb_calcProfits.Controls.Add(this.rb_year);
            this.gb_calcProfits.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_calcProfits.ForeColor = System.Drawing.Color.Azure;
            this.gb_calcProfits.Location = new System.Drawing.Point(531, 158);
            this.gb_calcProfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_calcProfits.Name = "gb_calcProfits";
            this.gb_calcProfits.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_calcProfits.Size = new System.Drawing.Size(196, 449);
            this.gb_calcProfits.TabIndex = 29;
            this.gb_calcProfits.TabStop = false;
            this.gb_calcProfits.Text = "Дохід";
            // 
            // bt_calcProfit
            // 
            this.bt_calcProfit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_calcProfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calcProfit.FlatAppearance.BorderSize = 0;
            this.bt_calcProfit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_calcProfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_calcProfit.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_calcProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_calcProfit.Location = new System.Drawing.Point(14, 190);
            this.bt_calcProfit.Name = "bt_calcProfit";
            this.bt_calcProfit.Size = new System.Drawing.Size(155, 49);
            this.bt_calcProfit.TabIndex = 31;
            this.bt_calcProfit.Text = "Розрахунок";
            this.bt_calcProfit.UseVisualStyleBackColor = false;
            this.bt_calcProfit.Click += new System.EventHandler(this.bt_calcProfit_Click);
            // 
            // rb_month
            // 
            this.rb_month.AutoSize = true;
            this.rb_month.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_month.Location = new System.Drawing.Point(14, 143);
            this.rb_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_month.Name = "rb_month";
            this.rb_month.Size = new System.Drawing.Size(142, 35);
            this.rb_month.TabIndex = 30;
            this.rb_month.TabStop = true;
            this.rb_month.Text = "за місяць";
            this.rb_month.UseVisualStyleBackColor = true;
            // 
            // rb_6month
            // 
            this.rb_6month.AutoSize = true;
            this.rb_6month.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_6month.Location = new System.Drawing.Point(15, 100);
            this.rb_6month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_6month.Name = "rb_6month";
            this.rb_6month.Size = new System.Drawing.Size(149, 35);
            this.rb_6month.TabIndex = 29;
            this.rb_6month.TabStop = true;
            this.rb_6month.Text = "за півроку";
            this.rb_6month.UseVisualStyleBackColor = true;
            // 
            // ManageHostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(778, 719);
            this.Controls.Add(this.gb_calcProfits);
            this.Controls.Add(this.gb_stuffNumber);
            this.Controls.Add(this.gb_roomNumber);
            this.Controls.Add(this.gb_studNumber);
            this.Controls.Add(this.bt_showInfo);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.lb_hostelID);
            this.Controls.Add(this.tb_hostelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 770);
            this.MinimumSize = new System.Drawing.Size(800, 770);
            this.Name = "ManageHostels";
            this.Text = "Управління гуртожитками";
            this.Load += new System.EventHandler(this.ManageHostels_Load);
            this.gb_studNumber.ResumeLayout(false);
            this.gb_studNumber.PerformLayout();
            this.gb_roomNumber.ResumeLayout(false);
            this.gb_roomNumber.PerformLayout();
            this.gb_stuffNumber.ResumeLayout(false);
            this.gb_stuffNumber.PerformLayout();
            this.gb_calcProfits.ResumeLayout(false);
            this.gb_calcProfits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pb_2;
        private TextBox tb_studNumber;
        private Label lb_hostelID;
        private PictureBox pb_1;
        private TextBox tb_hostelID;
        private Button bt_Cancel;
        private Button bt_addStudents;
        private Button bt_delStudents;
        private Button bt_showInfo;
        private GroupBox gb_studNumber;
        private GroupBox gb_roomNumber;
        private TextBox tb_roomNumber;
        private PictureBox pb_3;
        private Button bt_delRooms;
        private Button bt_addRooms;
        private GroupBox gb_stuffNumber;
        private TextBox tb_stuffNumber;
        private PictureBox pb_4;
        private Button bt_delStuff;
        private Button bt_addStuff;
        private RadioButton radioButton1;
        private GroupBox gb_calcProfits;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rb_year;
        private Button bt_calcProfit;
        private RadioButton rb_month;
        private RadioButton rb_6month;
    }
}
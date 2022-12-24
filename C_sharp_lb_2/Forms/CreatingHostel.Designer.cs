namespace Lab_2
{
    partial class CreatingHostel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatingHostel));
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_staffNumber = new System.Windows.Forms.Label();
            this.tb_staffNumber = new System.Windows.Forms.TextBox();
            this.lb_roomsNumber = new System.Windows.Forms.Label();
            this.tb_roomsNumber = new System.Windows.Forms.TextBox();
            this.tb_hostelAddress = new System.Windows.Forms.TextBox();
            this.lb_hostelAddress = new System.Windows.Forms.Label();
            this.tb_univName = new System.Windows.Forms.TextBox();
            this.lb_univName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_OK.FlatAppearance.BorderSize = 0;
            this.bt_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_OK.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_OK.ForeColor = System.Drawing.Color.Ivory;
            this.bt_OK.Location = new System.Drawing.Point(133, 536);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(292, 89);
            this.bt_OK.TabIndex = 12;
            this.bt_OK.Text = "Додати гуртожиток";
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancel.ForeColor = System.Drawing.Color.LightGray;
            this.bt_Cancel.Location = new System.Drawing.Point(178, 643);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(207, 57);
            this.bt_Cancel.TabIndex = 13;
            this.bt_Cancel.Text = "Назад";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_staffNumber
            // 
            this.lb_staffNumber.AutoSize = true;
            this.lb_staffNumber.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_staffNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_staffNumber.Location = new System.Drawing.Point(133, 261);
            this.lb_staffNumber.Name = "lb_staffNumber";
            this.lb_staffNumber.Size = new System.Drawing.Size(310, 38);
            this.lb_staffNumber.TabIndex = 11;
            this.lb_staffNumber.Text = "Кількість працівників";
            // 
            // tb_staffNumber
            // 
            this.tb_staffNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_staffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_staffNumber.Location = new System.Drawing.Point(47, 302);
            this.tb_staffNumber.Multiline = true;
            this.tb_staffNumber.Name = "tb_staffNumber";
            this.tb_staffNumber.Size = new System.Drawing.Size(465, 59);
            this.tb_staffNumber.TabIndex = 9;
            this.tb_staffNumber.TextChanged += new System.EventHandler(this.tb_staffNumber_TextChanged);
            // 
            // lb_roomsNumber
            // 
            this.lb_roomsNumber.AutoSize = true;
            this.lb_roomsNumber.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_roomsNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_roomsNumber.Location = new System.Drawing.Point(155, 390);
            this.lb_roomsNumber.Name = "lb_roomsNumber";
            this.lb_roomsNumber.Size = new System.Drawing.Size(256, 41);
            this.lb_roomsNumber.TabIndex = 16;
            this.lb_roomsNumber.Text = "Кількість кімнат";
            // 
            // tb_roomsNumber
            // 
            this.tb_roomsNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_roomsNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_roomsNumber.Location = new System.Drawing.Point(47, 446);
            this.tb_roomsNumber.Multiline = true;
            this.tb_roomsNumber.Name = "tb_roomsNumber";
            this.tb_roomsNumber.Size = new System.Drawing.Size(465, 59);
            this.tb_roomsNumber.TabIndex = 14;
            this.tb_roomsNumber.TextChanged += new System.EventHandler(this.tb_roomsNumber_TextChanged);
            // 
            // tb_hostelAddress
            // 
            this.tb_hostelAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hostelAddress.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_hostelAddress.Location = new System.Drawing.Point(47, 187);
            this.tb_hostelAddress.Multiline = true;
            this.tb_hostelAddress.Name = "tb_hostelAddress";
            this.tb_hostelAddress.Size = new System.Drawing.Size(465, 59);
            this.tb_hostelAddress.TabIndex = 6;
            this.tb_hostelAddress.Text = " ";
            this.tb_hostelAddress.TextChanged += new System.EventHandler(this.tb_hostelAddress_TextChanged);
            // 
            // lb_hostelAddress
            // 
            this.lb_hostelAddress.AutoSize = true;
            this.lb_hostelAddress.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hostelAddress.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_hostelAddress.Location = new System.Drawing.Point(225, 146);
            this.lb_hostelAddress.Name = "lb_hostelAddress";
            this.lb_hostelAddress.Size = new System.Drawing.Size(125, 38);
            this.lb_hostelAddress.TabIndex = 8;
            this.lb_hostelAddress.Text = "Адреса";
            // 
            // tb_univName
            // 
            this.tb_univName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_univName.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_univName.Location = new System.Drawing.Point(47, 75);
            this.tb_univName.Multiline = true;
            this.tb_univName.Name = "tb_univName";
            this.tb_univName.Size = new System.Drawing.Size(465, 59);
            this.tb_univName.TabIndex = 1;
            this.tb_univName.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // lb_univName
            // 
            this.lb_univName.AutoSize = true;
            this.lb_univName.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_univName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_univName.Location = new System.Drawing.Point(80, 34);
            this.lb_univName.Name = "lb_univName";
            this.lb_univName.Size = new System.Drawing.Size(410, 38);
            this.lb_univName.TabIndex = 5;
            this.lb_univName.Text = "Назва навчального закладу";
            // 
            // CreatingHostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(565, 727);
            this.Controls.Add(this.lb_roomsNumber);
            this.Controls.Add(this.tb_roomsNumber);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.lb_staffNumber);
            this.Controls.Add(this.tb_staffNumber);
            this.Controls.Add(this.lb_hostelAddress);
            this.Controls.Add(this.tb_hostelAddress);
            this.Controls.Add(this.lb_univName);
            this.Controls.Add(this.tb_univName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 1051);
            this.MinimumSize = new System.Drawing.Size(461, 514);
            this.Name = "CreatingHostel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання гуртожитку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_OK;
        private Button bt_Cancel;
        private Label lb_staffNumber;
        private TextBox tb_staffNumber;
        private Label lb_roomsNumber;
        private TextBox tb_roomsNumber;
        private TextBox tb_hostelAddress;
        private Label lb_hostelAddress;
        private TextBox tb_univName;
        private Label lb_univName;
    }
}
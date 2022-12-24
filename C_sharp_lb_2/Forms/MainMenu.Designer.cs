namespace Lab_2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bt_CreateHostel = new System.Windows.Forms.Button();
            this.bt_hostelManager = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_CreateHostel
            // 
            this.bt_CreateHostel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_CreateHostel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateHostel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_CreateHostel.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_CreateHostel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_CreateHostel.Location = new System.Drawing.Point(12, 44);
            this.bt_CreateHostel.Name = "bt_CreateHostel";
            this.bt_CreateHostel.Size = new System.Drawing.Size(354, 60);
            this.bt_CreateHostel.TabIndex = 0;
            this.bt_CreateHostel.Text = "Створити новий гуртожиток";
            this.bt_CreateHostel.UseVisualStyleBackColor = false;
            this.bt_CreateHostel.Click += new System.EventHandler(this.bt_CreateHostel_Click);
            // 
            // bt_hostelManager
            // 
            this.bt_hostelManager.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_hostelManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_hostelManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_hostelManager.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_hostelManager.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hostelManager.Location = new System.Drawing.Point(12, 125);
            this.bt_hostelManager.Name = "bt_hostelManager";
            this.bt_hostelManager.Size = new System.Drawing.Size(354, 60);
            this.bt_hostelManager.TabIndex = 3;
            this.bt_hostelManager.Text = "Управління гуртожитками";
            this.bt_hostelManager.UseVisualStyleBackColor = false;
            this.bt_hostelManager.Click += new System.EventHandler(this.bt_hostelManager_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_exit.Location = new System.Drawing.Point(89, 224);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(210, 52);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.Text = "Вийти";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(375, 299);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_hostelManager);
            this.Controls.Add(this.bt_CreateHostel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 346);
            this.MinimumSize = new System.Drawing.Size(393, 346);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гуртожитки";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_CreateHostel;
        private Button bt_hostelManager;
        private Button bt_exit;
    }
}
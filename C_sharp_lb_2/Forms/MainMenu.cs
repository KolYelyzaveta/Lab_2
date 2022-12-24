using Lab_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {         
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти?", "Вихід", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes) Application.Exit();
        }

        private void bt_CreateHostel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatingHostel newHostel = new CreatingHostel();
            newHostel.Show();
        }

        private void bt_addCanteen_Click(object sender, EventArgs e)
        {

        }

        private void bt_hostelManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageHostels manageStudents = new ManageHostels();
            manageStudents.Show();
        }
    }
}

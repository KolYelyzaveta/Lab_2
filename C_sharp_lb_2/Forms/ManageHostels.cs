

using Hostels;

namespace Lab_2.Forms
{

    public partial class ManageHostels : Form
    {
        void Activator(bool val)
        {
            if (val == false)
            {
                tb_roomNumber.Text = "";
                tb_studNumber.Text = "";
                tb_stuffNumber.Text = "";
                bt_addStudents.Enabled = false;
                bt_delStudents.Enabled = false;
                bt_addRooms.Enabled = false;
                bt_delRooms.Enabled = false;
                bt_addStuff.Enabled = false;
                bt_delStuff.Enabled = false;
            }
            bt_showInfo.Enabled = val;
            gb_calcProfits.Enabled = val;

            tb_studNumber.Enabled = val;
            tb_roomNumber.Enabled = val;
            tb_stuffNumber.Enabled = val;


        }

        Hostel? hostel = null;
        public ManageHostels()
        {
            InitializeComponent();
        }

        private void tb_hostelID_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num) && Campus.FindingHostel(num, out hostel))
            {
                Activator(true);
            }
            else
            {
                Activator(false);
            }
        }

        private void tb_studNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                if (hostel.StudentAmount >= num)
                {
                    bt_delStudents.Enabled = true;
                }
                else bt_delStudents.Enabled = false;
                if (hostel.RoomsNumber * 3 >= num)
                {
                    bt_addStudents.Enabled = true;
                }
                else bt_addStudents.Enabled = false;
            }
            else
            {
                bt_addStudents.Enabled = false;
                bt_delStudents.Enabled = false;
            }
        }

        private void tb_roomNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                if (hostel.RoomsNumber >= num && ((hostel.RoomsNumber - num) * 3) >= hostel.StudentAmount)
                {
                    bt_delRooms.Enabled = true;
                }
                else bt_delRooms.Enabled = false;
                bt_addRooms.Enabled = true;
            }
            else
            {
                bt_addRooms.Enabled = false;
                bt_delRooms.Enabled = false;
            }
        }

        private void tb_stuffNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                if (hostel.StuffNumber >= num && (hostel.StuffNumber - num) >= 1)
                {
                    bt_delStuff.Enabled = true;
                }
                else
                    bt_delStuff.Enabled = false;
                bt_addStuff.Enabled = true;
            }
            else
            {
                bt_addStuff.Enabled = false;
                bt_delStuff.Enabled = false;
            }
        }

        private void ManageHostels_Load(object sender, EventArgs e)
        {
            Activator(false);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }



        private void bt_addStudents_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_studNumber.Text);
            hostel.StudentAmount += amount;
            MessageBox.Show($"Студенти були додані до гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_studNumber.Text = "";
        }

        private void bt_delStudents_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_studNumber.Text);
            hostel.StudentAmount -= amount;
            MessageBox.Show($"Студенти були видалені з гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_studNumber.Text = "";
        }



        private void bt_addRooms_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_roomNumber.Text);
            hostel.RoomsNumber += amount;
            MessageBox.Show($"Кімнати були додані до гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tb_roomNumber.Text = "";
        }

        private void bt_delRooms_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_roomNumber.Text);
            hostel.RoomsNumber -= amount;
            MessageBox.Show($"Кімнати були видалені з гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tb_roomNumber.Text = "";
        }



        private void bt_addStuff_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_stuffNumber.Text);
            hostel.StuffNumber += amount;
            MessageBox.Show($"Працівники були додані до гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_stuffNumber.Text = "";
        }

        private void bt_delStuff_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_stuffNumber.Text);
            hostel.StuffNumber -= amount;
            MessageBox.Show($"Працівники були видалені з гуртожитку № {hostel.ID}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_stuffNumber.Text = "";
        }

        private void bt_showInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hostel.ToString(), $"Інформація про гуртожиток № {hostel.ID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void bt_calcProfit_Click(object sender, EventArgs e)
        {
            if(rb_month.Checked) MessageBox.Show($"Місячний прибуток : {hostel.hostelProfit} грн.", "Місячний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_6month.Checked) MessageBox.Show($"Піврічний прибуток : {hostel.hostelProfit * 6} грн.", "Піврічний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_year.Checked) MessageBox.Show($"Річний прибуток : {hostel.hostelProfit * 12} грн.", "Річний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"Оберіть період для розрахунку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lb_hostelID_Click(object sender, EventArgs e)
        {

        }

        private void gb_roomNumber_Enter(object sender, EventArgs e)
        {

        }
    }
}

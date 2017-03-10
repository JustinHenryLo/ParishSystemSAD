using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OhWell
{
    public partial class DonorProfiles : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database=bloodlettingprototye;uid=root;pwd=root");
        public DonorProfiles()
        {
            InitializeComponent();
        }

        public BloodLettingModule reference_to_main; 

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand com;
                if (DonorGenderComboBox.Text == "Male")
                {
                    com = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonor` ( `firstName`, `lastName`, `birthDate`, `gender`, `bloodType`) VALUES ('" + DonorFirstNameTxt.Text + "', '" + DonorLastNameTxt.Text + "', '" + DonorBirthDate.Value.ToString("MM dd yyyy") + "', 1, '" + DonorBloodLettingCombobox.SelectedItem.ToString() + "')", con);
                }
               else
                {
                    com = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonor` ( `firstName`, `lastName`, `birthDate`, `gender`, `bloodType`) VALUES ('" + DonorFirstNameTxt.Text + "', '" + DonorLastNameTxt.Text + "', '" + DonorBirthDate.Value.ToString("MM dd yyyy") + "', 2, '" + DonorBloodLettingCombobox.SelectedItem.ToString() + "')", con);
                }  
                com.ExecuteNonQuery();
                con.Close();


            }
            catch
            {
                con.Close();
            }


            refreshDonor();
            refreshDonorView();
        }

       public void refreshDonor()
        {
            DonorFirstNameTxt.Text = "";
            DonorLastNameTxt.Text = "";
            DonorBirthDate.Value = DateTime.Now;
            DonorGenderComboBox.SelectedIndex = 0;
            DonorBloodLettingCombobox.SelectedIndex = 0;
        }

        public void refreshDonorView()
        {
            try
            {

                con.Open();

                MySqlCommand com = new MySqlCommand("Select * from  blooddonor", con);
                con.Close();
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                adp.Fill(dt);

                dt2.Columns.Add("DonorID");
                dt2.Columns.Add("Firstname");
                dt2.Columns.Add("Lastname");
                dt2.Columns.Add("Birthdate");
                dt2.Columns.Add("Gender");
                dt2.Columns.Add("Blood Type");
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    DataRow dr = dt2.NewRow();
                    dr[0] = dt.Rows[x][0].ToString();
                    dr[1] = dt.Rows[x][1].ToString(); ;
                    dr[2] = dt.Rows[x][2].ToString(); ;
                    dr[3] = dt.Rows[x][4].ToString(); ;
                    dr[5] = dt.Rows[x][5].ToString(); ;
                    if (dt.Rows[x][3].ToString() == "1")
                    {
                        dr[4] = "Male";
                    }
                    else
                    {
                        dr[4] = "Female"; ;
                    }
                    dt2.Rows.Add(dr);

                }

                DonorView.DataSource = dt2;
                DonorView.Columns[0].Visible = false;
            }
            catch
            {
                con.Close();
            }
            }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Region of FORM no border drag thingy
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DonorProfiles_Load(object sender, EventArgs e)
        {
            DonorBirthDate.Value = DateTime.Now;
            EventDateTimePicker.Value = DateTime.Now;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private const int HT_CAPTION = 0x2;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DonorLastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand com = new MySqlCommand();

                com = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonationevent` (`eventName`, `eventDate`, `eventStatus`, `eventVenue`, `eventDetails`) VALUES ('" + EventNameTxt.Text + "', '" + EventDateTimePicker.Value.ToString("MM dd yyyy") + "', " + EventStatusCombobox.SelectedIndex + ", '" + EventVenueTextBox.Text.ToString() + "', '" + EventDetailsTextBox.Text.ToString() + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
            }


            EventViewRefresh();
            resetEvent();
        }
        public void EventViewRefresh()
        {
            try
            {
                con.Open();
                MySqlCommand com = new MySqlCommand();
                com = new MySqlCommand("select * from blooddonationevent", con);
                con.Close();
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                adp.Fill(dt);
               
                dt2.Columns.Add("EventID");
                dt2.Columns.Add("Event Name");
                dt2.Columns.Add("Event Date");
                dt2.Columns.Add("Event Status");
                dt2.Columns.Add("Event Venue");
                dt2.Columns.Add("Event Details");
                
                for (int x=0;x<dt.Rows.Count; x++)
                {
                   
                    DataRow dr = dt2.NewRow();
                    dr[0] = dt.Rows[x][0].ToString();
                    dr[1] = dt.Rows[x][1].ToString();

                    dr[2] = dt.Rows[x][2].ToString();
                    Console.WriteLine(dt.Rows[x][3].ToString());
                    if (dt.Rows[x][3].ToString()=="1")
                    {
                        dr[3] = "Finished";
                    }
                    else if (dt.Rows[x][3].ToString() == "2")
                    {
                        dr[3] = "On-going";
                    }
                    else
                    {
                        dr[3] = "Queued";
                    }
                    dr[4] = dt.Rows[x][4].ToString();
                    dr[5] = dt.Rows[x][5].ToString();

                    dt2.Rows.Add(dr);
                }
                
                BloodlettingEventView.DataSource = dt2;
                BloodlettingEventView.Columns[0].Visible = false;



                


            }
            catch
            {
                con.Close();
            }
        }

        public void resetEvent()
        {
            EventNameTxt.Text = "";
            EventDateTimePicker.Value = DateTime.Now;
            EventStatusCombobox.SelectedIndex = 0;
            EventVenueTextBox.Text = "";
            EventDetailsTextBox.Text = "";
        }

        private void EventVenueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BloodlettingEventView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                con.Open();

                MySqlCommand com = new MySqlCommand("Select * from blooddonationevent where bloodDonationEventID = " + BloodlettingEventView.Rows[e.RowIndex].Cells["EventID"].Value.ToString(), con);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                EventID.Text = dt.Rows[0][0].ToString();
                EventNameLabel.Text = dt.Rows[0][1].ToString();
                EventDateLabel.Text = new DateTime(int.Parse(dt.Rows[0][2].ToString().Substring(6, 4)), int.Parse(dt.Rows[0][2].ToString().Substring(0, 2)), int.Parse(dt.Rows[0][2].ToString().Substring(3, 2))).ToString("MM dd yyyy");
                if (int.Parse(dt.Rows[0][3].ToString())==1) {
                    EventStatusLabel.Text = "Finished";
                }
                else if (int.Parse(dt.Rows[0][3].ToString()) == 2)
                {
                    EventStatusLabel.Text = "On-going";
                }
                else
                {
                    EventStatusLabel.Text = "Queued";
                }
                EventVenueLabel.Text = dt.Rows[0][4].ToString();
                DetailsLabel.Text = dt.Rows[0][5].ToString();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void DonorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                con.Open();

                MySqlCommand com = new MySqlCommand("Select * from blooddonor where bloodDonorID = " + BloodlettingEventView.Rows[e.RowIndex].Cells[0].Value.ToString(), con);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                DonorFirstNameTxt.Text = dt.Rows[0][1].ToString();
                DonorLastNameTxt.Text = dt.Rows[0][2].ToString();
                DonorBirthDate.Value = new DateTime(int.Parse(dt.Rows[0][4].ToString().Substring(6, 4)), int.Parse(dt.Rows[0][4].ToString().Substring(0, 2)), int.Parse(dt.Rows[0][4].ToString().Substring(3, 2)));
                DonorGenderComboBox.SelectedIndex = int.Parse(dt.Rows[0][3].ToString());
                DonorBloodLettingCombobox.Text = dt.Rows[0][5].ToString();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comADD;
            if (EventStatusLabel.Text=="Finished")
            {
                comADD = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonationeventarchive` (`bloodDonationEventID`, `eventName`, `eventDate`, `eventStatus`, `eventVenue`, `eventDetails`) VALUES (" + EventID.Text + ", '" + EventNameLabel.Text + "', '" + EventDateLabel.Text + "',1, '" + EventVenueLabel.Text + "', '" + DetailsLabel.Text + "')", con);
            }
            else if (EventStatusLabel.Text == "On-going")
            {
                comADD = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonationeventarchive` (`bloodDonationEventID`, `eventName`, `eventDate`, `eventStatus`, `eventVenue`, `eventDetails`) VALUES (" + EventID.Text + ", '" + EventNameLabel.Text + "', '" + EventDateLabel.Text + "',2, '" + EventVenueLabel.Text + "', '" + DetailsLabel.Text + "')", con);
            }
            else
            {
                comADD = new MySqlCommand("INSERT INTO `bloodlettingprototye`.`blooddonationeventarchive` (`bloodDonationEventID`, `eventName`, `eventDate`, `eventStatus`, `eventVenue`, `eventDetails`) VALUES (" + EventID.Text + ", '" + EventNameLabel.Text + "', '" + EventDateLabel.Text + "',3, '" + EventVenueLabel.Text + "', '" + DetailsLabel.Text + "')", con);
            }
            
           comADD.ExecuteNonQuery();
           MySqlCommand comDEL = new MySqlCommand("DELETE FROM `bloodlettingprototye`.`blooddonationevent` WHERE `bloodDonationEventID`=" + EventID.Text, con);
            comDEL.ExecuteNonQuery();
            con.Close();
            EventViewRefresh();
            ResetBloodlettingEvent();
        }
        private void ResetBloodlettingEvent()
        {
            EventNameLabel.Text = "";
            EventDateLabel.Text = "";
            EventStatusLabel.Text = "";
            EventVenueLabel.Text = "";
            DetailsLabel.Text = "";
        }
    }


}

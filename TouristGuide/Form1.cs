using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TouristGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rolecb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role !");
            }
            else if (Rolecb.SelectedIndex == 0)
            {

                //Admin selected
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name And Password");
                }

                    try
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from admintb where username='" + UnameTb.Text + "'and password='" + PasswordTb.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {

                            adminHome obj = new adminHome();
                            obj.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong officer name or password");
                            UnameTb.Text = "";
                            PasswordTb.Text = "";
                        }
                        Con.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from usertb where username='" + UnameTb.Text + "'and password='" + PasswordTb.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {

                            UserHome obj = new UserHome();
                            obj.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong officer name or password");
                            UnameTb.Text = "";
                            PasswordTb.Text = "";
                        }
                        Con.Close();

                    }
                    catch (Exception Ex) {

                    MessageBox.Show(Ex.Message);
                
                    }
                }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
        }
    }


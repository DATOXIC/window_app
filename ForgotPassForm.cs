using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace window_app
{
    public partial class ForgotPassForm : Form
    {
        string connStr =
        @"Data Source=LAPTOP-2GVISSN1;
        Initial Catalog=LoginDB;
        Integrated Security=True;
        TrustServerCertificate=True";
        public ForgotPassForm()
        {
            InitializeComponent();
        }
        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            grbChangePass.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query =
            "SELECT Question1, Question2 FROM Users WHERE Username=@user";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", txtUsername.Text);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblQuestion1.Text = reader["Question1"].ToString();
                lblQuestion2.Text = reader["Question2"].ToString();
            }
            else
            {
                MessageBox.Show("Username not found!");
            }

            conn.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query =
            @"SELECT * FROM Users
      WHERE Username=@user
      AND Answer1=@a1
      AND Answer2=@a2";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@a1", cbbAnswer1.Text);
            cmd.Parameters.AddWithValue("@a2", cbbAnswer2.Text);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Correct Answers!");

                grbChangePass.Visible = true;
                grbChangePass.Refresh();
            }
            else
            {
                MessageBox.Show("Wrong Answers!");
            }
            conn.Close();
        }
            private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password does not match!");
                return;
            }

            SqlConnection conn = new SqlConnection(connStr);

            string query =
            @"UPDATE Users
      SET Passwords=@pass
      WHERE Username=@user";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@pass", txtNewPass.Text.Trim());
            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Change Password Succesfully !");
        }
    }
}

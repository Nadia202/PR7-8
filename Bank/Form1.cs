using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите логин и пароль.");
            }
            else
            {
                if (textBox1.Text == "")
                {
                     MessageBox.Show("Логин не введён!");
                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Пароль не введён!");
                    }
                    else
                    {
                        Connection connect = new Connection();
                        SqlConnection connection = connect.Connect();
                        connection.Open();
                        SqlCommand login = new SqlCommand($"SELECT COUNT(Login) From User$ WHERE Login = {textBox1.Text}",connection);
                        int log = (int)login.ExecuteScalar();
                        SqlCommand password = new SqlCommand($"SELECT COUNT(Password) FROM User$ WHERE Login = {textBox1.Text} AND Password = '{textBox2.Text}'",connection);
                        int pass = (int)password.ExecuteScalar();
                        if (log == 1)
                        {
                            if (pass == 1)
                            {
                                Form2 form2 = new Form2();
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Пароль неверный!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пользоваеля с данным логином не существует!");
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

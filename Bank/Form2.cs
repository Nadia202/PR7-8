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
    public partial class Form2 : Form
    {
        public static Form2 form2;
        public Form2()
        {
            InitializeComponent();
            form2 = this;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Table();
        }
        public void Table()
        {
            Connection con = new Connection();
            SqlConnection c = con.Connect();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    c.Open();
                    SqlDataAdapter users = new SqlDataAdapter("SELECT * FROM User$",c);
                    DataSet ds_user = new DataSet();
                    users.Fill(ds_user);
                    dataGridView1.DataSource = ds_user.Tables[0];
                    c.Close();
                    label1.Text = "Login"; label2.Text = "Password"; label3.Text = "Name"; label4.Text = "Surname"; label5.Text = "Patronymic";
                    label6.Text = "Series"; label7.Text = "Number"; label8.Text = "Phone"; label9.Text = "Adress"; label10.Text = "E-Mail";
                    label11.Text = "Date of issue"; label12.Text = "Issued"; label13.Text = "Date of birth"; label14.Text = "Place of birth";
                    textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
                    textBox6.Visible = true; textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true;
                    textBox11.Visible = true; textBox12.Visible = true; textBox13.Visible = true; textBox14.Visible = true;
                    textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
                    textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = ""; textBox10.Text = "";
                    textBox11.Text = ""; textBox12.Text = ""; textBox13.Text = ""; textBox14.Text = ""; numericUpDown1.Value = 1;
                    button2.Visible = true; button2.Enabled = true;
                    button3.Visible = true; button3.Enabled = true;
                    button4.Visible = false; button4.Enabled = false;
                    numericUpDown1.Visible = true; numericUpDown1.Enabled = true;
                    break;
                case 1:
                    SqlDataAdapter contract = new SqlDataAdapter("SELECT * FROM Contract$", c);
                    DataSet ds_contract = new DataSet();
                    contract.Fill(ds_contract);
                    dataGridView1.DataSource = ds_contract.Tables[0];
                    c.Close();
                    label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = "";
                    label6.Text = ""; label7.Text = ""; label8.Text = ""; label9.Text = ""; label10.Text = "";
                    label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = "";
                    textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
                    textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox9.Visible = false; textBox10.Visible = false;
                    textBox11.Visible = false; textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false;
                    button2.Visible = false; button2.Enabled = false;
                    button3.Visible = false; button3.Enabled = false;
                    button4.Visible = true; button4.Enabled = true;
                    numericUpDown1.Visible = true; numericUpDown1.Enabled = true;
                    break;
                case 2:
                    SqlDataAdapter history = new SqlDataAdapter("SELECT * FROM History$", c);
                    DataSet ds_history = new DataSet();
                    history.Fill(ds_history);
                    dataGridView1.DataSource = ds_history.Tables[0];
                    c.Close();
                    label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = "";
                    label6.Text = ""; label7.Text = ""; label8.Text = ""; label9.Text = ""; label10.Text = "";
                    label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = "";
                    textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
                    textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox9.Visible = false; textBox10.Visible = false;
                    textBox11.Visible = false; textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false;
                    button2.Visible = false; button2.Enabled = false;
                    button3.Visible = false; button3.Enabled = false;
                    button4.Visible = false; button4.Enabled = false;
                    numericUpDown1.Visible = false; numericUpDown1.Enabled = false;
                    break;
                case 3:
                    SqlDataAdapter bank_account = new SqlDataAdapter("SELECT * FROM BankAccount$", c);
                    DataSet ds_bank = new DataSet();
                    bank_account.Fill(ds_bank);
                    dataGridView1.DataSource = ds_bank.Tables[0];
                    c.Close();
                    label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = "";
                    label6.Text = ""; label7.Text = ""; label8.Text = ""; label9.Text = ""; label10.Text = "";
                    label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = "";
                    textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
                    textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox9.Visible = false; textBox10.Visible = false;
                    textBox11.Visible = false; textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false;
                    button2.Visible = false; button2.Enabled = false;
                    button3.Visible = false; button3.Enabled = false;
                    button4.Visible = false; button4.Enabled = false;
                    numericUpDown1.Visible = false; numericUpDown1.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.AddUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text);
            Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.UpdateUser((int)numericUpDown1.Value, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text);
            Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.DelContract((long)numericUpDown1.Value);
            Table();
        }
    }
}

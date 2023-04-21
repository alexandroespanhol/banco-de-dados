using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=univercidade;password=;");
            MySqlCommand cmd = new MySqlCommand("Insert Into alunos2 (name,list) values(@Name, @List)", conn);
            cmd.Parameters.AddWithValue("@Name", textBox1nome.Text);
            cmd.Parameters.AddWithValue("@List", textBox1List.Text);
            conn.Open();
            int rowsAffcted = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowsAffcted > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("!Falha ao inserir dados.");
            }
   
        }
    }
}

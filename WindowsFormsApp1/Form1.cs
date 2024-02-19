using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Substitua a string de conexão com os detalhes do seu banco de dados local
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programas\SAT\SAT\WindowsFormsApp1\SAT.mdf;Integrated Security=True";
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if (TestarConexao())
            {
                MessageBox.Show("Conexão bem-sucedida!");
            }
            else
            {
                MessageBox.Show("Falha na conexão. Verifique as configurações.");
            }
        }

        private bool TestarConexao()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    // Se ocorrer um erro, você pode exibir uma mensagem de erro ou registrar o erro para análise
                    MessageBox.Show("Erro de conexão: " + ex.Message);
                    return false;
                }
            }
        }   
            public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            
            
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3
{
    public partial class frmLogado : Form
    {
        public frmLogado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text;

            WebClient client = new WebClient();
             
            var content = client.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");
            MessageBox.Show(content, "CEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
            MessageBox.Show(content, "USD-BRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBu_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
            MessageBox.Show(content, "BRL-USD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogado_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            var data = DateTime.Now;

            
            MessageBox.Show(data.ToString("HH:mm:ss"), "Hora", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            var data = DateTime.Now;


            MessageBox.Show(data.ToString("dd/MM/yyyy"), "Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3
{
    public partial class Login : Form
    {
        int i = 0;
        string[,] cadastro = new string[5, 5];
        int estado = 0;

        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            Boolean x = false;

            for(int j = 0; j <= i; j++)
            {
                if (login == cadastro[j, 0] && senha == cadastro[j, 1])
                {
                    x = true;
                    
                }
                
            }
            if (x == true)
            {
                MessageBox.Show("logado com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                frmLogado logado = new frmLogado();
                logado.Show();
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("falha de login","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtLogin.Clear();
            txtSenha.Clear();




        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastro[i, 0] = txtLogin.Text;
            cadastro[i, 1] = txtSenha.Text;
            i += 1;
            txtLogin.Clear();
            txtSenha.Clear();

            MessageBox.Show("Cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1BERNARDO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome, endereco;
            int conta, agencia, telefone;
            double saldo;
            nome = txtNome.Text;
            endereco = txtEndereco.Text;
            conta = int.Parse(txtconta.Text);
            agencia = int.Parse(txtAgencia.Text);
            telefone = int.Parse(txtTelefone.Text);
            saldo = double.Parse(txtSaldo.Text);
            if (nome != null || endereco != null || conta != null ||  agencia != null || telefone != null || saldo != null) 
            {
                Form2 novaForm = new Form2(nome, endereco, conta, agencia, telefone, saldo);
                novaForm.Show();
                 }
            else { return; }
        }
    }
}

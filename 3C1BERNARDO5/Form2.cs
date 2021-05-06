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
    public partial class Form2 : Form
    {
        double num1, num2, num3;
        public Form2(string nome, string endereco, int conta, int agencia, int telefone, double saldo)
        {
            InitializeComponent();
            lblSaldo.Text = "Saldo R$ " + saldo;
            lblTexto.Text = nome + " Conta: " + conta + "-" + agencia;
            lbltele.Text = "Telefone do titular: " + telefone;
            lblEndereço.Text = "Endereço do titular: " + endereco;
            num2 = saldo;
        }

        metoto objCalcular = new metoto();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            num3 = objCalcular.deposito(num2, num1);
            lblSaldo.Text = "Saldo R$ " + num3;
            MessageBox.Show("deposito bem sucedido");
            num2 = num3;
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            double.TryParse(txtValor.Text, out num1);
            if (num2 > num1)
            {
                num3 = objCalcular.transferencia(num2, num1);
                lblSaldo.Text = "Saldo R$ " + num3;
                MessageBox.Show("Transferencia bem sucedido");
                num2 = num3;
            }
            else
            {
                MessageBox.Show("Saldo não suficente");
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double.TryParse(txtValor.Text, out num1);
            if (num2 > num1)
            {
                num3 = objCalcular.saque(num2, num1);
                lblSaldo.Text = "Saldo R$ " + num3;
                MessageBox.Show("Saque bem sucedida");
                num2 = num3;
            }
            else
            {
                MessageBox.Show("Saldo não suficente");
            }
            
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
         
        }
    }
}


namespace _3C1BERNARDO5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lbltele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(97, 171);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(85, 23);
            this.btnDeposito.TabIndex = 9;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(188, 171);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(91, 23);
            this.btnTransferencia.TabIndex = 8;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 145);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(263, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 7);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(30, 13);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "texto";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(16, 171);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 5;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(13, 103);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 13);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "lblSaldo";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "valor";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(13, 34);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(30, 13);
            this.lblEndereço.TabIndex = 12;
            this.lblEndereço.Text = "texto";
            // 
            // lbltele
            // 
            this.lbltele.AutoSize = true;
            this.lbltele.Location = new System.Drawing.Point(12, 64);
            this.lbltele.Name = "lbltele";
            this.lbltele.Size = new System.Drawing.Size(30, 13);
            this.lbltele.TabIndex = 13;
            this.lbltele.Text = "texto";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 207);
            this.Controls.Add(this.lbltele);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnSaque);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lbltele;
    }
}
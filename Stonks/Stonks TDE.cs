using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string genero;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStonks_Click(object sender, EventArgs e)
        {
            if(rdbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Feminino";
            }

            String mensagem = "";
            mensagem += "Nome: " + txtNome.Text + " " + txtSobrenome.Text + "\n";
            mensagem += "CPF:  " + txtCpf.Text + "\n";
            mensagem += "CEP:  " + txtCep.Text + "\n";
            mensagem += "Sexo: " + genero + "\n";
            mensagem += "Cidade:  " + txtCidade.Text + "\n";
            mensagem += "Bairro:  " + txtBairro.Text + "\n";
            mensagem += "Estado:  " + cmbEstado.Text + "\n";
            mensagem += "E-mail:  " + txtEmail.Text + "\n";
            MessageBox.Show(mensagem);
            MessageBox.Show("STONKS");

        }

        private void btnNotStonks_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtSobrenome.ResetText();
            txtEmail.ResetText();
            cmbEstado.SelectedIndex = -1;
            txtCpf.ResetText();
            txtCep.ResetText();
            txtCidade.ResetText();
            txtBairro.ResetText();

            MessageBox.Show("Formulário Resetado!!"+"\n");
            MessageBox.Show("NOT STONKS =(");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbdFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

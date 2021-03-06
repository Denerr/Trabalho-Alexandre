﻿using System;
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
            mensagem += "Data de Nascimento: " + mtbNascimento.Text + "\n";
            mensagem += "Telefone: " + txtTelefone.Text + "\n";
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
            mtbNascimento.ResetText();
            txtTelefone.ResetText();
            txtCidade.ResetText();
            txtBairro.ResetText();
            rdbMasculino.Checked = false;
            rbdFeminino.Checked = false;

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

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.MaxLength=(11);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }
        private void mtbNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

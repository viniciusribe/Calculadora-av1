using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_c
{
	public partial class Form1 : Form
	{
		bool cliquei_botoes_operacao = false;
		double num1 = 0;
		bool mostrar_calculo= false;
		double calculo=0;
		string qual_operacao = "";

		public void le_numero(int numero_lido)
		{
			if (cliquei_botoes_operacao == false)
				tb_numero.Text += numero_lido;
			else tb_numero.Text = numero_lido.ToString();

			cliquei_botoes_operacao = false;
		}

		public void botoes_operacao(string qual_operacao)
		{
		     cliquei_botoes_operacao= true;

			if (mostrar_calculo == true)
				calcular_e_mostrar();

			this.qual_operacao = qual_operacao;


			num1 = double.Parse(tb_numero.Text);
			mostrar_calculo = true;
			
		}
		public void calcular_e_mostrar()
		{
			if (qual_operacao == "+")
				calculo = num1 + double.Parse(tb_numero.Text);
			else if (qual_operacao == "*")
				calculo = num1 * double.Parse(tb_numero.Text);
			else if (qual_operacao == "/")
				calculo = num1 / double.Parse(tb_numero.Text);
			else if (qual_operacao == "-")
				calculo = num1 - double.Parse(tb_numero.Text);

			tb_numero.Text = calculo.ToString();
		
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button17_Click(object sender, EventArgs e)
		{
			le_numero(0);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			le_numero(1);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			le_numero(2);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			le_numero(3);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			le_numero(4);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			le_numero(5);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			le_numero(6);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			le_numero(7);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			le_numero(8);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			le_numero(9);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			botoes_operacao("/");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			botoes_operacao("*");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			botoes_operacao("-");
		}

		private void button18_Click(object sender, EventArgs e)
		{
			botoes_operacao("+");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int tamanho = tb_numero.Text.Length;
			if (tamanho > 0)
				tb_numero.Text = tb_numero.Text.Substring(0, tamanho - 1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb_numero.Text = "";
		}

		private void button14_Click(object sender, EventArgs e)
		{
			tb_numero.Text += ",";

		}

		private void button11_Click(object sender, EventArgs e)
		{
			calcular_e_mostrar();
			mostrar_calculo = false;
		}

		private void tb_numero_TextChanged(object sender, EventArgs e)
		{

		}
	}
}


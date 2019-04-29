using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtX.Clear();
            txtY.Clear();
            txtX.Focus();

            rdbSomar.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, total;

            if (double.TryParse(txtX.Text, out x) == false)
            {

                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtX.Clear(); // limpa o texto do TextBox
                txtX.Focus(); //coloca o foco do cursor no TextBox
                return; //sai da sub-rotina, não executa o código que está abaixo
            }


            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtY.Clear(); // limpa o texto do TextBox
                txtY.Focus(); //coloca o foco do cursor no TextBox
                return; //sai da sub-rotina, não executa o código que está abaixo
            }

            if (rdbSomar.Checked == true)
            {
                total = x + y;
            }

            else if (rdbSubtrair.Checked)
            {
                total = x - y;
            }
            else if (rdbMultiplicar.Checked)
            {
                total = x * y;
            }
            else
            {
                //verifica se está sendo realizada divisão por zero
                if (y == 0)
                {
                    txtTotal.Text = "Divisão por zero";
                    return; //sai da sub-rotina, não executa o código que está abaixo
                }

                total = x / y;
            }

            //apresenta a saída de dados convertendo para String

            txtTotal.Text = total.ToString();
        }
    }
}

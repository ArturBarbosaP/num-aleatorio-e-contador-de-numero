using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int cont = 1, contIdade = 0, idade = aleatorio.Next(1, 20);

            ltx_imprimir.Items.Clear();

            while (cont <=15)
            {
                if (idade == 18)
                {
                    contIdade++;
                }
                ltx_imprimir.Items.Add(cont + " - " +  idade);
                idade = aleatorio.Next(1, 20);
                cont ++;
            }
            ltx_imprimir.Items.Add("Quantidade de pessoas com a idade igual a 18: " + contIdade);
        }
    }
}

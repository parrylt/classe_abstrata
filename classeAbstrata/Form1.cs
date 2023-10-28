using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classeAbstrata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //referenciando e criando as classes no form principal
            Programador p1 = new Programador();
            Designer d1 = new Designer();
            DesenvolvedorWeb dw = new DesenvolvedorWeb();

            // variáveis
            decimal salario;
            string nome;

            salario = Convert.ToDecimal(txtSalario.Text);
            nome = txtNome.Text;

            //clausulas if else
            if (btnDesigner.Checked)
            {
                // se o botão estiver selecionado, d1 que referencia a classe designer usa o Reajustar() que adiciona 500 ao salário que é pego através do salario = Convert.ToDecimal(txtSalario.Text);
                d1.Nome = nome;
                d1.Salario = salario;
                d1.Reajustar();
                lblResult.Text = d1.Salario.ToString();
            }
            if (btnProgramador.Checked)
            {
                //mesma coisa só que com a classe programador
                p1.Nome = nome;
                p1.Salario = salario;
                p1.Reajustar();
                lblResult.Text = p1.Salario.ToString();
            }
            if (btnDWeb.Checked)
            {
                //mesma coisa só que com a classe desenvolvedor web
                dw.Nome = nome;
                dw.Salario = salario;
                dw.Reajustar();
                lblResult.Text = dw.Salario.ToString();
            }
        }
    }
}

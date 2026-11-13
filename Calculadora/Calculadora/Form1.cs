using System.Runtime.Intrinsics.X86;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num = 0;
        double aux = 0;
        char sig;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool OperarInternamente()
        {
            num = double.Parse(tbxnum.Text);

            switch (sig)
            {
                case '+':
                    aux = aux + num;
                    break;

                case '-':
                    aux = aux - num;
                    break;

                case '*':
                    aux = aux * num;
                    break;

                case '/':
                    if (Alertas() == false) return false;
                    break;

                default:
                    aux = num;
                    break;
            }
            return true;
        }

        private bool Alertas()
        {
            if (sig == '/')
            {
                if (num == 0)
                {
                    sig = '\0';
                    tbxnum.Text = "Error";
                    tbxval.Clear();
                    aux = 0;
                    num = 0;
                    return false;
                }
                else
                {
                    aux = aux / num;
                }
            }
            return true;
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text != "")
            {
                if (!OperarInternamente()) return;

                sig = '+';
                tbxval.Text += "+";
                tbxnum.Clear();
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text != "")
            {
                if (!OperarInternamente()) return;

                sig = '-';
                tbxval.Text += "-";
                tbxnum.Clear();
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text != "")
            {
                if (!OperarInternamente()) return;

                sig = '*';
                tbxval.Text += "*";
                tbxnum.Clear();
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text != "")
            {
                if (!OperarInternamente()) return;

                sig = '/';
                tbxval.Text += "/";
                tbxnum.Clear();
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text != "")
            {
                // Si hubo error de división, el return frena al botón igual
                if (!OperarInternamente()) return;

                tbxnum.Text = aux.ToString();
                tbxval.Clear();
                tbxval.Text = aux.ToString();

                sig = '\0';
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            tbxnum.Clear();
            tbxval.Clear();
            aux = 0;
            num = 0;
            sig = '\0';
        }

        private void tbnum_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn1.Text;
            tbxval.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn2.Text;
            tbxval.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn3.Text;
            tbxval.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn4.Text;
            tbxval.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn5.Text;
            tbxval.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn6.Text;
            tbxval.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn7.Text;
            tbxval.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn8.Text;
            tbxval.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn9.Text;
            tbxval.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxnum.Text += btn0.Text;
            tbxval.Text += btn0.Text;
        }

    }
}
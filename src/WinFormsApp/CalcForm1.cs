

namespace WinFormsApp
{
    public partial class CalculadoraForm : Form
    {
        public int mempos=0;
        public string opanterior = "";
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text+"7";
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "8";

        }

        private void numero9_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "9";

        }

        private void numero4_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "4";

        }

        private void numero5_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "5";

        }

        private void numero6_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "6";

        }

        private void numero1_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "1";

        }

        private void numero2_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "2";

        }

        private void numero3_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "3";

        }

        private void numero0_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "0") this.label1.Text = "";
            this.label1.Text = this.label1.Text + "0";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            c.Memoria1 = 0;
            c.Memoria2 = 0;
            c.Operacao = "";
            mempos = 0;
            BloqTeclas(true);

        }

        private void soma_Click(object sender, EventArgs e)
        {
            c.Operacao = "+";
            Realiza(c.Operacao);
        }

        private void subtrai_Click(object sender, EventArgs e)
        {
            c.Operacao = "-";
            Realiza(c.Operacao);
        }
        private void multiplica_Click(object sender, EventArgs e)
        {
            c.Operacao = "*";
            Realiza(c.Operacao);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            c.Operacao = "/";
            c.Memoria2 = float.Parse(this.label1.Text);
            if (c.Memoria2 == 0 && opanterior=="/")
            { 
                ErroOp(1); 
            }
            else 
            { 
                Realiza(c.Operacao); 
            }
        }
        public void BloqTeclas(bool status)
        {
            this.numero0.Enabled = status;
            this.numero1.Enabled = status;
            this.numero2.Enabled = status;
            this.numero3.Enabled = status;
            this.numero4.Enabled = status;
            this.numero5.Enabled = status;
            this.numero6.Enabled = status;
            this.numero7.Enabled = status;
            this.numero8.Enabled = status;
            this.numero9.Enabled = status;
            this.soma.Enabled = status;
            this.subtrai.Enabled = status;
            this.multiplica.Enabled = status;
            this.divide.Enabled = status;
            this.igual.Enabled = status;
        }
        public void ErroOp(int erro)
        {
            switch ( erro)
            {
                case 1:
                    this.label1.Text = "Impossível dividir por zero";
                    BloqTeclas(false);
                    break;
                case 2:
                    this.label1.Text = "Não foi possível calcular. Erro overflow";
                    BloqTeclas(false);
                    break;
                case 3:
                    this.label1.Text = "Não foi possível calcular. Erro underflow";
                    BloqTeclas(false);
                    break;
            }
        }
        private void igual_Click(object sender, EventArgs e)
        {
            c.Memoria2 = float.Parse(this.label1.Text);
            if (c.Memoria2 == 0 && opanterior == "/")
            {
                ErroOp(1);
            }
            else
            {
                this.label1.Text = c.Resultado(opanterior);
                if (this.label1.Text == "overflow")
                {
                    ErroOp(2);
                }
                else if (this.label1.Text == "underflow")
                {
                    ErroOp(3);
                }
                else
                { 
                    c.Memoria1 = float.Parse(this.label1.Text);
                    c.Memoria2 = 0;
                    opanterior = "";
                }
            }
        }
        public void Realiza(string op)
        {
            if (mempos == 0)
            {
                c.Memoria1 = float.Parse(this.label1.Text);
                this.label1.Text = "0";
                mempos = 1;
                opanterior = op;
            }
            else
            {
                if (opanterior != "")
                {
                    c.Memoria2 = float.Parse(this.label1.Text);
                    this.label1.Text = c.Resultado(opanterior);
                    if (this.label1.Text == "erro2")
                    {
                        ErroOp(2);
                    }
                    else if(this.label1.Text == "erro3")
                    {
                        ErroOp(2);
                    }
                    else
                    {
                        c.Memoria1 = float.Parse(c.Resultado(opanterior));
                        this.label1.Text = "0";
                        opanterior = op;
                    }
                }
                else
                {
                    this.label1.Text = "0";
                    opanterior = c.Operacao;
                }

            }

        }

    }
}
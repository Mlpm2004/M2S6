using ClassesLibrary;

namespace WinFormsApp
{
    public partial class CalculadoraForm : Form
    {
        private Button numero7;
        private Button numero8;
        private Button numero9;
        private Button soma;
        private Button subtrai;
        private Button numero6;
        private Button numero5;
        private Button numero4;
        private Button divide;
        private Button igual;
        private Button numero0;
        private Button clear;
        private Button multiplica;
        private Button numero3;
        private Button numero2;
        private Button numero1;
        private Label label1;
        Calculadora c = new();

        /*       public CalculadoraForm()
               {
                   InitializeComponent();
               }
       */

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numero7 = new System.Windows.Forms.Button();
            this.numero8 = new System.Windows.Forms.Button();
            this.numero9 = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.subtrai = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.numero0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numero7
            // 
            this.numero7.BackColor = System.Drawing.Color.Azure;
            this.numero7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero7.Location = new System.Drawing.Point(51, 172);
            this.numero7.Name = "numero7";
            this.numero7.Size = new System.Drawing.Size(55, 42);
            this.numero7.TabIndex = 1;
            this.numero7.Text = "7";
            this.numero7.UseVisualStyleBackColor = false;
            this.numero7.Click += new System.EventHandler(this.numero7_Click);
            // 
            // numero8
            // 
            this.numero8.BackColor = System.Drawing.Color.Azure;
            this.numero8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero8.Location = new System.Drawing.Point(146, 172);
            this.numero8.Name = "numero8";
            this.numero8.Size = new System.Drawing.Size(55, 42);
            this.numero8.TabIndex = 2;
            this.numero8.Text = "8";
            this.numero8.UseVisualStyleBackColor = false;
            this.numero8.Click += new System.EventHandler(this.numero8_Click);
            // 
            // numero9
            // 
            this.numero9.BackColor = System.Drawing.Color.Azure;
            this.numero9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero9.Location = new System.Drawing.Point(238, 172);
            this.numero9.Name = "numero9";
            this.numero9.Size = new System.Drawing.Size(55, 42);
            this.numero9.TabIndex = 3;
            this.numero9.Text = "9";
            this.numero9.UseVisualStyleBackColor = false;
            this.numero9.Click += new System.EventHandler(this.numero9_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.soma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soma.Location = new System.Drawing.Point(329, 172);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(55, 42);
            this.soma.TabIndex = 4;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtrai
            // 
            this.subtrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subtrai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtrai.Location = new System.Drawing.Point(329, 248);
            this.subtrai.Name = "subtrai";
            this.subtrai.Size = new System.Drawing.Size(55, 42);
            this.subtrai.TabIndex = 8;
            this.subtrai.Text = "-";
            this.subtrai.UseVisualStyleBackColor = false;
            this.subtrai.Click += new System.EventHandler(this.subtrai_Click);
            // 
            // numero6
            // 
            this.numero6.BackColor = System.Drawing.Color.Azure;
            this.numero6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero6.Location = new System.Drawing.Point(238, 248);
            this.numero6.Name = "numero6";
            this.numero6.Size = new System.Drawing.Size(55, 42);
            this.numero6.TabIndex = 7;
            this.numero6.Text = "6";
            this.numero6.UseVisualStyleBackColor = false;
            this.numero6.Click += new System.EventHandler(this.numero6_Click);
            // 
            // numero5
            // 
            this.numero5.BackColor = System.Drawing.Color.Azure;
            this.numero5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero5.Location = new System.Drawing.Point(146, 248);
            this.numero5.Name = "numero5";
            this.numero5.Size = new System.Drawing.Size(55, 42);
            this.numero5.TabIndex = 6;
            this.numero5.Text = "5";
            this.numero5.UseVisualStyleBackColor = false;
            this.numero5.Click += new System.EventHandler(this.numero5_Click);
            // 
            // numero4
            // 
            this.numero4.BackColor = System.Drawing.Color.Azure;
            this.numero4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero4.Location = new System.Drawing.Point(51, 248);
            this.numero4.Name = "numero4";
            this.numero4.Size = new System.Drawing.Size(55, 42);
            this.numero4.TabIndex = 5;
            this.numero4.Text = "4";
            this.numero4.UseVisualStyleBackColor = false;
            this.numero4.Click += new System.EventHandler(this.numero4_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.divide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(329, 401);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(55, 42);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.Red;
            this.igual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.igual.Location = new System.Drawing.Point(238, 401);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(55, 42);
            this.igual.TabIndex = 15;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // numero0
            // 
            this.numero0.BackColor = System.Drawing.Color.Azure;
            this.numero0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero0.Location = new System.Drawing.Point(146, 401);
            this.numero0.Name = "numero0";
            this.numero0.Size = new System.Drawing.Size(55, 42);
            this.numero0.TabIndex = 14;
            this.numero0.Text = "0";
            this.numero0.UseVisualStyleBackColor = false;
            this.numero0.Click += new System.EventHandler(this.numero0_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(51, 401);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(55, 42);
            this.clear.TabIndex = 13;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // multiplica
            // 
            this.multiplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.multiplica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplica.Location = new System.Drawing.Point(329, 325);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(55, 42);
            this.multiplica.TabIndex = 12;
            this.multiplica.Text = "*";
            this.multiplica.UseVisualStyleBackColor = false;
            this.multiplica.Click += new System.EventHandler(this.multiplica_Click);
            // 
            // numero3
            // 
            this.numero3.BackColor = System.Drawing.Color.Azure;
            this.numero3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero3.Location = new System.Drawing.Point(238, 325);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(55, 42);
            this.numero3.TabIndex = 11;
            this.numero3.Text = "3";
            this.numero3.UseVisualStyleBackColor = false;
            this.numero3.Click += new System.EventHandler(this.numero3_Click);
            // 
            // numero2
            // 
            this.numero2.BackColor = System.Drawing.Color.Azure;
            this.numero2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero2.Location = new System.Drawing.Point(146, 325);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(55, 42);
            this.numero2.TabIndex = 10;
            this.numero2.Text = "2";
            this.numero2.UseVisualStyleBackColor = false;
            this.numero2.Click += new System.EventHandler(this.numero2_Click);
            // 
            // numero1
            // 
            this.numero1.BackColor = System.Drawing.Color.Azure;
            this.numero1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero1.Location = new System.Drawing.Point(51, 325);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(55, 42);
            this.numero1.TabIndex = 9;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = false;
            this.numero1.Click += new System.EventHandler(this.numero1_Click);
            // 
            // CalculadoraForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(437, 501);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multiplica);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.subtrai);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.numero9);
            this.Controls.Add(this.numero8);
            this.Controls.Add(this.numero7);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(455, 548);
            this.MinimumSize = new System.Drawing.Size(455, 548);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora";
            this.ResumeLayout(false);

        }
    }
}
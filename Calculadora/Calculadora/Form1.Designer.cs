namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnsuma = new Button();
            tbxnum = new TextBox();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btnigual = new Button();
            btnresta = new Button();
            btnmul = new Button();
            btndiv = new Button();
            btnC = new Button();
            tbxval = new TextBox();
            SuspendLayout();
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.Thistle;
            btnsuma.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsuma.Location = new Point(330, 138);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(67, 69);
            btnsuma.TabIndex = 3;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // tbxnum
            // 
            tbxnum.BackColor = Color.Thistle;
            tbxnum.BorderStyle = BorderStyle.None;
            tbxnum.Font = new Font("Segoe UI", 20F);
            tbxnum.Location = new Point(77, 69);
            tbxnum.Multiline = true;
            tbxnum.Name = "tbxnum";
            tbxnum.ReadOnly = true;
            tbxnum.Size = new Size(320, 49);
            tbxnum.TabIndex = 5;
            tbxnum.TextAlign = HorizontalAlignment.Right;
            tbxnum.TextChanged += tbnum_TextChanged;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightCyan;
            btn1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ControlText;
            btn1.Location = new Point(77, 138);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 69);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightCyan;
            btn4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(77, 228);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 69);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightCyan;
            btn2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(161, 138);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 69);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightCyan;
            btn5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(161, 228);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 69);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightCyan;
            btn3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(245, 138);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 69);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightCyan;
            btn9.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(245, 314);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 69);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightCyan;
            btn8.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(161, 314);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 69);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightCyan;
            btn7.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(77, 314);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 69);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightCyan;
            btn6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(245, 228);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 69);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightCyan;
            btn0.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(161, 398);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 69);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnigual
            // 
            btnigual.BackColor = Color.Thistle;
            btnigual.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnigual.Location = new Point(245, 398);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(67, 69);
            btnigual.TabIndex = 16;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = false;
            btnigual.Click += btnigual_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.Thistle;
            btnresta.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnresta.Location = new Point(330, 228);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(67, 69);
            btnresta.TabIndex = 17;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnmul
            // 
            btnmul.BackColor = Color.Thistle;
            btnmul.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmul.Location = new Point(330, 314);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(67, 69);
            btnmul.TabIndex = 18;
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = false;
            btnmul.Click += btnmul_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.Thistle;
            btndiv.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndiv.Location = new Point(330, 398);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(67, 69);
            btndiv.TabIndex = 19;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Thistle;
            btnC.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.Location = new Point(77, 398);
            btnC.Name = "btnC";
            btnC.Size = new Size(67, 69);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnAC_Click;
            // 
            // tbxval
            // 
            tbxval.BackColor = Color.Thistle;
            tbxval.BorderStyle = BorderStyle.None;
            tbxval.Font = new Font("Segoe UI", 15F);
            tbxval.Location = new Point(77, 31);
            tbxval.Multiline = true;
            tbxval.Name = "tbxval";
            tbxval.ReadOnly = true;
            tbxval.Size = new Size(320, 45);
            tbxval.TabIndex = 21;
            tbxval.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(469, 542);
            Controls.Add(tbxval);
            Controls.Add(btnC);
            Controls.Add(btndiv);
            Controls.Add(btnmul);
            Controls.Add(btnresta);
            Controls.Add(btnigual);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(tbxnum);
            Controls.Add(btnsuma);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnigual;
        private Button btnsuma;
        private Button btnresta;
        private TextBox tbxnum;
        private Button btn1;
        private Button btn4;
        private Button btn2;
        private Button btn5;
        private Button btn3;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn0;
        private Button btnmul;
        private Button btndiv;
        private Button btnC;
        private TextBox tbxval;
    }
}

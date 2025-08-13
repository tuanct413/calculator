namespace calculator
{
    partial class Calculator_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator_App));
            PnlTitile = new Panel();
            btnthunho = new Button();
            btnanapp = new Button();
            btnthoat = new Button();
            textboxhienthi1 = new TextBox();
            textboxhienthi2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            number0 = new Button();
            button11 = new Button();
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number4 = new Button();
            number7 = new Button();
            number8 = new Button();
            number5 = new Button();
            number9 = new Button();
            number6 = new Button();
            PnlTitile.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitile
            // 
            PnlTitile.Controls.Add(btnthunho);
            PnlTitile.Controls.Add(btnanapp);
            PnlTitile.Controls.Add(btnthoat);
            PnlTitile.Dock = DockStyle.Top;
            PnlTitile.Location = new Point(0, 0);
            PnlTitile.Name = "PnlTitile";
            PnlTitile.Size = new Size(321, 47);
            PnlTitile.TabIndex = 0;
            PnlTitile.Paint += PnlTitile_Paint;
            // 
            // btnthunho
            // 
            btnthunho.AllowDrop = true;
            btnthunho.Dock = DockStyle.Right;
            btnthunho.FlatAppearance.BorderSize = 0;
            btnthunho.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnthunho.FlatStyle = FlatStyle.Flat;
            btnthunho.ForeColor = Color.White;
            btnthunho.Image = (Image)resources.GetObject("btnthunho.Image");
            btnthunho.Location = new Point(186, 0);
            btnthunho.Margin = new Padding(0);
            btnthunho.Name = "btnthunho";
            btnthunho.Size = new Size(45, 47);
            btnthunho.TabIndex = 3;
            btnthunho.UseVisualStyleBackColor = true;
            btnthunho.Click += btnthunho_Click;
            // 
            // btnanapp
            // 
            btnanapp.AllowDrop = true;
            btnanapp.Dock = DockStyle.Right;
            btnanapp.FlatAppearance.BorderSize = 0;
            btnanapp.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnanapp.FlatStyle = FlatStyle.Flat;
            btnanapp.ForeColor = Color.White;
            btnanapp.Image = (Image)resources.GetObject("btnanapp.Image");
            btnanapp.Location = new Point(231, 0);
            btnanapp.Margin = new Padding(0);
            btnanapp.Name = "btnanapp";
            btnanapp.Size = new Size(45, 47);
            btnanapp.TabIndex = 3;
            btnanapp.UseVisualStyleBackColor = true;
            btnanapp.SizeChanged += btnanapp_SizeChanged;
            btnanapp.Click += btnanapp_Click;
            // 
            // btnthoat
            // 
            btnthoat.AllowDrop = true;
            btnthoat.Dock = DockStyle.Right;
            btnthoat.FlatAppearance.BorderSize = 0;
            btnthoat.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnthoat.FlatStyle = FlatStyle.Flat;
            btnthoat.ForeColor = Color.White;
            btnthoat.Image = (Image)resources.GetObject("btnthoat.Image");
            btnthoat.Location = new Point(276, 0);
            btnthoat.Margin = new Padding(0);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(45, 47);
            btnthoat.TabIndex = 2;
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // textboxhienthi1
            // 
            textboxhienthi1.BackColor = Color.FromArgb(32, 32, 32);
            textboxhienthi1.BorderStyle = BorderStyle.None;
            textboxhienthi1.Dock = DockStyle.Top;
            textboxhienthi1.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxhienthi1.Location = new Point(0, 47);
            textboxhienthi1.Margin = new Padding(0);
            textboxhienthi1.Multiline = true;
            textboxhienthi1.Name = "textboxhienthi1";
            textboxhienthi1.Size = new Size(321, 37);
            textboxhienthi1.TabIndex = 2;
            textboxhienthi1.Text = "0";
            textboxhienthi1.TextAlign = HorizontalAlignment.Right;
            // 
            // textboxhienthi2
            // 
            textboxhienthi2.BackColor = Color.FromArgb(32, 32, 32);
            textboxhienthi2.BorderStyle = BorderStyle.None;
            textboxhienthi2.Dock = DockStyle.Top;
            textboxhienthi2.Location = new Point(0, 84);
            textboxhienthi2.Margin = new Padding(0);
            textboxhienthi2.Multiline = true;
            textboxhienthi2.Name = "textboxhienthi2";
            textboxhienthi2.Size = new Size(321, 73);
            textboxhienthi2.TabIndex = 3;
            textboxhienthi2.Text = "0";
            textboxhienthi2.TextAlign = HorizontalAlignment.Right;
            textboxhienthi2.TextChanged += textboxhienthi2_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(234, 331);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(78, 55);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += math;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gray;
            button2.Location = new Point(234, 221);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(78, 55);
            button2.TabIndex = 5;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = true;
            button2.Click += math;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gray;
            button3.Location = new Point(234, 276);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(78, 55);
            button3.TabIndex = 6;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += math;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Gray;
            button4.Location = new Point(234, 386);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(78, 55);
            button4.TabIndex = 7;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += math;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Gray;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(234, 166);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(78, 55);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Gray;
            button6.Location = new Point(156, 169);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(78, 55);
            button6.TabIndex = 9;
            button6.Text = "C";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Gray;
            button7.Location = new Point(78, 169);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(78, 55);
            button7.TabIndex = 10;
            button7.Text = "CE";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Gray;
            button8.Location = new Point(0, 169);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(78, 55);
            button8.TabIndex = 11;
            button8.Text = "%";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.White;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Gray;
            button9.Location = new Point(156, 386);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(78, 55);
            button9.TabIndex = 12;
            button9.Text = ".";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Btnnumberclick;
            // 
            // number0
            // 
            number0.FlatAppearance.BorderSize = 0;
            number0.FlatAppearance.MouseDownBackColor = Color.White;
            number0.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number0.FlatStyle = FlatStyle.Flat;
            number0.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number0.ForeColor = Color.Gray;
            number0.Location = new Point(78, 389);
            number0.Margin = new Padding(0);
            number0.Name = "number0";
            number0.Size = new Size(78, 55);
            number0.TabIndex = 13;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = true;
            number0.Click += Btnnumberclick;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseDownBackColor = Color.White;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Gray;
            button11.Location = new Point(0, 389);
            button11.Margin = new Padding(0);
            button11.Name = "button11";
            button11.Size = new Size(78, 55);
            button11.TabIndex = 14;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // number1
            // 
            number1.FlatAppearance.BorderSize = 0;
            number1.FlatAppearance.MouseDownBackColor = Color.White;
            number1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number1.FlatStyle = FlatStyle.Flat;
            number1.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number1.ForeColor = Color.Gray;
            number1.Location = new Point(0, 334);
            number1.Margin = new Padding(0);
            number1.Name = "number1";
            number1.Size = new Size(78, 55);
            number1.TabIndex = 15;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += Btnnumberclick;
            // 
            // number2
            // 
            number2.FlatAppearance.BorderSize = 0;
            number2.FlatAppearance.MouseDownBackColor = Color.White;
            number2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number2.FlatStyle = FlatStyle.Flat;
            number2.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number2.ForeColor = Color.Gray;
            number2.Location = new Point(78, 334);
            number2.Margin = new Padding(0);
            number2.Name = "number2";
            number2.Size = new Size(78, 55);
            number2.TabIndex = 16;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += Btnnumberclick;
            // 
            // number3
            // 
            number3.FlatAppearance.BorderSize = 0;
            number3.FlatAppearance.MouseDownBackColor = Color.White;
            number3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number3.FlatStyle = FlatStyle.Flat;
            number3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number3.ForeColor = Color.Gray;
            number3.Location = new Point(153, 334);
            number3.Margin = new Padding(0);
            number3.Name = "number3";
            number3.Size = new Size(78, 55);
            number3.TabIndex = 17;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += Btnnumberclick;
            // 
            // number4
            // 
            number4.FlatAppearance.BorderSize = 0;
            number4.FlatAppearance.MouseDownBackColor = Color.White;
            number4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number4.FlatStyle = FlatStyle.Flat;
            number4.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number4.ForeColor = Color.Gray;
            number4.Location = new Point(0, 279);
            number4.Margin = new Padding(0);
            number4.Name = "number4";
            number4.Size = new Size(78, 55);
            number4.TabIndex = 18;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += Btnnumberclick;
            // 
            // number7
            // 
            number7.FlatAppearance.BorderSize = 0;
            number7.FlatAppearance.MouseDownBackColor = Color.White;
            number7.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number7.FlatStyle = FlatStyle.Flat;
            number7.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number7.ForeColor = Color.Gray;
            number7.Location = new Point(0, 221);
            number7.Margin = new Padding(0);
            number7.Name = "number7";
            number7.Size = new Size(78, 55);
            number7.TabIndex = 19;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += Btnnumberclick;
            // 
            // number8
            // 
            number8.FlatAppearance.BorderSize = 0;
            number8.FlatAppearance.MouseDownBackColor = Color.White;
            number8.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number8.FlatStyle = FlatStyle.Flat;
            number8.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number8.ForeColor = Color.Gray;
            number8.Location = new Point(78, 224);
            number8.Margin = new Padding(0);
            number8.Name = "number8";
            number8.Size = new Size(78, 55);
            number8.TabIndex = 20;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += Btnnumberclick;
            // 
            // number5
            // 
            number5.FlatAppearance.BorderSize = 0;
            number5.FlatAppearance.MouseDownBackColor = Color.White;
            number5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number5.FlatStyle = FlatStyle.Flat;
            number5.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number5.ForeColor = Color.Gray;
            number5.Location = new Point(78, 279);
            number5.Margin = new Padding(0);
            number5.Name = "number5";
            number5.Size = new Size(78, 55);
            number5.TabIndex = 21;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += Btnnumberclick;
            // 
            // number9
            // 
            number9.FlatAppearance.BorderSize = 0;
            number9.FlatAppearance.MouseDownBackColor = Color.White;
            number9.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number9.FlatStyle = FlatStyle.Flat;
            number9.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number9.ForeColor = Color.Gray;
            number9.Location = new Point(156, 221);
            number9.Margin = new Padding(0);
            number9.Name = "number9";
            number9.Size = new Size(78, 55);
            number9.TabIndex = 22;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += Btnnumberclick;
            // 
            // number6
            // 
            number6.FlatAppearance.BorderSize = 0;
            number6.FlatAppearance.MouseDownBackColor = Color.White;
            number6.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            number6.FlatStyle = FlatStyle.Flat;
            number6.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number6.ForeColor = Color.Gray;
            number6.Location = new Point(156, 276);
            number6.Margin = new Padding(0);
            number6.Name = "number6";
            number6.Size = new Size(78, 55);
            number6.TabIndex = 23;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += Btnnumberclick;
            // 
            // Calculator_App
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(321, 461);
            Controls.Add(number6);
            Controls.Add(number9);
            Controls.Add(number5);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(button11);
            Controls.Add(number0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textboxhienthi2);
            Controls.Add(textboxhienthi1);
            Controls.Add(PnlTitile);
            Font = new Font("Gadugi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator_App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            Load += Calculator_App_Load;
            PnlTitile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitile;
        private Button btnthoat;
        private Button btnanapp;
        private Button btnthunho;
        private TextBox textboxhienthi1;
        private TextBox textboxhienthi2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button number0;
        private Button button11;
        private Button number1;
        private Button number2;
        private Button number3;
        private Button number4;
        private Button number7;
        private Button number8;
        private Button number5;
        private Button number9;
        private Button number6;
    }
}

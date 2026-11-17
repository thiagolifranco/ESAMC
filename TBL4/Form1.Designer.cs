namespace TBL4
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
            panel1 = new Panel();
            label1 = new Label();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            button1 = new Button();
            panel2 = new Panel();
            btnRelatorios = new Button();
            btnFornecedores = new Button();
            btnProdutos = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("RomanS_IV25", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 1;
            label1.Text = "Meu Sistema";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatAppearance.BorderColor = Color.White;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(670, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(65, 23);
            btnRestaurar.TabIndex = 3;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderColor = Color.White;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(670, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(65, 23);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(735, 3);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnRelatorios);
            panel2.Controls.Add(btnFornecedores);
            panel2.Controls.Add(btnProdutos);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 350);
            panel2.TabIndex = 1;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderColor = Color.White;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.White;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(3, 32);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(113, 23);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.FlatAppearance.BorderColor = Color.White;
            btnFornecedores.FlatAppearance.BorderSize = 0;
            btnFornecedores.FlatAppearance.MouseDownBackColor = Color.White;
            btnFornecedores.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnFornecedores.FlatStyle = FlatStyle.Flat;
            btnFornecedores.Image = (Image)resources.GetObject("btnFornecedores.Image");
            btnFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.Location = new Point(3, 61);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(113, 23);
            btnFornecedores.TabIndex = 4;
            btnFornecedores.Text = "Fornecedores";
            btnFornecedores.UseVisualStyleBackColor = true;
            btnFornecedores.Click += btnFornecedores_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.FlatAppearance.BorderColor = Color.White;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseDownBackColor = Color.White;
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Image = (Image)resources.GetObject("btnRelatorios.Image");
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(3, 90);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(113, 23);
            btnRelatorios.TabIndex = 5;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 2;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button btnProdutos;
        private Button btnFornecedores;
        private Button btnRelatorios;
    }
}

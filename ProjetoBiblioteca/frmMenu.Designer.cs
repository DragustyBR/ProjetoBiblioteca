namespace ProjetoBiblioteca
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnCadLogin = new System.Windows.Forms.Button();
            this.btnLeitores = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDevolucao);
            this.panel1.Controls.Add(this.btnEmprestimo);
            this.panel1.Controls.Add(this.btnCadLogin);
            this.panel1.Controls.Add(this.btnLeitores);
            this.panel1.Controls.Add(this.btnLivros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 410);
            this.panel1.TabIndex = 0;
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolucao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevolucao.FlatAppearance.BorderSize = 0;
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucao.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnDevolucao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucao.Location = new System.Drawing.Point(12, 328);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(195, 70);
            this.btnDevolucao.TabIndex = 5;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolucao.UseVisualStyleBackColor = false;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 257);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(209, 65);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.Text = "Empréstimo ";
            this.btnEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            // 
            // btnCadLogin
            // 
            this.btnCadLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCadLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadLogin.FlatAppearance.BorderSize = 0;
            this.btnCadLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLogin.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLogin.Image = global::ProjetoBiblioteca.Properties.Resources.login_ico;
            this.btnCadLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadLogin.Location = new System.Drawing.Point(12, 193);
            this.btnCadLogin.Name = "btnCadLogin";
            this.btnCadLogin.Size = new System.Drawing.Size(195, 58);
            this.btnCadLogin.TabIndex = 3;
            this.btnCadLogin.Text = "Login";
            this.btnCadLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadLogin.UseVisualStyleBackColor = false;
            // 
            // btnLeitores
            // 
            this.btnLeitores.BackColor = System.Drawing.Color.Transparent;
            this.btnLeitores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLeitores.FlatAppearance.BorderSize = 0;
            this.btnLeitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitores.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitores.Image = global::ProjetoBiblioteca.Properties.Resources.girl_reading_a_book_for_class;
            this.btnLeitores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeitores.Location = new System.Drawing.Point(12, 117);
            this.btnLeitores.Name = "btnLeitores";
            this.btnLeitores.Size = new System.Drawing.Size(195, 70);
            this.btnLeitores.TabIndex = 2;
            this.btnLeitores.Text = "Leitores";
            this.btnLeitores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeitores.UseVisualStyleBackColor = false;
            this.btnLeitores.Click += new System.EventHandler(this.btnLeitores_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(12, 41);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(195, 70);
            this.btnLivros.TabIndex = 1;
            this.btnLivros.Text = "Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoBiblioteca.Properties.Resources.cancel;
            this.btnSair.Location = new System.Drawing.Point(464, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(34, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(760, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnLeitores;
        private System.Windows.Forms.Button btnLivros;
        public System.Windows.Forms.Button btnCadLogin;
    }
}
namespace ProjetoBiblioteca
{
    partial class frmPesquisaLivros
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLivros = new System.Windows.Forms.TextBox();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOMBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXEMPLAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO_LANCAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_BARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 72);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Magenta;
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 71);
            this.panel3.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::ProjetoBiblioteca.Properties.Resources.magnifier;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(14, 12);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(170, 51);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoBiblioteca.Properties.Resources.shut_down_icon;
            this.btnSair.Location = new System.Drawing.Point(832, 12);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.TOMBO,
            this.TITULO,
            this.AUTOR,
            this.DATA_CADASTRO,
            this.EDITORA,
            this.EXEMPLAR,
            this.ANO_LANCAMENTO,
            this.COD_BARRAS});
            this.dgvLivros.Location = new System.Drawing.Point(0, 169);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(933, 281);
            this.dgvLivros.TabIndex = 9;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite o nome do Livro:";
            // 
            // txtLivros
            // 
            this.txtLivros.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivros.Location = new System.Drawing.Point(250, 110);
            this.txtLivros.Name = "txtLivros";
            this.txtLivros.Size = new System.Drawing.Size(514, 24);
            this.txtLivros.TabIndex = 10;
            this.txtLivros.TextChanged += new System.EventHandler(this.txtLivro_TextChanged);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // TOMBO
            // 
            this.TOMBO.DataPropertyName = "TOMBO";
            this.TOMBO.HeaderText = "TOMBO";
            this.TOMBO.Name = "TOMBO";
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            // 
            // AUTOR
            // 
            this.AUTOR.DataPropertyName = "AUTOR";
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.DataPropertyName = "DATA_CADASTRO";
            this.DATA_CADASTRO.HeaderText = "DATA DE CADASTRO";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            // 
            // EDITORA
            // 
            this.EDITORA.DataPropertyName = "EDITORA";
            this.EDITORA.HeaderText = "EDITORA";
            this.EDITORA.Name = "EDITORA";
            // 
            // EXEMPLAR
            // 
            this.EXEMPLAR.DataPropertyName = "EXEMPLAR";
            this.EXEMPLAR.HeaderText = "EXEMPLAR";
            this.EXEMPLAR.Name = "EXEMPLAR";
            // 
            // ANO_LANCAMENTO
            // 
            this.ANO_LANCAMENTO.DataPropertyName = "ANO_LANCAMENTO";
            this.ANO_LANCAMENTO.HeaderText = "ANO DE LANÇAMENTO";
            this.ANO_LANCAMENTO.Name = "ANO_LANCAMENTO";
            // 
            // COD_BARRAS
            // 
            this.COD_BARRAS.DataPropertyName = "COD_BARRAS";
            this.COD_BARRAS.HeaderText = "CODIGO DE BARRAS";
            this.COD_BARRAS.Name = "COD_BARRAS";
            // 
            // frmPesquisaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLivros);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisaLivros";
            this.Text = "frmPesquisaLivros";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOMBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXEMPLAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO_LANCAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BARRAS;
    }
}
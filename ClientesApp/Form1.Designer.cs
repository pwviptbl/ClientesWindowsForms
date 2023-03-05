namespace ClientesApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new ClientesApp.masterDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_CPF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pesquisar = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ClientesApp.masterDataSetTableAdapters.clientesTableAdapter();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(545, 237);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.masterDataSetBindingSource;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // text_CPF
            // 
            this.text_CPF.AutoSize = true;
            this.text_CPF.Location = new System.Drawing.Point(27, 80);
            this.text_CPF.Name = "text_CPF";
            this.text_CPF.Size = new System.Drawing.Size(27, 13);
            this.text_CPF.TabIndex = 3;
            this.text_CPF.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(105, 22);
            this.textBox_nome.MaxLength = 255;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(353, 20);
            this.textBox_nome.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.AccessibleDescription = "email";
            this.textBox_email.AccessibleName = "email";
            this.textBox_email.Location = new System.Drawing.Point(105, 52);
            this.textBox_email.MaxLength = 100;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(265, 20);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(105, 80);
            this.textBox_cpf.MaxLength = 14;
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(159, 20);
            this.textBox_cpf.TabIndex = 7;
            this.textBox_cpf.TextChanged += new System.EventHandler(this.textBox_cpf_TextChanged);
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(105, 108);
            this.textBox_tel.MaxLength = 15;
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(159, 20);
            this.textBox_tel.TabIndex = 8;
            this.textBox_tel.TextChanged += new System.EventHandler(this.textBox_tel_TextChanged);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(469, 22);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 9;
            this.button_insert.Text = "Cadastrar";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(469, 70);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 13;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pesquisar";
            // 
            // textBox_pesquisar
            // 
            this.textBox_pesquisar.Location = new System.Drawing.Point(105, 153);
            this.textBox_pesquisar.MaxLength = 255;
            this.textBox_pesquisar.Name = "textBox_pesquisar";
            this.textBox_pesquisar.Size = new System.Drawing.Size(181, 20);
            this.textBox_pesquisar.TabIndex = 16;
            this.textBox_pesquisar.TextChanged += new System.EventHandler(this.textBox_pesquisar_TextChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.masterDataSetBindingSource;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(469, 121);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 17;
            this.button_reset.Text = "Resetar";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(556, 428);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_pesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_cpf;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pesquisar;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private masterDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.Button button_reset;
    }
}


namespace AgendaAtendimentos
{
    partial class GerenciarProfissionais
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprofissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFISSIONAISBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HairUpDataSet2_Profissionais = new AgendaAtendimentos.DB_HairUpDataSet2_Profissionais();
            this.pROFISSIONAISTableAdapter1 = new AgendaAtendimentos.DB_HairUpDataSet2_ProfissionaisTableAdapters.PROFISSIONAISTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dBHairUpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROFISSIONAISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet2_Profissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHairUpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar Profissionais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cargo:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(124, 53);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(177, 31);
            this.txtnome.TabIndex = 1;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(124, 247);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(177, 31);
            this.txtcargo.TabIndex = 4;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(124, 120);
            this.txtcelular.Mask = "(00)00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(177, 31);
            this.txtcelular.TabIndex = 2;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(124, 188);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(177, 31);
            this.txtcpf.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(567, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 45;
            this.textBox3.Text = "1 de 30";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button9.Location = new System.Drawing.Point(719, 279);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 28);
            this.button9.TabIndex = 44;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button8.Location = new System.Drawing.Point(472, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 30);
            this.button8.TabIndex = 43;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button7.Location = new System.Drawing.Point(520, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 30);
            this.button7.TabIndex = 42;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button6.Location = new System.Drawing.Point(673, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 41;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btgravar
            // 
            this.btgravar.BackColor = System.Drawing.Color.Plum;
            this.btgravar.Location = new System.Drawing.Point(512, 148);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(252, 55);
            this.btgravar.TabIndex = 40;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = false;
            this.btgravar.Click += new System.EventHandler(this.button5_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bcancelar.Location = new System.Drawing.Point(647, 105);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(117, 37);
            this.bcancelar.TabIndex = 39;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.Location = new System.Drawing.Point(647, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 38;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(511, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 37;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnovo
            // 
            this.btnovo.BackColor = System.Drawing.Color.Plum;
            this.btnovo.Location = new System.Drawing.Point(511, 62);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(117, 37);
            this.btnovo.TabIndex = 36;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = false;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprofissionalDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROFISSIONAISBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 164);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idprofissionalDataGridViewTextBoxColumn
            // 
            this.idprofissionalDataGridViewTextBoxColumn.DataPropertyName = "id_profissional";
            this.idprofissionalDataGridViewTextBoxColumn.HeaderText = "id_profissional";
            this.idprofissionalDataGridViewTextBoxColumn.Name = "idprofissionalDataGridViewTextBoxColumn";
            this.idprofissionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // pROFISSIONAISBindingSource1
            // 
            this.pROFISSIONAISBindingSource1.DataMember = "PROFISSIONAIS";
            this.pROFISSIONAISBindingSource1.DataSource = this.dB_HairUpDataSet2_Profissionais;
            // 
            // dB_HairUpDataSet2_Profissionais
            // 
            this.dB_HairUpDataSet2_Profissionais.DataSetName = "DB_HairUpDataSet2_Profissionais";
            this.dB_HairUpDataSet2_Profissionais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFISSIONAISTableAdapter1
            // 
            this.pROFISSIONAISTableAdapter1.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(335, 174);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 29);
            this.button10.TabIndex = 48;
            this.button10.Text = "Alterar imagem";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = global::AgendaAtendimentos.Properties.Resources.profissionais;
            this.pictureBox1.Location = new System.Drawing.Point(335, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pROFISSIONAISBindingSource
            // 
            this.pROFISSIONAISBindingSource.DataMember = "PROFISSIONAIS";
            // 
            // GerenciarProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(776, 487);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "GerenciarProfissionais";
            this.Text = "Gerenciar Profissionais";
            this.Load += new System.EventHandler(this.GerenciarProfissionais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet2_Profissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHairUpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.BindingSource dBHairUpDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnovo;
        
        private System.Windows.Forms.BindingSource pROFISSIONAISBindingSource;
      
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_HairUpDataSet2_Profissionais dB_HairUpDataSet2_Profissionais;
        private System.Windows.Forms.BindingSource pROFISSIONAISBindingSource1;
        private DB_HairUpDataSet2_ProfissionaisTableAdapters.PROFISSIONAISTableAdapter pROFISSIONAISTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
    }
}
namespace AgendaAtendimentos
{
    partial class AgendaAtendimento
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dB_HairUpDataSet2_Profissionais = new AgendaAtendimentos.DB_HairUpDataSet2_Profissionais();
            this.dBHairUpDataSet2ProfissionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_HairUpDataSet_Agenda = new AgendaAtendimentos.DB_HairUpDataSet_Agenda();
            this.aGENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aGENDATableAdapter = new AgendaAtendimentos.DB_HairUpDataSet_AgendaTableAdapters.AGENDATableAdapter();
            this.idagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprofissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet2_Profissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHairUpDataSet2ProfissionaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENDABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda de Atendimentos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(12, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.Location = new System.Drawing.Point(148, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.Location = new System.Drawing.Point(148, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Plum;
            this.button5.Location = new System.Drawing.Point(616, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 55);
            this.button5.TabIndex = 10;
            this.button5.Text = "Gravar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profissional:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serviço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gabriela Carla",
            "Maria Julia",
            "Felipe",
            "Amanda Cristina",
            "Eduarda Costa"});
            this.comboBox1.Location = new System.Drawing.Point(351, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Vivi Siqueira",
            "Romeu Felipe",
            "Celso Kamura",
            "Marco Antônio de Biaggi",
            "Mara Roszak",
            "Mara Roszak",
            "Gue Oliveira",
            "Jen Atkin",
            "Gabriel Fernandes Tavares",
            "Marisa Alves Cesar",
            "Juliana Cabelano",
            "Lucas Silvano"});
            this.comboBox2.Location = new System.Drawing.Point(351, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 31);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Corte de cabelo feminino",
            "Coloração / Tintura",
            "Mechas / Luzes / Balayage",
            "Hidratação / Nutrição Capilar",
            "Escova e Prancha",
            "Penteado para festas",
            "Manicure e Pedicure",
            "Design de Sobrancelhas",
            "Depilação Corporal (cera)",
            "Maquiagem Profissional",
            "Combo CSMP (Cabelo + Sobrancelha + Manicure + Pedicure)"});
            this.comboBox3.Location = new System.Drawing.Point(351, 185);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 31);
            this.comboBox3.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(351, 254);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(244, 31);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(351, 337);
            this.maskedTextBox2.Mask = "90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(244, 31);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button6.Location = new System.Drawing.Point(487, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button7.Location = new System.Drawing.Point(334, 445);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button8.Location = new System.Drawing.Point(286, 446);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button9.Location = new System.Drawing.Point(533, 447);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 28);
            this.button9.TabIndex = 14;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "1 de 30";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(616, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(41, 31);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(616, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(41, 31);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(616, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(41, 31);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "8";
            // 
            // dB_HairUpDataSet2_Profissionais
            // 
            this.dB_HairUpDataSet2_Profissionais.DataSetName = "DB_HairUpDataSet2_Profissionais";
            this.dB_HairUpDataSet2_Profissionais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBHairUpDataSet2ProfissionaisBindingSource
            // 
            this.dBHairUpDataSet2ProfissionaisBindingSource.DataSource = this.dB_HairUpDataSet2_Profissionais;
            this.dBHairUpDataSet2ProfissionaisBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.idservicoDataGridViewTextBoxColumn,
            this.idprofissionalDataGridViewTextBoxColumn,
            this.dataagendaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aGENDABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dB_HairUpDataSet_Agenda
            // 
            this.dB_HairUpDataSet_Agenda.DataSetName = "DB_HairUpDataSet_Agenda";
            this.dB_HairUpDataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENDABindingSource
            // 
            this.aGENDABindingSource.DataMember = "AGENDA";
            this.aGENDABindingSource.DataSource = this.dB_HairUpDataSet_Agenda;
            // 
            // aGENDATableAdapter
            // 
            this.aGENDATableAdapter.ClearBeforeFill = true;
            // 
            // idagendaDataGridViewTextBoxColumn
            // 
            this.idagendaDataGridViewTextBoxColumn.DataPropertyName = "id_agenda";
            this.idagendaDataGridViewTextBoxColumn.HeaderText = "id_agenda";
            this.idagendaDataGridViewTextBoxColumn.Name = "idagendaDataGridViewTextBoxColumn";
            this.idagendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // idservicoDataGridViewTextBoxColumn
            // 
            this.idservicoDataGridViewTextBoxColumn.DataPropertyName = "id_servico";
            this.idservicoDataGridViewTextBoxColumn.HeaderText = "id_servico";
            this.idservicoDataGridViewTextBoxColumn.Name = "idservicoDataGridViewTextBoxColumn";
            // 
            // idprofissionalDataGridViewTextBoxColumn
            // 
            this.idprofissionalDataGridViewTextBoxColumn.DataPropertyName = "id_profissional";
            this.idprofissionalDataGridViewTextBoxColumn.HeaderText = "id_profissional";
            this.idprofissionalDataGridViewTextBoxColumn.Name = "idprofissionalDataGridViewTextBoxColumn";
            // 
            // dataagendaDataGridViewTextBoxColumn
            // 
            this.dataagendaDataGridViewTextBoxColumn.DataPropertyName = "data_agenda";
            this.dataagendaDataGridViewTextBoxColumn.HeaderText = "data_agenda";
            this.dataagendaDataGridViewTextBoxColumn.Name = "dataagendaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // AgendaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(776, 645);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AgendaAtendimento";
            this.Text = "Agenda de Atendimentos";
            this.Load += new System.EventHandler(this.AgendaAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet2_Profissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHairUpDataSet2ProfissionaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HairUpDataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENDABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private DB_HairUpDataSet2_Profissionais dB_HairUpDataSet2_Profissionais;
        private System.Windows.Forms.BindingSource dBHairUpDataSet2ProfissionaisBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_HairUpDataSet_Agenda dB_HairUpDataSet_Agenda;
        private System.Windows.Forms.BindingSource aGENDABindingSource;
        private DB_HairUpDataSet_AgendaTableAdapters.AGENDATableAdapter aGENDATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}


namespace HairUp
{
    partial class VisualizarAgenda
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
            this.label6 = new System.Windows.Forms.Label();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodagenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btfechar = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.dgvVisualizarAgenda = new System.Windows.Forms.DataGridView();
            this.idagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprofissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairUpDataSet2agenda = new HairUp.HairUpDataSet2agenda();
            this.aGENDATableAdapter = new HairUp.HairUpDataSet2agendaTableAdapters.AGENDATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet2agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Visualizar Agenda";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(481, 50);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(138, 38);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcodagenda
            // 
            this.txtcodagenda.Location = new System.Drawing.Point(255, 54);
            this.txtcodagenda.Name = "txtcodagenda";
            this.txtcodagenda.Size = new System.Drawing.Size(217, 33);
            this.txtcodagenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cód. Agenda:";
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Thistle;
            this.btfechar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.Location = new System.Drawing.Point(418, 391);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(146, 47);
            this.btfechar.TabIndex = 5;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.MediumPurple;
            this.btmenu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(266, 391);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(146, 47);
            this.btmenu.TabIndex = 4;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // dgvVisualizarAgenda
            // 
            this.dgvVisualizarAgenda.AutoGenerateColumns = false;
            this.dgvVisualizarAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.idservicoDataGridViewTextBoxColumn,
            this.idprofissionalDataGridViewTextBoxColumn,
            this.dataagendaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dgvVisualizarAgenda.DataSource = this.aGENDABindingSource;
            this.dgvVisualizarAgenda.Location = new System.Drawing.Point(67, 104);
            this.dgvVisualizarAgenda.Name = "dgvVisualizarAgenda";
            this.dgvVisualizarAgenda.Size = new System.Drawing.Size(673, 281);
            this.dgvVisualizarAgenda.TabIndex = 3;
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
            // aGENDABindingSource
            // 
            this.aGENDABindingSource.DataMember = "AGENDA";
            this.aGENDABindingSource.DataSource = this.hairUpDataSet2agenda;
            // 
            // hairUpDataSet2agenda
            // 
            this.hairUpDataSet2agenda.DataSetName = "HairUpDataSet2agenda";
            this.hairUpDataSet2agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENDATableAdapter
            // 
            this.aGENDATableAdapter.ClearBeforeFill = true;
            // 
            // VisualizarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVisualizarAgenda);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtcodagenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "VisualizarAgenda";
            this.Text = "Visualizar Agenda";
            this.Load += new System.EventHandler(this.VisualizarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet2agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodagenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.DataGridView dgvVisualizarAgenda;
        private HairUpDataSet2agenda hairUpDataSet2agenda;
        private System.Windows.Forms.BindingSource aGENDABindingSource;
        private HairUpDataSet2agendaTableAdapters.AGENDATableAdapter aGENDATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}
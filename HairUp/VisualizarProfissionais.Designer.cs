namespace HairUp
{
    partial class VisualizarProfissionais
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
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btfechar = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.dgvProfissionais = new System.Windows.Forms.DataGridView();
            this.idprofissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFISSIONAISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairUpDataSet1 = new HairUp.HairUpDataSet1();
            this.pROFISSIONAISTableAdapter = new HairUp.HairUpDataSet1TableAdapters.PROFISSIONAISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar Profissionais";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(514, 64);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(138, 38);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(288, 68);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(217, 33);
            this.txtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Digite o nome:";
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Thistle;
            this.btfechar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.Location = new System.Drawing.Point(404, 372);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(217, 59);
            this.btfechar.TabIndex = 5;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.MediumPurple;
            this.btmenu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(169, 372);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(217, 59);
            this.btmenu.TabIndex = 4;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // dgvProfissionais
            // 
            this.dgvProfissionais.AutoGenerateColumns = false;
            this.dgvProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprofissionalDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dgvProfissionais.DataSource = this.pROFISSIONAISBindingSource;
            this.dgvProfissionais.Location = new System.Drawing.Point(104, 118);
            this.dgvProfissionais.Name = "dgvProfissionais";
            this.dgvProfissionais.Size = new System.Drawing.Size(548, 204);
            this.dgvProfissionais.TabIndex = 3;
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
            // pROFISSIONAISBindingSource
            // 
            this.pROFISSIONAISBindingSource.DataMember = "PROFISSIONAIS";
            this.pROFISSIONAISBindingSource.DataSource = this.hairUpDataSet1;
            // 
            // hairUpDataSet1
            // 
            this.hairUpDataSet1.DataSetName = "HairUpDataSet1";
            this.hairUpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFISSIONAISTableAdapter
            // 
            this.pROFISSIONAISTableAdapter.ClearBeforeFill = true;
            // 
            // VisualizarProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProfissionais);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "VisualizarProfissionais";
            this.Text = "Visualizar Profissionais";
            this.Load += new System.EventHandler(this.VisualizarProfissionais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFISSIONAISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.DataGridView dgvProfissionais;
        private HairUpDataSet1 hairUpDataSet1;
        private System.Windows.Forms.BindingSource pROFISSIONAISBindingSource;
        private HairUpDataSet1TableAdapters.PROFISSIONAISTableAdapter pROFISSIONAISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}
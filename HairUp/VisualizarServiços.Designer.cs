namespace HairUp
{
    partial class VisualizarServiços
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
            this.txtservico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btfechar = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.dtvServicos = new System.Windows.Forms.DataGridView();
            this.idservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairUpDataSet2servicos = new HairUp.HairUpDataSet2servicos();
            this.sERVICOSTableAdapter = new HairUp.HairUpDataSet2servicosTableAdapters.SERVICOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet2servicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Visualizar Serviços";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(600, 69);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(138, 33);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtservico
            // 
            this.txtservico.Location = new System.Drawing.Point(344, 69);
            this.txtservico.Name = "txtservico";
            this.txtservico.Size = new System.Drawing.Size(248, 33);
            this.txtservico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Digite o nome do serviço:";
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Thistle;
            this.btfechar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.Location = new System.Drawing.Point(397, 391);
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
            this.btmenu.Location = new System.Drawing.Point(245, 391);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(146, 47);
            this.btmenu.TabIndex = 4;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // dtvServicos
            // 
            this.dtvServicos.AutoGenerateColumns = false;
            this.dtvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idservicoDataGridViewTextBoxColumn,
            this.nomeservicoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dtvServicos.DataSource = this.sERVICOSBindingSource;
            this.dtvServicos.Location = new System.Drawing.Point(43, 123);
            this.dtvServicos.Name = "dtvServicos";
            this.dtvServicos.Size = new System.Drawing.Size(695, 243);
            this.dtvServicos.TabIndex = 3;
            this.dtvServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idservicoDataGridViewTextBoxColumn
            // 
            this.idservicoDataGridViewTextBoxColumn.DataPropertyName = "id_servico";
            this.idservicoDataGridViewTextBoxColumn.HeaderText = "id_servico";
            this.idservicoDataGridViewTextBoxColumn.Name = "idservicoDataGridViewTextBoxColumn";
            this.idservicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeservicoDataGridViewTextBoxColumn
            // 
            this.nomeservicoDataGridViewTextBoxColumn.DataPropertyName = "nome_servico";
            this.nomeservicoDataGridViewTextBoxColumn.HeaderText = "nome_servico";
            this.nomeservicoDataGridViewTextBoxColumn.Name = "nomeservicoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // sERVICOSBindingSource
            // 
            this.sERVICOSBindingSource.DataMember = "SERVICOS";
            this.sERVICOSBindingSource.DataSource = this.hairUpDataSet2servicos;
            // 
            // hairUpDataSet2servicos
            // 
            this.hairUpDataSet2servicos.DataSetName = "HairUpDataSet2servicos";
            this.hairUpDataSet2servicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICOSTableAdapter
            // 
            this.sERVICOSTableAdapter.ClearBeforeFill = true;
            // 
            // VisualizarServiços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtvServicos);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtservico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "VisualizarServiços";
            this.Text = "Visualizar Serviços";
            this.Load += new System.EventHandler(this.VisualizarServiços_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet2servicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtservico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.DataGridView dtvServicos;
        private HairUpDataSet2servicos hairUpDataSet2servicos;
        private System.Windows.Forms.BindingSource sERVICOSBindingSource;
        private HairUpDataSet2servicosTableAdapters.SERVICOSTableAdapter sERVICOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}
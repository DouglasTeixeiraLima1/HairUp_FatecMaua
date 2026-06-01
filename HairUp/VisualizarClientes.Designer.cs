namespace HairUp
{
    partial class VisualizarClientes
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
            this.visualizacaoClientes = new HairUp.VisualizacaoClientes();
            this.visualizacaoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualizacaoClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairUpDataSet = new HairUp.HairUpDataSet();
            this.cLIENTESTableAdapter = new HairUp.HairUpDataSetTableAdapters.CLIENTESTableAdapter();
            this.btmenu = new System.Windows.Forms.Button();
            this.btfechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizar Clientes";
            // 
            // visualizacaoClientes
            // 
            this.visualizacaoClientes.DataSetName = "VisualizacaoClientes";
            this.visualizacaoClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visualizacaoClientesBindingSource
            // 
            this.visualizacaoClientesBindingSource.DataSource = this.visualizacaoClientes;
            this.visualizacaoClientesBindingSource.Position = 0;
            // 
            // visualizacaoClientesBindingSource1
            // 
            this.visualizacaoClientesBindingSource1.DataSource = this.visualizacaoClientes;
            this.visualizacaoClientesBindingSource1.Position = 0;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.cLIENTESBindingSource;
            this.dgvClientes.GridColor = System.Drawing.Color.Thistle;
            this.dgvClientes.Location = new System.Drawing.Point(99, 112);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(548, 204);
            this.dgvClientes.TabIndex = 3;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.hairUpDataSet;
            // 
            // hairUpDataSet
            // 
            this.hairUpDataSet.DataSetName = "HairUpDataSet";
            this.hairUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.MediumPurple;
            this.btmenu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(155, 379);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(217, 59);
            this.btmenu.TabIndex = 4;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Thistle;
            this.btfechar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.Location = new System.Drawing.Point(390, 379);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(217, 59);
            this.btfechar.TabIndex = 5;
            this.btfechar.Text = "Fechar";
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite o nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(283, 66);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(217, 33);
            this.txtnome.TabIndex = 1;
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(509, 62);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(138, 38);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // VisualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "VisualizarClientes";
            this.Text = "Visualizar Clientes";
            this.Load += new System.EventHandler(this.VisualizarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualizacaoClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairUpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VisualizacaoClientes visualizacaoClientes;
        private System.Windows.Forms.BindingSource visualizacaoClientesBindingSource;
        private System.Windows.Forms.BindingSource visualizacaoClientesBindingSource1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private HairUpDataSet hairUpDataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private HairUpDataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btpesquisar;
    }
}